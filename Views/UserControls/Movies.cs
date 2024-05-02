using Cinema_Booking_Management_System.Views.Forms;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Cinema_Booking_Management_System.UserControls
{
    public partial class Movies : UserControl
    {

        string connectionString = "server=127.0.0.1; port=3306;username=root;password=;database=cinema_management_system";
        private Movies moviesForm;
        public static Movies CurrentInstance;

        public Movies()
        {
            InitializeComponent();
            DisplayData();
            CurrentInstance = this;

            addUsersButton.MouseEnter += OnMouseEnterButton;
            addUsersButton.MouseLeave += OnMouseLeaveButton;
            moviesTable.CellFormatting += MoviesTable_CellFormatting;
        }

        private void OnMouseEnterButton(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(22, 23, 26);
        }

        private void OnMouseLeaveButton(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Transparent;
        }

        private void MoviesTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if the cell belongs to the Date column and is not in edit mode
            if (e.ColumnIndex == moviesTable.Columns["ReleaseDate"].Index && !moviesTable.CurrentCell.IsInEditMode)
            {
                // Convert the cell value to DateTime
                DateTime date = Convert.ToDateTime(e.Value);
                // Format the date and assign it back to the cell
                e.Value = date.ToString("MMM dd, yyyy");
                e.FormattingApplied = true;
            }
        }

        private void ApplyFiltersAndDisplayData()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Start with the base select statement
                string query = "SELECT MovieID, MovieTitle, ReleaseDate, Directors, Rating, TicketPrice, Status FROM movies";
                List<string> conditions = new List<string>();

                // Add condition for status if selected
                if (!string.IsNullOrEmpty(selectedStatus) && selectedStatus != "All Movies")
                {
                    conditions.Add($"Status = '{selectedStatus}'");
                }

                // Add condition for rating if selected
                if (!string.IsNullOrEmpty(selectedRating) && selectedRating != "All Rating")
                {
                    conditions.Add($"Rating = '{selectedRating}'");
                }

                // Add condition for title if search text is present
                string searchText = searchTextBox.Texts.Trim();
                if (!string.IsNullOrEmpty(searchText))
                {
                    conditions.Add($"MovieTitle LIKE '%{searchText}%'");
                }

                // Append conditions to the query if any exist
                if (conditions.Count > 0)
                {
                    query += " WHERE " + string.Join(" AND ", conditions);
                }

                // Execute the query and load the data into the DataGridView
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        moviesTable.DataSource = dataTable;
                    }
                }
            }
        }

        public void DisplayData()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT MovieID, MovieTitle, ReleaseDate, Directors, Rating, TicketPrice, Status FROM movies;";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        moviesTable.DataSource = dataTable;
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

            moviesTable.Columns.Add(editButtonColumn);

            // Find the column with header text "Edit"
            foreach (DataGridViewColumn column in moviesTable.Columns)
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

        private void Movies_Load(object sender, EventArgs e)
        {
            addEditButton();
        }

        private void moviesTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int editButtonColumnIndex = GetEditButtonColumnIndex();

            if (e.ColumnIndex == editButtonColumnIndex && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = moviesTable.Rows[e.RowIndex];
                MoviesFormEdit moviesFormEdit = new MoviesFormEdit(this);
                string movieID = selectedRow.Cells["MovieID"].Value.ToString();

                string genre = GetColumnValueFromDatabase("Genre", "movies", "MovieID", movieID);
                string duration = GetColumnValueFromDatabase("Duration", "movies", "MovieID", movieID);
                string cast = GetColumnValueFromDatabase("Cast", "movies", "MovieID", movieID);
                string description = GetColumnValueFromDatabase("Sypnosis", "movies", "MovieID", movieID);

                moviesFormEdit.movieTitleTextBox.Texts = selectedRow.Cells["MovieTitle"].Value.ToString();
                moviesFormEdit.releaseDate.Value = Convert.ToDateTime(selectedRow.Cells["ReleaseDate"].Value);
                moviesFormEdit.directorsTextBox.Texts = selectedRow.Cells["Directors"].Value.ToString();
                moviesFormEdit.ratingComboBox.SelectedItem = selectedRow.Cells["Rating"].Value.ToString();
                moviesFormEdit.ticketPriceTextBox.Texts = selectedRow.Cells["TicketPrice"].Value.ToString();
                moviesFormEdit.statusComboBox.SelectedItem = selectedRow.Cells["Status"].Value.ToString();
                moviesFormEdit._movieID = selectedRow.Cells["MovieID"].Value.ToString();

                moviesFormEdit.genreTextBox.Texts = genre;
                moviesFormEdit.durationTextBox.Texts = duration;
                moviesFormEdit.castTextBox.Texts = cast;
                moviesFormEdit.descriptionTextBox.Texts = description;

                byte[] posterData = GetImageFromDatabase("Poster", "movies", "MovieID", movieID);
                if (posterData != null && posterData.Length > 0)
                {
                    Image posterImage = ByteArrayToImage(posterData);
                    moviesFormEdit.posterPictureBox.Image = posterImage;
                    moviesFormEdit.IsImageLoaded = true;
                }
                else
                {
                    moviesFormEdit.posterPictureBox.Image = null; // Set to a default image or null
                }

                // Set text color to white for all textboxes
                moviesFormEdit.movieTitleTextBox.ForeColor = Color.White;
                moviesFormEdit.genreTextBox.ForeColor = Color.White;
                moviesFormEdit.directorsTextBox.ForeColor = Color.White;
                moviesFormEdit.releaseDate.CalendarForeColor = Color.White;
                moviesFormEdit.durationTextBox.ForeColor = Color.White;
                moviesFormEdit.ticketPriceTextBox.ForeColor = Color.White;
                moviesFormEdit.statusComboBox.ForeColor = Color.White;
                moviesFormEdit.castTextBox.ForeColor = Color.White;
                moviesFormEdit.durationTextBox.ForeColor = Color.White;
                moviesFormEdit.descriptionTextBox.ForeColor = Color.White;

                moviesFormEdit.IsEditButtonCLicked = true;
                moviesFormEdit.ShowDialog();
            }
        }


        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }

        private byte[] GetImageFromDatabase(string columnName, string tableName, string idColumnName, string idValue)
        {
            byte[] result = null;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = $"SELECT {columnName} FROM {tableName} WHERE {idColumnName} = @{idColumnName}";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue($"@{idColumnName}", idValue);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(columnName)))
                            {
                                result = (byte[])reader[columnName];
                            }
                        }
                    }
                }
            }

            return result;
        }

        private string GetColumnValueFromDatabase(string columnName, string tableName, string idColumnName, string idValue)
        {
            string result = null;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = $"SELECT {columnName} FROM {tableName} WHERE {idColumnName} = @{idColumnName}";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue($"@{idColumnName}", idValue);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            result = reader[columnName].ToString();
                        }
                    }
                }
            }

            return result;
        }

        private int GetEditButtonColumnIndex()
        {
            foreach (DataGridViewColumn column in moviesTable.Columns)
            {
                if (column.HeaderText == "Edit" && column is DataGridViewButtonColumn)
                {
                    return column.Index;
                }
            }

            return -1; // Return -1 if "Edit" button column is not found
        }

        private void addUsersButton_Click(object sender, EventArgs e)
        {
            MoviesForm movieForm = new MoviesForm(this);
            movieForm.ShowDialog();
        }

        private void searchTextBox__TextChanged(object sender, EventArgs e)
        {
            ApplyFiltersAndDisplayData();
        }

        string selectedStatus = null;
        string selectedRating = null;

        private void comboBoxStatus_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            selectedStatus = comboBoxStatus.SelectedItem.ToString();
            ApplyFiltersAndDisplayData();
        }

        private void ratingComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            selectedRating = ratingComboBox.SelectedItem.ToString();
            ApplyFiltersAndDisplayData();
        }

        private void LoadData()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Build the query based on the selected values
                string query = "SELECT MovieID, MovieTitle, ReleaseDate, Directors, Rating, TicketPrice, Status FROM movies";
                List<string> conditions = new List<string>();

                if (selectedStatus != null && selectedStatus != "All Movies")
                {
                    conditions.Add($"Status = '{selectedStatus}'");
                }

                if (selectedRating != null && selectedRating != "All Rating")
                {
                    conditions.Add($"Rating = '{selectedRating}'");
                }

                if (conditions.Any())
                {
                    query += " WHERE " + string.Join(" AND ", conditions);
                }

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        moviesTable.DataSource = dataTable;
                    }
                }
                connection.Close();
            }

        }
    }
}
