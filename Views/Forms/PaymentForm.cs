using Cinema_Booking_Management_System.UserControls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Booking_Management_System.Views.Forms
{
    public partial class PaymentForm : Form
    {
        string connectionString = "datasource=127.0.0.1; port=3306;username=root;password=;database=cinema_management_system; ";

        private Timer timer;
        private int currentLabelIndex;

        public List<Button> seatsSelected = new List<Button>();

        public int ScheduleId { get; set; }

        public int MovieId;
        public string MovieTitle;
        public string Date;
        public string Time;
        public int Cinema;
        public double TicketPrice;

        public PaymentForm()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);


        private void PaymentForm_Load(object sender, EventArgs e)
        {
            GetScheduleDetails(ScheduleId);

            seatsLabel.Text = FormatSeats();
            ticketQtyLabel.Text = GetPriceQuantity();

            subtotalLabel.Text = $"₱{GetSubTotal()}";
            vatLabel.Text = $"₱{GetVAT()}";

            totalLabel.Text = $"₱{GetTotal()}";
            totalLabelBig.Text = $"₱{GetTotal()}";

            StartLoadingAnimation(paymentInProgressLabel);

        }

        private double GetTotal()
        {
            double subtotal = Convert.ToDouble(GetSubTotal().ToString().Replace("₱", "").Replace(",", ""));
            double vat = Convert.ToDouble(GetVAT().ToString().Replace("₱", "").Replace(",", ""));
            double total = subtotal + vat;

            total = Math.Round(total, 2);

            return total;
        }

        public void GetScheduleDetails(int scheduleId)
        {
            string query = @"SELECT m.MovieID, m.MovieTitle, m.TicketPrice, s.Cinema, s.Date, s.StartTime
                     FROM schedules s
                     INNER JOIN movies m ON s.MovieId = m.MovieId
                     WHERE s.ScheduleId = @ScheduleId";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ScheduleId", scheduleId);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            MovieId = Convert.ToInt32(reader["MovieID"]);
                            MovieTitle = reader["MovieTitle"].ToString();
                            Cinema = Convert.ToInt32(reader["Cinema"]);
                            Date = DateTime.Parse(reader["Date"].ToString()).ToString("yyyy-MM-dd");
                            Time = DateTime.ParseExact(reader["StartTime"].ToString(), "HH:mm:ss", CultureInfo.InvariantCulture).ToString("HH:mm");
                            TicketPrice = Convert.ToDouble(reader["TicketPrice"]);

                            SetScheduleDetails();
                        }
                        else
                        {
                            // Handle the case where no schedule was found for the given ScheduleId.
                            throw new Exception("No schedule found for the given ScheduleId.");
                        }
                    }
                }
            }
        }

        private void SetScheduleDetails()
        {
            movieTitleLabel.Text = MovieTitle;
            cinemaLabel.Text = $"Cinema {Cinema}";
            dateLabel.Text = DateTime.Parse(Date).ToString("MMM d, yyyy");
            timeLabel.Text = DateTime.ParseExact(Time, "HH:mm", CultureInfo.InvariantCulture).ToString("hh:mm tt");
        }

        private double GetVAT()
        {
            double subtotal = Convert.ToDouble(GetSubTotal().ToString().Replace("₱", "").Replace(",", ""));
            double vat = subtotal * 0.12; // VAT is 12% of the subtotal
            vat = Math.Round(vat, 2);

            return vat;
        }

        private double GetSubTotal()
        {
            int quantity = seatsSelected.Count;
            double subtotal = quantity * TicketPrice;
            subtotal = Math.Round(subtotal, 2);

            return subtotal;
        }

        private string GetPriceQuantity()
        {
            int quantity = seatsSelected.Count;
            TicketPrice = Math.Round(TicketPrice, 2);

            return $"{quantity}x ₱{TicketPrice}";
        }

        private string FormatSeats()
        {
            string formattedSeats = string.Join("", seatsSelected.Select(btn => $"[{btn.Name}] "));
            return formattedSeats;
        }

        private string GetMovieTitle()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT MovieTitle FROM movies WHERE MovieID = @movieId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@movieId", MovieId);

                    string title = command.ExecuteScalar().ToString();

                    return title;
                }
            }
        }

        public void InsertBooking(int scheduleId, int movieId, List<Button> selectedSeats, int cinema, string date, string time)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string seats = string.Join(",", selectedSeats.Select(btn => btn.Name));

                // Get the current date and time
                DateTime currentDateTime = DateTime.Now;
                string bookedDate = currentDateTime.ToString("yyyy-MM-dd");
                string bookedTime = currentDateTime.ToString("HH:mm:ss");

                string query = @"INSERT INTO bookings (MovieID, Seats, Cinema, Date, Time, BookedDate, BookedTime, Status, Admin, Total) 
                         VALUES (@MovieId, @Seats, @Cinema, @Date, @Time, @BookedDate, @BookedTime, @Status, @Admin, @Total)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MovieId", movieId);
                    command.Parameters.AddWithValue("@Seats", seats);
                    command.Parameters.AddWithValue("@Cinema", cinema);
                    command.Parameters.AddWithValue("@Date", date);
                    command.Parameters.AddWithValue("@Time", time);
                    command.Parameters.AddWithValue("@BookedDate", bookedDate);
                    command.Parameters.AddWithValue("@BookedTime", bookedTime);
                    command.Parameters.AddWithValue("@Status", "Reserved");
                    command.Parameters.AddWithValue("@Admin", $"{CurrentUser.FirstName} {CurrentUser.LastName}");
                    command.Parameters.AddWithValue("@Total", GetTotal());

                    command.ExecuteNonQuery();
                }
            }
        }


        private void StartLoadingAnimation(Label loadingLabel)
        {
            int loadingState = 0;
            Timer timer = new Timer();
            timer.Interval = 500; // Update every half second
            timer.Tick += (sender, args) =>
            {
                switch (loadingState % 4)
                {
                    case 0:
                        loadingLabel.Text = "Payment In Progress";
                        break;
                    case 1:
                        loadingLabel.Text = "Payment In Progress.";
                        break;
                    case 2:
                        loadingLabel.Text = "Payment In Progress..";
                        break;
                    case 3:
                        loadingLabel.Text = "Payment In Progress...";
                        break;
                }
                loadingState++;
            };
            timer.Start();
        }


        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void panel11_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            SeatSelectionForm seatSelectionForm = new SeatSelectionForm();
            seatSelectionForm.MovieId = this.MovieId;
            seatSelectionForm.Show();
            this.Hide();
        }

        private void completeButton_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Has the customer already paid?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                PaymentFormSuccess paymentFormSuccess = new PaymentFormSuccess(this.ScheduleId, this.seatsSelected);
                InsertBooking(ScheduleId, MovieId, seatsSelected, Cinema, Date, Time);
                paymentFormSuccess.Show();
                this.Hide();
            }   
            else
            {
                MessageBox.Show("Please ensure the customer has made payment.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }   
}
