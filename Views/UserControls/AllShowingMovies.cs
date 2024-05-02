using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cinema_Booking_Management_System.Utilities;
using Cinema_Booking_Management_System.Views.Forms;

namespace Cinema_Booking_Management_System.UserControls
{
    public partial class AllShowingMovies : UserControl
    {
        string connectionString = "Server=localhost; Port=3306; User=root; Password=; Database=cinema_management_system";

        public AllShowingMovies()
        {
            InitializeComponent();
        }

        private void AllShowingMovies_Load(object sender, EventArgs e)
        {
            PopulateFlowLayoutPanel(allShowingPanel);

        }

        private void goBackLabel_Click(object sender, EventArgs e)
        {
            // Assuming DashboardPanel is the Panel containing Dashboard UserControl
            Panel allShowingMoviesPanel = UserControlHelper.FindContainingPanel(this);

            if (allShowingMoviesPanel != null)
            {
                // Assuming AllShowingMovies is a user control
                Dashboard dashboard = new Dashboard();
                dashboard.Dock = DockStyle.Fill;

                // Add AllShowingMovies control to the same Panel
                allShowingMoviesPanel.Controls.Add(dashboard);
                
                dashboard.BringToFront();
            }
        }

        private void PopulateFlowLayoutPanel(FlowLayoutPanel flowlayoutpanel)
        {
            flowlayoutpanel.Controls.Clear();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Build the query without checking for the current time
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
                                    Tag = movieId, // Store movieId in Tag property
                                    Cursor = Cursors.Hand
                                };

                                pictureBox.Click += PictureBox_Click; // Attach event handler
                                flowlayoutpanel.Controls.Add(pictureBox);
                            }
                        }
                    }
                }
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

    }
}
