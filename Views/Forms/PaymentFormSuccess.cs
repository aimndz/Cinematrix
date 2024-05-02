using Cinema_Booking_Management_System.UserControls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Booking_Management_System.Views.Forms
{
    public partial class PaymentFormSuccess : Form
    {
        string connectionString = "datasource=127.0.0.1; port=3306;username=root;password=;database=cinema_management_system";

        public List<Button> seatsSelected = new List<Button>();
       

        public int MovieId { get; set; }
        public int ScheduleId { get; set; }

        public double TicketPrice;

        private PrintDocument printDocument;
        private PrintPreviewDialog printPreviewDialog;
        private PrintDialog printDialog;

        public PaymentFormSuccess(int scheduleId, List<Button> selectedSeats)
        {
            InitializeComponent();

            ScheduleId = scheduleId;
            seatsSelected = selectedSeats;
            TicketPrice = GetTicketPrice(ScheduleId);

            GetScheduleDetails(this.ScheduleId);

            seatsLabel.Text = FormatSeats();
            ticketQtyLabel.Text = GetPriceQuantity();

            subtotalLabel.Text = $"₱{GetSubTotal()}";
            vatLabel.Text = $"₱{GetVAT()}";

            totalLabel.Text = $"₱{GetTotal()}";
            //GetBookingId();

            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;
            printDocument.DefaultPageSettings.Landscape = true;

            // Other initialization...

            // Initialize print preview components
            printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;

            printDialog = new PrintDialog();
            printDialog.Document = printDocument;

        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap groupBoxBmp = new Bitmap(groupBox1.Width, groupBox1.Height);
            groupBox1.DrawToBitmap(groupBoxBmp, new Rectangle(0, 0, groupBox1.Width, groupBox1.Height));
            e.Graphics.DrawImage(groupBoxBmp, 0, 0);

            // Then, draw the PictureBox (if it contains an image)
            if (pictureBox1.Image != null)
            {
                // Calculate the position and size of the PictureBox in the print document
                int x = pictureBox1.Location.X + groupBox1.Location.X;
                int y = pictureBox1.Location.Y + groupBox1.Location.Y;
                int width = pictureBox1.Width;
                int height = pictureBox1.Height;

                // Draw the PictureBox onto the print document
                e.Graphics.DrawImage(pictureBox1.Image, x, y, width, height);
            }


        }

        private void GetBookingId()
        {
            string query = @"SELECT BookingId FROM bookings WHERE ScheduleId = @ScheduleId";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ScheduleId", ScheduleId);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        string bookingId = result.ToString();
                        bookingIDLabel.Text = bookingId;
                    }
                    else
                    {
                        throw new Exception($"No booking found for ScheduleId: {ScheduleId}");
                    }
                }
            }
        }
        public void GetScheduleDetails(int scheduleId)
        {
            string query = @"SELECT m.MovieTitle, s.Cinema, s.Date, s.StartTime
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
                            string movieTitle = reader["MovieTitle"].ToString();
                            string cinema = reader["Cinema"].ToString();
                            string date = reader["Date"].ToString();
                            string time = reader["StartTime"].ToString();

                            movieTitleLabel.Text = movieTitle;
                            cinemaLabel.Text = $"Cinema {cinema}";
                            dateLabel.Text = DateTime.Parse(date).ToString("MMM d, yyyy");
                            timeLabel.Text = DateTime.ParseExact(time, "HH:mm:ss", CultureInfo.InvariantCulture).ToString("hh:mm tt");
                        }
                        else
                        {
                            throw new Exception("No schedule found for the given ScheduleId.");
                        }
                    }
                }
            }
        }

        private double GetTicketPrice(int scheduleId)
        {
            string query = @"SELECT m.TicketPrice
                     FROM schedules s
                     INNER JOIN movies m ON s.MovieID = m.MovieId
                     WHERE s.ScheduleID = @ScheduleId";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ScheduleId", scheduleId);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        double ticketPrice = Convert.ToDouble(result.ToString());
                        return ticketPrice;
                    }
                    else
                    {
                        throw new Exception($"No movie found with ScheduleId: {scheduleId}");
                    }
                }
            }
        }


        private double GetTotal()
        {
            double subtotal = Convert.ToDouble(GetSubTotal().ToString().Replace("₱", "").Replace(",", ""));
            double vat = Convert.ToDouble(GetVAT().ToString().Replace("₱", "").Replace(",", ""));
            double total = subtotal + vat;

            total = Math.Round(total, 2);

            return total;
        }

        private double GetVAT()
        {
            double subtotal = Convert.ToDouble(GetSubTotal().ToString().Replace("₱", "").Replace(",", ""));
            double vat = subtotal * 0.12; // VAT is 12% of the subtotal

            return vat;
        }

        private double GetSubTotal()
        {
            int quantity = seatsSelected.Count;
            double subtotal = quantity * TicketPrice;

            return subtotal;
        }

        private string GetPriceQuantity()
        {
            int quantity = seatsSelected.Count;

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

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        string title = result.ToString();
                        return title;
                    }
                    else
                    {
                        throw new Exception($"No movie found with ID: {MovieId}");
                    }
                }
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

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

        private void cinemaPanel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            PaymentForm form = new PaymentForm();
            form.Show();
            this.Hide();
        }

        private void backToDashboard_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
       

        private void cinemaButton1_Click(object sender, EventArgs e)
        {
            printPreviewDialog.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
