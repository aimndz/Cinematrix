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
using Cinema_Booking_Management_System.Properties;
using Cinema_Booking_Management_System.UserControls;
using Cinema_Booking_Management_System.Views.Forms;
using MySql.Data.MySqlClient;

namespace Cinema_Booking_Management_System
{
    public partial class Form1 : Form
    {
        private bool isToggle = false;
        string connectionString = "Server=localhost; Port=3306; User=root; Password=; Database=cinema_management_system";
        
        public Form1()
        {
            InitializeComponent();
            ApplyRoundedCorners();

            // Set the AcceptButton property to the login button
            this.AcceptButton = loginButton;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM users WHERE Username = @username AND Password = @password";

            using (MySqlConnection databaseConnection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection))
                {
                    commandDatabase.Parameters.AddWithValue("@username", usernameTextBox.Texts);
                    commandDatabase.Parameters.AddWithValue("@password", passwordTextBox.Texts);
                    commandDatabase.CommandTimeout = 60;
                    MySqlDataReader reader;

                    databaseConnection.Open();
                    reader = commandDatabase.ExecuteReader();

                    while (reader.Read())
                    {
                        CurrentUser.FirstName = reader["FirstName"].ToString();
                        CurrentUser.LastName = reader["LastName"].ToString();

                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form2 form2 = new Form2();
                        form2.Show();
                        this.Hide();

                        return;
                    }
                }
            }

            // If the while loop completes without returning, it means no rows were found.
            MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void ApplyRoundedCorners()
        {
            int radius = 1;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
            path.AddArc(this.Width - radius * 2, 0, radius * 2, radius * 2, 270, 90);
            path.AddArc(this.Width - radius * 2, this.Height - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddArc(0, this.Height - radius * 2, radius * 2, radius * 2, 90, 90);

            this.Region = new Region(path);
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

        private void cinemaTextBox1__TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Text CHanged");
        }

        private void showHideImg_Click(object sender, EventArgs e)
        {
            if (isToggle)
            {
                showHideImg.BackgroundImage = Resources.show;
                passwordTextBox.PasswordChar = true; 
                isToggle = false;
            }
            else
            {
                showHideImg.BackgroundImage = Resources.hide;
                passwordTextBox.PasswordChar = false;
                isToggle =  true;
            }
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

    }
}
