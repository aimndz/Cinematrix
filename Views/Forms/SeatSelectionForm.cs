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
    public partial class SeatSelectionForm : Form
    {
        string connectionString = "datasource=127.0.0.1; port=3306;username=root;password=;database=cinema_management_system";

        List<Button> seatsSelected = new List<Button>();
        List<Button> seatsReserved = new List<Button>();

        public int ScheduleId { get; set; }
        public int MovieId { get; set; }
        private List<string> dateList = new List<string>();
        private List<string> timeRangeList = new List<string>();

        public SeatSelectionForm()
        {
            InitializeComponent();

            List<Button> buttonList = GetAllButtons();
            foreach (Button button in buttonList)
            {
                button.Click += button_Click;
            }
        }

        public int GetScheduleId()
        {
            string query = "SELECT ScheduleID FROM schedules WHERE MovieId = @MovieId AND Cinema = @Cinema AND Date = @Date AND StartTime = @Time";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@MovieId", MovieId);
                    command.Parameters.AddWithValue("@Cinema", int.Parse(cinemaLabel.Text));
                    command.Parameters.AddWithValue("@Date", DateTime.Parse(comboBoxDate.SelectedItem.ToString()).ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@Time", FormatTime(comboBoxTime.SelectedItem.ToString()));

                    //MessageBox.Show("Movie: " + MovieId.ToString());
                    //MessageBox.Show("Cinema: " + int.Parse(cinemaLabel.Text).ToString());
                    //MessageBox.Show("Date: " +  DateTime.Parse(comboBoxDate.SelectedItem.ToString()).ToString("yyyy-MM-dd"));
                    //MessageBox.Show("Time: " + FormatTime(comboBoxTime.SelectedItem.ToString()));

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.GetInt32("ScheduleId");
                            
                        }
                        else
                        {
                            throw new Exception("No schedule found for the given parameters.");
                        }
                    }
                }
            }
        }

        private void SeatSelectionForm_Load(object sender, EventArgs e)
        {
            LoadMovieTitles();
            DisplayTicketPriceAndDuration();
            LoadSchedulesDate();
            LoadSchedulesTime();
            LoadCinemaNo();
            GetReservedSeats();
            UpdateReservedSeats();

            ScheduleId = GetScheduleId();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            // Prevent selection of more than 20 seats
            if (seatsSelected.Count >= 20)
            {
                MessageBox.Show("You cannot select more than 20 seats.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!seatsReserved.Contains(clickedButton)) // Check if the clicked button is not in the reserved seats list
            {
                if (seatsSelected.Contains(clickedButton))
                {
                    seatsSelected.Remove(clickedButton);
                }
                else
                {
                    seatsSelected.Add(clickedButton);
                }

                UpdateSeatsSelectedLabel();
                UpdateReservedSeats();
                UpdateSelectedColor();
            }
            else
            {
                MessageBox.Show("This seat is already reserved.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void comboBoxMovie_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            seatsSelected.Clear();
            UpdateSeatsSelectedLabel();
            // Get the selected item in the ComboBox
            var selectedItem = (DataRowView)comboBoxMovie.SelectedItem;

            MovieId = Convert.ToInt32(selectedItem["MovieID"]);

            DisplayTicketPriceAndDuration();
            LoadSchedulesDate();
            LoadSchedulesTime();
            LoadCinemaNo();
           
            GetReservedSeats();
            ClearSeats();
            UpdateReservedSeats();

            ScheduleId = GetScheduleId();
        }

        private void comboBoxDate_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            seatsSelected.Clear();
            UpdateSeatsSelectedLabel();
            timeRangeList.Clear();
            comboBoxTime.Texts = "";

            LoadSchedulesTime();
            LoadCinemaNo();
            GetReservedSeats();
            ClearSeats();
            UpdateReservedSeats();

            ScheduleId = GetScheduleId();
        }

        private void comboBoxTime_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            seatsSelected.Clear();
            UpdateSeatsSelectedLabel();
            LoadCinemaNo();
            GetReservedSeats();
            ClearSeats();
            UpdateReservedSeats();

            ScheduleId = GetScheduleId();
        }

        private void LoadMovieTitles()
        {
            comboBoxMovie.OnSelectedIndexChanged -= comboBoxMovie_OnSelectedIndexChanged;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = @"SELECT DISTINCT s.MovieId, m.MovieTitle, m.Poster FROM Schedules s   
                  INNER JOIN Movies m ON s.MovieId = m.MovieId   
                  WHERE s.Date >= CURDATE()  
                  AND m.Status = 'Now Showing'";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        comboBoxMovie.DataSource = dataTable;
                        comboBoxMovie.DisplayMember = "MovieTitle";
                        comboBoxMovie.ValueMember = "MovieID";

                        if (MovieId > 0)
                        {
                            for (int i = 0; i < dataTable.Rows.Count; i++)
                            {
                                string movieIdStr = dataTable.Rows[i]["MovieID"].ToString();
                                if (int.TryParse(movieIdStr, out int movieId))
                                {
                                    if (movieId == MovieId)
                                    {
                                        comboBoxMovie.SelectedIndex = i;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                connection.Close();
            }

            comboBoxMovie.OnSelectedIndexChanged += comboBoxMovie_OnSelectedIndexChanged;
        }

        private void LoadCinemaNo()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Parse the comboBoxDate and comboBoxTime values
                DateTime selectedDate = DateTime.Parse(comboBoxDate.SelectedItem.ToString());

                // Modify the query to select based on MovieId, selected date, and selected time
                string query = "SELECT Cinema FROM schedules WHERE MovieID = @MovieId AND Date = @SelectedDate AND StartTime <= @SelectedTime AND EndTime > @SelectedTime";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    //MessageBox.Show(selectedDate.ToString("yyyy-MM-dd"));
                    //MessageBox.Show(FormatTime(comboBoxTime.SelectedItem.ToString()));

                    command.Parameters.AddWithValue("@MovieId", MovieId);
                    command.Parameters.AddWithValue("@SelectedDate", selectedDate.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@SelectedTime", FormatTime(comboBoxTime.SelectedItem.ToString()));

                    

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string cinemaNumber = reader["Cinema"].ToString();

                            // Assuming you have a Label control named cinemaNumberLabel
                            cinemaLabel.Text = cinemaNumber;
                        }
                        else
                        {
                            // Handle the case where no cinema number was found for the given MovieId.
                            cinemaLabel.Text = "Not Available";
                        }
                    }
                }
                connection.Close();
            }
        }

        private void LoadSchedulesDate()
        {
            dateList.Clear();
            comboBoxDate.Texts = "";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Date FROM schedules WHERE MovieId = @MovieId AND Date >= CURDATE()";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MovieId", MovieId);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        // Loop through the rows in the DataTable and add them to the List
                        foreach (DataRow row in dataTable.Rows)
                        {
                            DateTime date = Convert.ToDateTime(row["Date"]);
                            string formattedDate = date.ToString("MMM dd, yyyy");
                            dateList.Add(formattedDate);
                        }
                    }
                }
                connection.Close();
            }

            // Remove duplicates from the List
            var distinctDateList = dateList.Distinct().ToList();

            // Bind the distinct dates to the ComboBox
            comboBoxDate.DataSource = distinctDateList;
        }


        private void LoadSchedulesTime()
        {
            timeRangeList.Clear();
            comboBoxTime.DataSource = null;
            // Get the selected date from the ComboBox
            DateTime selectedDate = DateTime.Parse(comboBoxDate.SelectedItem.ToString());

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Determine whether to include the current time condition in the query
                bool includeCurrentTimeCondition = selectedDate.Date == DateTime.Today;

                // Build the query based on the condition
                string query = $@"SELECT StartTime, EndTime FROM schedules
                          WHERE MovieId = @MovieId AND Date = @SelectedDate
                          {(includeCurrentTimeCondition ? "AND StartTime >= NOW()" : "")}";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MovieId", MovieId);
                    command.Parameters.AddWithValue("@SelectedDate", selectedDate.ToString("yyyy-MM-dd"));

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        // Loop through the rows in the DataTable and add them to the List
                        foreach (DataRow row in dataTable.Rows)
                        {
                            TimeSpan startTime = (TimeSpan)row["StartTime"];
                            TimeSpan endTime = (TimeSpan)row["EndTime"];

                            DateTime startDateTime = DateTime.Today.Add(startTime);
                            DateTime endDateTime = DateTime.Today.Add(endTime);

                            string formattedTimeRange = $"{startDateTime:hh:mm tt}-{endDateTime:hh:mm tt}"; // Format the time range as "hh:mm AM/PM - hh:mm AM/PM"
                            timeRangeList.Add(formattedTimeRange);
                        }
                    }
                }
                connection.Close();
            }

            // Bind the time ranges to the ComboBox
            comboBoxTime.DataSource = timeRangeList;
        }


        private void UpdateReservedSeats()
        {
            List<Button> buttonList = GetAllButtons();

            foreach (Button button in buttonList)
            {
                if (seatsReserved.Contains(button))
                {
                    //MessageBox.Show(button.Name.ToString());
                    button.BackColor = Color.FromArgb(89, 255, 255); // Blue
                }
            }
        }

        private void ClearSeats()
        {
            List<Button> buttonList = GetAllButtons();

            foreach (Button button in buttonList)
            {
                button.BackColor = Color.FromArgb(37, 38, 43); // Default color
            }
        }

        private void UpdateSelectedColor()
        {

            ClearSeats();

            foreach (Button button in seatsSelected)
            {
                button.BackColor = Color.FromArgb(202, 41, 41); // Red
            }

            UpdateReservedSeats();
        }

        private void UpdateSeatsSelectedLabel()
        {
            var seatNames = seatsSelected.Select(button => button.Name).ToList();
            string seats = string.Join(", ", seatNames);

            seatsSelectedLabel.Text = seats;
        }


        private void DisplayTicketPriceAndDuration()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT TicketPrice, Duration FROM movies WHERE MovieID = @MovieId";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MovieId", MovieId);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            decimal ticketPrice = Convert.ToDecimal(reader["TicketPrice"]);
                            string movieDuration = reader["Duration"].ToString(); // Fetch the movie duration

                            // Display the ticket price and movie duration in your UI here.
                            // For example, if you have a Label control named ticketPriceLabel and durationLabel:
                            ticketPriceLabel.Text = $"₱{ticketPrice}";
                            durationLabel.Text = $"{movieDuration} mins";
                        }
                        else
                        {
                            // Handle the case where no ticket price or movie duration was found for the given MovieId.
                            ticketPriceLabel.Text = "No ticket price available.";
                            durationLabel.Text = "No duration available.";
                        }
                    }
                }
                connection.Close();
            }
        }

        private List<Button> GetAllButtons()
        {
            return new List<Button>
            {
                A5, A6, A7, A8, A9, A10, A11, A12, A13, A14, A15, A16,
                B3, B4, B5, B6, B7, B8, B9, B10, B11, B12, B13, B14, B15, B16, B17, B18,
                C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20,
                D1, D2, D3, D4, D5, D6, D7, D8, D9, D10, D11, D12, D13, D14, D15, D16, D17, D18, D19, D20,
                E1, E2, E3, E4, E5, E6, E7, E8, E9, E10, E11, E12, E13, E14, E15, E16, E17, E18, E19, E20,
                F1, F2, F3, F4, F5, F6, F7, F8, F9, F10, F11, F12, F13, F14, F15, F16, F17, F18, F19, F20,
                G1, G2, G3, G4, G5, G6, G7, G8, G9, G10, G11, G12, G13, G14, G15, G16, G17, G18, G19, G20,
                H1, H2, H3, H4, H5, H6, H7, H8, H9, H10, H11, H12, H13, H14, H15, H16, H17, H18, H19, H20,
                I1, I2, I3, I4, I5, I6, I7, I8, I9, I10, I11, I12, I13, I14, I15, I16, I17, I18, I19, I20,
                J1, J2, J3, J4, J5, J6, J7, J8, J9, J10, J11, J12, J13, J14, J15, J16, J17, J18, J19, J20
            };
        }

        private void GetReservedSeats()
        {
            string query = "SELECT Seats FROM bookings WHERE MovieId = @MovieId AND Cinema = @Cinema AND Date = @Date AND Time = @Time AND Status = 'Reserved'";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Display the values in MessageBox
                    //MessageBox.Show($"MovieId: {MovieId}");
                    //MessageBox.Show($"Cinema: {int.Parse(cinemaLabel.Text)}");
                    //MessageBox.Show($"Date: {DateTime.Parse(comboBoxDate.SelectedItem.ToString()).ToString("yyyy-MM-dd")}");
                    //MessageBox.Show($"Time: {FormatTime(comboBoxTime.SelectedItem.ToString())}");

                    command.Parameters.AddWithValue("@MovieId", MovieId);
                    command.Parameters.AddWithValue("@Cinema", int.Parse(cinemaLabel.Text));
                    command.Parameters.AddWithValue("@Date", DateTime.Parse(comboBoxDate.SelectedItem.ToString()).ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@Time", FormatTime(comboBoxTime.SelectedItem.ToString()));

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        seatsReserved.Clear();

                        while (reader.Read())
                        {
                            string seatNumbers = reader["Seats"].ToString();
                            string[] seats = seatNumbers.Split(',');

                            foreach (string seat in seats)
                            {
                                string seatName = seat.Trim(); // Trim any leading or trailing whitespace
                                Button seatButton = this.Controls.Find(seatName, true).FirstOrDefault() as Button;

                                if (seatButton != null)
                                {
                                    seatsReserved.Add(seatButton);
                                }
                            }
                        }
                    }
                }

                connection.Close();
            }
        }

        private string FormatTime(string timeRange)
        {
            string[] times = timeRange.Split('-');

            string startTimeStr = times[0].Trim();
            DateTime startTime = DateTime.ParseExact(startTimeStr, "h:mm tt", CultureInfo.InvariantCulture);
            TimeSpan timeSpan = startTime.TimeOfDay;

            string formattedTime = timeSpan.ToString(@"hh\:mm\:ss");

            return formattedTime;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();

            AllShowingMovies allShowingMovies = new AllShowingMovies();
            form2.mainPanel.Controls.Add(allShowingMovies);
            allShowingMovies.BringToFront();
            allShowingMovies.Dock = DockStyle.Fill;
        }

        private void dashboardNav_Click(object sender, EventArgs e)
        {
            if (seatsSelected.Count != 0)
            {
                PaymentForm paymentForm = new PaymentForm();
                paymentForm.MovieId = this.MovieId;
                paymentForm.seatsSelected = this.seatsSelected;
                paymentForm.Date = comboBoxDate.SelectedItem.ToString();
                paymentForm.Time = comboBoxTime.SelectedItem.ToString();
                paymentForm.Cinema = Convert.ToInt32(cinemaLabel.Text);
                paymentForm.TicketPrice = Convert.ToDouble(ticketPriceLabel.Text.Replace("₱", ""));
                paymentForm.ScheduleId = this.ScheduleId;
                paymentForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a seat.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void panel11_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
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
    }
}
