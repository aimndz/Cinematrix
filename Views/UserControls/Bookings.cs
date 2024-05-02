using Cinema_Booking_Management_System.Utilities;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Booking_Management_System.UserControls
{
    public partial class Bookings : UserControl
    {
        string connectionString = "datasource=127.0.0.1; port=3306;username=root;password=;database=cinema_management_system; convert zero datetime=True";
        public static Bookings CurrentInstance;

        public Bookings()
        {
            InitializeComponent();
            DisplayData();
            CurrentInstance = this;
        }

        private void Bookings_Load(object sender, EventArgs e)
        {
            AddUpdateButton();
            DisableButton();

            Timer timer = new Timer();
            timer.Interval = 500; 
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void DisableButton()
        {
            // Disable the button in rows where the status is "Cancelled"
            foreach (DataGridViewRow row in bookingsTable.Rows)
            {
                var status = row.Cells["Status"].Value;
                if (!status.ToString().Equals("Reserved", StringComparison.OrdinalIgnoreCase))
                {
                    int updateButtonColumnIndex = GetUpdateButtonColumnIndex();
                    if (updateButtonColumnIndex >= 0)
                    {
                        var cell = row.Cells[updateButtonColumnIndex];
                        var buttonCell = (DataGridViewDisableButtonCell)cell;
                        buttonCell.Enabled = false;

                    }
                }
            }
        }

        public void DisplayData()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = @"SELECT b.BookingID, m.MovieTitle, b.Cinema, b.Date, b.Time, b.Admin, b.Seats, b.BookedDate, b.BookedTime, b.Total, b.Status  
                 FROM bookings b INNER JOIN movies m ON b.MovieID = m.MovieID  
                 ORDER BY b.BookingID DESC;";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        // Add a new column for displaying the formatted Total
                        dataTable.Columns.Add("Total ", typeof(string));

                        // Iterate over the rows in the DataTable
                        foreach (DataRow row in dataTable.Rows)
                        {
                            // Convert the Total column to a currency string
                            row["Total "] = $"₱ {((decimal)row["Total"]).ToString("N")}";
                        }

                        bookingsTable.DataSource = dataTable;
                        bookingsTable.Columns["Total"].Visible = false;
                    }
                }
                connection.Close();
            }
        }

        private void AddUpdateButton()
        {
            DataGridViewDisableButtonColumn updateButtonColumn = new DataGridViewDisableButtonColumn();
            updateButtonColumn.HeaderText = "Cancel";
            updateButtonColumn.Text = "Cancel";
            updateButtonColumn.UseColumnTextForButtonValue = true;

            bookingsTable.Columns.Add(updateButtonColumn);

            // Find the column with header text "Cancel"
            foreach (DataGridViewColumn column in bookingsTable.Columns)
            {
                if (column.HeaderText == "Cancel" && column is DataGridViewDisableButtonColumn)
                {
                    DataGridViewDisableButtonColumn c = (DataGridViewDisableButtonColumn)column;
                    c.FlatStyle = FlatStyle.Flat;
                    c.DefaultCellStyle.ForeColor = Color.FromArgb(160, 31, 31);
                    c.DefaultCellStyle.BackColor = Color.FromArgb(16, 16, 20);
                    break;
                }
            }   
        }

        private void bookingsTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int editButtonColumnIndex = GetUpdateButtonColumnIndex();

            if (e.ColumnIndex == editButtonColumnIndex && e.RowIndex >= 0)
            {
                var cell = bookingsTable.Rows[e.RowIndex].Cells[editButtonColumnIndex];
                var buttonCell = (DataGridViewDisableButtonCell)cell;

                if (buttonCell.Enabled)
                {
                    DataGridViewRow selectedRow = bookingsTable.Rows[e.RowIndex];
                    string bookingID = selectedRow.Cells["BookingID"].Value.ToString();
                    CancelBoookingForm cancelBoookingForm = new CancelBoookingForm(bookingID);
                    cancelBoookingForm.ShowDialog();
                }
            }
        }

        private int GetUpdateButtonColumnIndex()
        {
            foreach (DataGridViewColumn column in bookingsTable.Columns)
            {
                if (column.HeaderText == "Cancel" && column is DataGridViewDisableButtonColumn)
                {
                    return column.Index;
                }
            }

            return -1; // Return -1 if "Cancel" button column is not found
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DisplayData();
            UpdatePastBookings();
            DisableButton();
           // ErrorMessage();
        }

        public void ErrorMessage()
        {
            List<string> errorMessages = new List<string>
            {
                "Error: Itulog mo na kasi yannnn",
                "Error: STOP STOP STOP",
                "Error: Ano na naman ba ito",
                "Error: Di ko na rin alam",
                "Error: BWAHAHAHAHAHA",
                "Error: Pano ba kasi to wtf",
                "Error: ihh",
                "Error: Erawr",
                "Error: Daming oras ah",
                "Error: Natatae ako",
            };
            // Create a new instance of the Random class
            Random rand = new Random();

            // Select a random index from the list
            int index = rand.Next(errorMessages.Count);

            // Use the selected index to get a random error message
            string message = errorMessages[index];

            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void UpdatePastBookings()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = @"UPDATE bookings SET Status = 'Complete' WHERE Date <= NOW() AND Time <= NOW() AND Status = 'Reserved' AND Status != 'Cancelled'";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
    }
}
