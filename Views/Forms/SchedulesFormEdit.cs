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
    public partial class SchedulesFormEdit : Form
    {
        string connectionString = "datasource=127.0.0.1; port=3306;username=root;password=;database=cinema_management_system";
        public string _scheduleId;
        public int movieId { get; set; }

        public SchedulesFormEdit(int movieId)
        {
            InitializeComponent();
            this.movieId = movieId;
        }

        private void SchedulesFormEdit_Load(object sender, EventArgs e)
        {
            LoadMovieTitles();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

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

        private void userEditButton_Click(object sender, EventArgs e)
        {
            // Parse the start time from the TextBox
            DateTime startTime;
            if (!DateTime.TryParse(schedulesStartTime.Texts, out startTime))
            {
                // Invalid time format
                MessageBox.Show("Invalid time format. Please enter the time in HH:mm format.");
                return;
            }

            // Check if start time is entered
            if (string.IsNullOrEmpty(schedulesStartTime.Texts))
            {
                MessageBox.Show("Please enter a start time.");
                return;
            }

            // Check if showing date is in the future
            if (showingDate.Value <= DateTime.Now)
            {
                MessageBox.Show("The showing date cannot be in the past.");
                return;
            }

            // Check if a cinema is selected
            if (comboBoxCinema.SelectedItem == null)
            {
                MessageBox.Show("Please select a cinema.");
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

                    // Assume you have the ScheduleID
                    int scheduleId = Convert.ToInt32(_scheduleId); // Fetch or compute the ScheduleID

                    // Update the schedule in the database
                    query = $"UPDATE schedules SET " +
                            $"MovieID={movieId}, " +
                            $"Cinema='{comboBoxCinema.SelectedItem.ToString()}', " +
                            $"Date='{showingDate.Value.ToString("yyyy-MM-dd HH:mm:ss")}', " +
                            $"StartTime='{startTime.ToString("yyyy-MM-dd HH:mm:ss")}', " +
                            $"EndTime='{endTime.ToString("yyyy-MM-dd HH:mm:ss")}' " +
                            $"WHERE ScheduleID={scheduleId}";

                    using (MySqlCommand updateCommand = new MySqlCommand(query, connection))
                    {
                        Schedules.CurrentInstance.LoadSchedules(movieId.ToString());
                        updateCommand.ExecuteNonQuery();
                    }
                }
                connection.Close();
            }

            this.Hide();
        }
    }
}
