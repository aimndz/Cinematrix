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
    public partial class AdminBookings : Form
    {
        string connectionString = "datasource=127.0.0.1; port=3306;username=root;password=;database=cinema_management_system";

        public AdminBookings()
        {
            InitializeComponent();
            adminBookingsTable.CellFormatting += AdminBookingsTable_CellFormatting;
        }

        private void AdminBookings_Load(object sender, EventArgs e)
        {
            DisplayData();
            DisplayHeader(CurrentUser.FirstName);
        }

        private void DisplayHeader(string firstName)
        {
            headerLabel.Text = $"{firstName}'s Bookings";
        }

        private void AdminBookingsTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if the cell belongs to the Date column and is not in edit mode
            if (e.ColumnIndex == adminBookingsTable.Columns["Date"].Index && !adminBookingsTable.CurrentCell.IsInEditMode)
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
            string adminName = CurrentUser.FirstName + " " + CurrentUser.LastName;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = $@"SELECT b.BookingID, m.MovieTitle, b.Cinema, b.Date, b.Time, b.Seats, b.BookedDate, b.BookedTime, b.Total, b.Status 
                          FROM bookings b 
                          INNER JOIN movies m ON b.MovieID = m.MovieID 
                          WHERE b.Admin = @adminName
                          ORDER BY b.BookedDate DESC, b.BookedTime DESC";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@adminName", adminName);
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        adminBookingsTable.DataSource = dataTable;
                    }
                }
                connection.Close();
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

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

        private void label1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
