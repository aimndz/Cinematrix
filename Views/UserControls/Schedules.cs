using Cinema_Booking_Management_System.Utilities;
using Cinema_Booking_Management_System.Views.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Booking_Management_System.UserControls
{
   
    public partial class Schedules : UserControl
    {
        string connectionString = "datasource=127.0.0.1; port=3306;username=root;password=;database=cinema_management_system";

        public static Schedules CurrentInstance;
        private bool isTodayButtonChecked = false;
        private bool isThisWeekButtonChecked = false;
        public Schedules()
        {
            InitializeComponent();

           //Attach hover events to specific buttons
            //todayButton.MouseEnter += OnMouseEnterButton;
            //todayButton.MouseLeave += OnMouseLeaveButton;

            //thisWeekButton.MouseEnter += OnMouseEnterButton;
            //thisWeekButton.MouseLeave += OnMouseLeaveButton;

            addUsersButton.MouseEnter += OnMouseEnterButton;
            addUsersButton.MouseLeave += OnMouseLeaveButton;
            schedulesTable.CellFormatting += SchedulesTable_CellFormatting;

            DisplayData();
            CurrentInstance = this;
        }

        private void OnMouseEnterButton(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(22, 23, 26);
        }

        private void OnMouseLeaveButton(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Transparent;
        }

        private void Schedules_Load(object sender, EventArgs e)
        {
            addEditButton();
            LoadMovieTitles();
            comboBoxMovie.OnSelectedIndexChanged += ComboBoxMovie_SelectedIndexChanged;
        }
        private void ComboBoxMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the MovieID of the selected movie
            var selectedMovie = comboBoxMovie.SelectedItem as DataRowView;
            if (selectedMovie != null)
            {
                string movieID = selectedMovie.Row["MovieID"].ToString();

                // Load the schedules of the selected movie
                LoadSchedules(movieID);
            }
        }

        public void UpdateVacantSeats()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Assuming you have a method to calculate the total number of booked seats
                int totalFixedSeats = 188;

                // Loop through all the schedules and update the Vacant column
                string scheduleUpdateQuery = @"UPDATE schedules SET Vacant = ?totalFixedSeats - IFNULL((SELECT SUM(LENGTH(Seats) - LENGTH(REPLACE(Seats, ',', '')) +  1) FROM bookings WHERE MovieID = schedules.MovieID AND Cinema = schedules.Cinema AND Date = schedules.Date AND Time = schedules.StartTime),  0)";
                using (MySqlCommand command = new MySqlCommand(scheduleUpdateQuery, connection))
                {
                    command.Parameters.AddWithValue("?totalFixedSeats", totalFixedSeats);
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        private void SchedulesTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if the cell belongs to the Date column and is not in edit mode
            if (e.ColumnIndex == schedulesTable.Columns["Date"].Index && !schedulesTable.CurrentCell.IsInEditMode)
            {
                // Convert the cell value to DateTime
                DateTime date = Convert.ToDateTime(e.Value);
                // Format the date and assign it back to the cell
                e.Value = date.ToString("MMM dd, yyyy");
                e.FormattingApplied = true;
            }
        }

        public void DisplayData()
        {
            UpdateVacantSeats();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = @"SELECT ScheduleID, Cinema, Date, StartTime, EndTime, Vacant FROM schedules";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        schedulesTable.DataSource = dataTable;

                        // Hook up the CellFormatting event after populating the DataTable
                        schedulesTable.CellFormatting -= SchedulesTable_CellFormatting;
                        schedulesTable.CellFormatting += SchedulesTable_CellFormatting;
                    }
                }
                connection.Close();
            }
        }

        private void addEditButton()
        {
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.HeaderText = "Edit";
            editButtonColumn.Text = "Edit";
            editButtonColumn.UseColumnTextForButtonValue = true;

            schedulesTable.Columns.Add(editButtonColumn);

            // Find the column with header text "Edit"
            foreach (DataGridViewColumn column in schedulesTable.Columns)
            {
                if (column.HeaderText == "Edit" && column is DataGridViewButtonColumn)
                {
                    DataGridViewButtonColumn c = (DataGridViewButtonColumn)column;
                    c.FlatStyle = FlatStyle.Flat;
                    c.DefaultCellStyle.ForeColor = Color.White;
                    c.DefaultCellStyle.BackColor = Color.FromArgb(16, 16, 20); ;
                    break;
                }
            }
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
                        comboBoxMovie.Texts = "Select Movie";
                    }
                }
                connection.Close();
            }
        }

        public void LoadSchedules(string movieID)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = $"SELECT ScheduleID, Cinema, Date, StartTime, EndTime, Vacant FROM schedules WHERE MovieID = @MovieID";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MovieID", movieID);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        schedulesTable.DataSource = dataTable;
                    }
                }
                connection.Close();
            }
        }

        private void addUsersButton_Click(object sender, EventArgs e)
        {
            var selectedMovie = comboBoxMovie.SelectedItem as DataRowView;
            if (selectedMovie != null)
            {
                int movieID = Convert.ToInt32(selectedMovie.Row["MovieID"].ToString());

                SchedulesForm schedulesForm = new SchedulesForm(movieID, this);
                schedulesForm.ShowDialog();
            }
        }

        private void schedulesTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int editButtonColumnIndex = GetEditButtonColumnIndex();

            if (e.ColumnIndex == editButtonColumnIndex && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = schedulesTable.Rows[e.RowIndex];

                int movieId = 0;

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Movies.MovieID FROM Movies INNER JOIN Schedules ON Movies.MovieID = Schedules.MovieID WHERE Schedules.ScheduleID = @scheduleID";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@scheduleID", selectedRow.Cells["ScheduleID"].Value.ToString());
                        var reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            movieId = Convert.ToInt32(reader["MovieID"]);
                        }
                    }
                }

                SchedulesFormEdit schedulesFormEdit = new SchedulesFormEdit(movieId);
                schedulesFormEdit.comboBoxCinema.Texts = selectedRow.Cells["Cinema"].Value.ToString();
                schedulesFormEdit.showingDate.Value = Convert.ToDateTime(selectedRow.Cells["Date"].Value);
                schedulesFormEdit.schedulesStartTime.Texts = selectedRow.Cells["StartTime"].Value.ToString();
                schedulesFormEdit._scheduleId = selectedRow.Cells["ScheduleID"].Value.ToString();

                string cinemaNumber = selectedRow.Cells["Cinema"].Value.ToString();
                int selectedIndex = schedulesFormEdit.comboBoxCinema.Items.Cast<string>().ToList().IndexOf(cinemaNumber);
                if (selectedIndex != -1)
                {
                    schedulesFormEdit.comboBoxCinema.SelectedIndex = selectedIndex;
                }

                schedulesFormEdit.ShowDialog();
            }
        }

        private int GetEditButtonColumnIndex()
        {
            foreach (DataGridViewColumn column in schedulesTable.Columns)
            {
                if (column.HeaderText == "Edit" && column is DataGridViewButtonColumn)
                {
                    return column.Index;
                }
            }

            return -1; // Return -1 if "Edit" button column is not found
        }

        private void todayButton_Click(object sender, EventArgs e)
        {
            string movieID = "";
            // Get the MovieID of the selected movie
            var selectedMovie = comboBoxMovie.SelectedItem as DataRowView;
            if (selectedMovie != null)
            {
                movieID = selectedMovie.Row["MovieID"].ToString();
            }

            if (!isTodayButtonChecked)
            {
                // Set todayButton to a different color and thisWeekButton to default color
                todayButton.BackColor = Color.FromArgb(79, 191, 255); // Example color for selected
                thisWeekButton.BackColor = Color.Transparent; // Reset to default
                isTodayButtonChecked = true;
                isThisWeekButtonChecked = false;
                LoadSchedulesForToday();
            }
            else
            {
                // Unselect todayButton and reset color
                todayButton.BackColor = Color.Transparent; // Reset to default
                isTodayButtonChecked = false;
                LoadSchedules(movieID); // Reload original schedules
            }
        }

        private void thisWeekButton_Click(object sender, EventArgs e)
        {
            string movieID = "";
            // Get the MovieID of the selected movie
            var selectedMovie = comboBoxMovie.SelectedItem as DataRowView;
            if (selectedMovie != null)
            {
                movieID = selectedMovie.Row["MovieID"].ToString();
            }

            if (!isThisWeekButtonChecked)
            {
                // Set thisWeekButton to a different color and todayButton to default color
                thisWeekButton.BackColor = Color.FromArgb(79, 191, 255); // Example color for selected
                todayButton.BackColor = Color.Transparent; // Reset to default
                isThisWeekButtonChecked = true;
                isTodayButtonChecked = false;
                LoadSchedulesForThisWeek();
            }
            else
            {
                // Unselect thisWeekButton and reset color
                thisWeekButton.BackColor = Color.Transparent; // Reset to default
                isThisWeekButtonChecked = false;
                LoadSchedules(movieID); // Reload original schedules
            }
        }

        private void LoadSchedulesForToday()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                DateTime today = DateTime.Today;
                string query = $"SELECT ScheduleID, Cinema, Date, StartTime, EndTime, Vacant FROM schedules WHERE DATE(`Date`) = '{today.ToString("yyyy-MM-dd")}'";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        schedulesTable.DataSource = dataTable;
                    }
                }
                connection.Close();
            }
        }

        private void LoadSchedulesForThisWeek()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                DateTime startOfWeek = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);
                DateTime endOfWeek = startOfWeek.AddDays(6);
                string query = $"SELECT ScheduleID, Cinema, Date, StartTime, EndTime, Vacant FROM schedules WHERE `Date` BETWEEN '{startOfWeek.ToString("yyyy-MM-dd")}' AND '{endOfWeek.ToString("yyyy-MM-dd")}'";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        schedulesTable.DataSource = dataTable;
                    }
                }
                connection.Close();
            }
        }
    }

    
}
