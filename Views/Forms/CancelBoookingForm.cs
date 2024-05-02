using Cinema_Booking_Management_System.UserControls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Booking_Management_System
{
    public partial class CancelBoookingForm : Form
    {

        string connectionString = "datasource=127.0.0.1; port=3306;username=root;password=;database=cinema_management_system";
        private string _bookingID;
        public CancelBoookingForm(string bookingID)
        {
            _bookingID = bookingID;
            InitializeComponent();
            ApplyRoundedCorners();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void ApplyRoundedCorners()
        {
            int radius = 1; // You can adjust this value to change the roundness

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
            path.AddArc(this.Width - radius * 2, 0, radius * 2, radius * 2, 270, 90);
            path.AddArc(this.Width - radius * 2, this.Height - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddArc(0, this.Height - radius * 2, radius * 2, radius * 2, 90, 90);

            this.Region = new Region(path);
        }

        private void CancelBoookingForm_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void DisplayData()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = $@"SELECT b.BookingID, m.MovieTitle, b.Cinema, b.Date, b.Time, b.Admin, b.Seats, b.Total, b.Status 
                          FROM bookings b 
                          INNER JOIN movies m ON b.MovieID = m.MovieID 
                          WHERE b.BookingID = @BookingID;";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BookingID", _bookingID);
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            movieTitleLabel.Text = reader.GetString(1);
                            cinemaLabel.Text = $"CINEMA {reader.GetInt32(2).ToString()}";

                            string time = $"{reader.GetTimeSpan(4).ToString()}";
                            dateLabel.Text = $"{reader.GetDateTime(3).ToString("MMM dd, yyyy")} • {time}";
                           // timeLabel.Text = 
                            seatsLabel.Text = reader.GetString(6); 
                            totalLabel.Text = $"₱{reader.GetDecimal(7).ToString()}";
                        }
                    }
                    connection.Close();
                }
            }
        }


        private void cinemaButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "UPDATE bookings SET Status = @Status WHERE BookingID = @BookingID";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Status", "Cancelled");
                    command.Parameters.AddWithValue("@BookingID", _bookingID);
                    connection.Open();
                    command.ExecuteNonQuery();
                    Bookings.CurrentInstance.DisplayData();

                    connection.Close();
                }
            }
            // Optionally, you could refresh the form or navigate away after updating the status
            this.Close();
        }

        private void cinemaButton1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
