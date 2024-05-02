using Cinema_Booking_Management_System.Views.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Booking_Management_System.UserControls
{
    public partial class Dashboard : UserControl
    {
        string connectionString = "Server=localhost; Port=3306; User=root; Password=; Database=cinema_management_system";
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            UpdateTimeLabel();
            DashBoardDetails();
            PopulateFlowLayoutPanel(moviesDashboard);
            setGreetingMessage();
        }

        private void setGreetingMessage()
        {
             greetingLabel.Text = $"Hello, {CurrentUser.FirstName}!";
        }

        private void DashBoardDetails()
        {
            numberOfMovies();
            numbertodaysBookings();
            todaysRevenue();
        }

        private void numberOfMovies()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // Determine whether to include the current time condition in the query
            bool includeCurrentTimeCondition = DateTime.Today.Equals(DateTime.Now.Date);


            string query = $@"SELECT COUNT(DISTINCT s.MovieId), m.Poster FROM Schedules s  
                          INNER JOIN Movies m ON s.MovieId = m.MovieId  
                          WHERE s.Date >= CURDATE()  
                            AND m.Status = 'Now Showing'";

            MySqlCommand command = new MySqlCommand(query, connection);
            int numberOfMovies = Convert.ToInt32(command.ExecuteScalar());

            showingCount.Text = $"{numberOfMovies}";
            connection.Close();
        }

        private void numbertodaysBookings()
        {
            DateTime now = DateTime.Now;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = $"SELECT COUNT(*) FROM bookings WHERE DATE(BookedDate) = '{now.ToString("yyyy-MM-dd")}' AND BOOKEDTIME <= NOW() AND Status != 'Cancelled'";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    int todaysBooking = Convert.ToInt32(command.ExecuteScalar());

                    todaysBookings.Text = $"{todaysBooking}";
                    connection.Close();
                }
            }
        }

        private void todaysRevenue()
        {
            DateTime now = DateTime.Now;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = $"SELECT SUM(Total) FROM bookings WHERE DATE(BookedDate) = '{now.ToString("yyyy-MM-dd")}' AND BOOKEDTIME <= NOW() AND Status != 'Cancelled'";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal todaysRevenue = Convert.ToDecimal(result);
                        totalRevenueLabel.Text = $"₱{todaysRevenue.ToString("N2")}";
                    }
                    else
                    {
                        totalRevenueLabel.Text = "₱0";
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateTimeLabel();
        }

        private void UpdateTimeLabel()
        {
            DateTime currentTime = DateTime.Now;

            string date = currentTime.ToString("MMM dd, yyyy") + "  •  " + currentTime.ToString("dddd");


            hours.Text = currentTime.ToString("hh");
            minutes.Text = currentTime.ToString("mm");
            seconds.Text = currentTime.ToString("ss");
            AMPM.Text = currentTime.ToString("tt");
            formattedDate.Text = date ;
        }

        private List<byte[]> GetAllImagesData()
        {
            List<byte[]> imagesData = new List<byte[]>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Poster FROM Movies WHERE Status='Now showing'";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            byte[] imageData = (byte[])reader["Poster"];
                            imagesData.Add(imageData);
                        }
                    }
                }
            }

            return imagesData;
        }

        private void PopulateFlowLayoutPanel(FlowLayoutPanel flowlayoutpanel)
        {

            flowlayoutpanel.Controls.Clear();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = @"SELECT DISTINCT s.MovieId, m.Poster FROM Schedules s   
                  INNER JOIN Movies m ON s.MovieId = m.MovieId   
                  WHERE s.Date >= CURDATE()  
                  AND m.Status = 'Now Showing'";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            byte[] imageData = (byte[])reader["Poster"];
                            int movieId = Convert.ToInt32(reader["MovieId"]);

                            if (imageData != null)
                            {
                                PictureBox pictureBox = new PictureBox
                                {
                                    SizeMode = PictureBoxSizeMode.Zoom,
                                    Width = 200,
                                    Height = 275,
                                    Image = Image.FromStream(new MemoryStream(imageData)),
                                    Margin = new Padding(20),
                                    Tag = movieId,
                                    Cursor = Cursors.Hand
                                };

                                pictureBox.Click += PictureBox_Click;
                                flowlayoutpanel.Controls.Add(pictureBox);
                            }
                        }
                    }
                }
            }
        }

        private void viewAllButton_Click(object sender, EventArgs e)
        {
            // Assuming DashboardPanel is the Panel containing Dashboard UserControl
            Panel dashboardPanel = UserControlHelper.FindContainingPanel(this);

            if (dashboardPanel != null)
            {
                // Assuming AllShowingMovies is a user control
                AllShowingMovies allShowingMovies = new AllShowingMovies();
                allShowingMovies.Dock = DockStyle.Fill;

                // Add AllShowingMovies user control to the same Panel
                dashboardPanel.Controls.Add(allShowingMovies);
                allShowingMovies.BringToFront();
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            if (pictureBox != null && pictureBox.Tag != null)
            {
                int movieId = Convert.ToInt32(pictureBox.Tag);
                // Now you can use movieId
                SeatSelectionForm seatSelectionForm = new SeatSelectionForm();
                seatSelectionForm.MovieId = movieId; // Set movieId property
                ParentForm.Hide(); // Hide the parent form
                seatSelectionForm.ShowDialog();
            }
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            AdminBookings adminBookings = new AdminBookings();
            adminBookings.Show();

            // Hide the parent form
            ParentForm?.Hide();

        }

    }
}
