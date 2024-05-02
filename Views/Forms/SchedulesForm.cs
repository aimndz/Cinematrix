using Cinema_Booking_Management_System.UserControls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Booking_Management_System.Views.Forms
{
    public partial class SchedulesForm : Form
    {
        string connectionString = "datasource=127.0.0.1; port=3306;username=root;password=;database=cinema_management_system";
        public int movieId { get; set; }
        private Schedules schedulesForm;
        public SchedulesForm(int movieId, Schedules schedulesForm)
        {
            InitializeComponent();
            this.movieId = movieId;
            this.schedulesForm = schedulesForm;
        }
        private void SchedulesForm_Load(object sender, EventArgs e)
        {
            LoadMovieTitles();

        }

        private bool IsValid24HourTimeFormat(string input)
        {
            return TimeSpan.TryParse(input, out _);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void LoadMovieTitles()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT MovieID, MovieTitle FROM movies WHERE Status = 'Now showing'";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        // Bind the movie titles to the ComboBox
                        comboBoxMovie.DataSource = dataTable;
                        comboBoxMovie.DisplayMember = "MovieTitle";
                        comboBoxMovie.ValueMember = "MovieID";

                        // Set the default selected item in the ComboBox
                        if (movieId > 0)
                        {
                            for (int i = 0; i < dataTable.Rows.Count; i++)
                            {
                                string movieIdStr = dataTable.Rows[i]["MovieID"].ToString();
                                if (int.TryParse(movieIdStr, out int MovieId))
                                {
                                    if (MovieId == movieId)
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
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private bool CheckExistingRecord(MySqlConnection connection, int movieId, string cinema, DateTime showDate, DateTime startTime, DateTime endTime)
        {
           /* string message = $"Movie ID: {movieId}\n" +
              $"Cinema: {cinema}\n" +
              $"Show Date: {showDate.ToString("yyyy-MM-dd")}\n" +
              $"Start Time: {startTime.ToString("yyyy-MM-dd HH:mm:ss")}\n" +
              $"End Time: {endTime.ToString("yyyy-MM-dd HH:mm:ss")}";
            MessageBox.Show(message, "Parameter Values", MessageBoxButtons.OK, MessageBoxIcon.Information);*/

            string query = @"SELECT COUNT(*) FROM schedules
                     WHERE MovieID = @movieId AND Cinema = @cinema AND Date = @showDate
                     AND ((StartTime BETWEEN @startTime AND @endTime) OR (EndTime BETWEEN @startTime AND @endTime))";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
               command.Parameters.AddWithValue("@movieId", movieId);
               command.Parameters.AddWithValue("@cinema", Convert.ToInt32(cinema));
               command.Parameters.AddWithValue("@showDate", showDate.Date.ToString("yyyy-MM-dd"));
               command.Parameters.AddWithValue("@startTime", startTime.ToString("yyyy-MM-dd HH:mm:ss"));
               command.Parameters.AddWithValue("@endTime", endTime.ToString("yyyy-MM-dd HH:mm:ss"));

                int count = Convert.ToInt32(command.ExecuteScalar());
                return count > 0; // Returns true if there is an overlap, false otherwise
            }
        }


        private void userEditButton_Click(object sender, EventArgs e)
        {
            // Check if a cinema is selected
            if (cinemaComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a cinema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if start time is entered
            if (string.IsNullOrEmpty(schedulesStartTime.Texts))
            {
                MessageBox.Show("Please enter a start time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if showing date is in the future
            if (showingDate.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("The showing date cannot be in the past.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
             
            // Parse the start time from the TextBox
            DateTime startTime;
            if (!DateTime.TryParse(schedulesStartTime.Texts, out startTime) || !IsValid24HourTimeFormat(schedulesStartTime.Texts))
            {
                // Invalid time format
                MessageBox.Show("Invalid time format. Please enter the time in HH:mm format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedMovie = (DataRowView)comboBoxMovie.SelectedItem;
            int movieId = (int)selectedMovie.Row["MovieID"];

            // Retrieve the movie duration from the database
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = $"SELECT Duration FROM movies WHERE MovieID = {movieId}";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    int movieDuration = (int)command.ExecuteScalar();

                    // Calculate the end time
                    DateTime endTime = startTime.AddMinutes(movieDuration);

                    // Check if the movie, cinema, showing date, startTime, and endTime already exist
                    bool isCollision = CheckExistingRecord(connection, movieId, cinemaComboBox.SelectedItem.ToString(), showingDate.Value, startTime, endTime);
                    if (isCollision)
                    {
                        MessageBox.Show("The start time collides with an existing schedule.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Save the schedule to the database
                    query = $"INSERT INTO schedules (MovieID, Cinema, Date, StartTime, EndTime, Vacant) VALUES" +
                            $"({movieId}," +
                            $"'{cinemaComboBox.SelectedItem.ToString()}'," +
                            $"'{showingDate.Value.ToString("yyyy-MM-dd HH:mm:ss")}'," +
                            $"'{startTime.ToString("yyyy-MM-dd HH:mm:ss")}'," +
                            $"'{endTime.ToString("yyyy-MM-dd HH:mm:ss")}'," +
                            $"'188')";

                    using (MySqlCommand insertCommand = new MySqlCommand(query, connection))
                    {
                        insertCommand.ExecuteNonQuery();
                        Schedules.CurrentInstance.LoadSchedules(movieId.ToString());
                    }
                }
                connection.Close();
            }

            this.Hide();

        }
    }
}
