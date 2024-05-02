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
    public partial class UsersFormEdit : Form
    {
        string connectionString = "datasource=127.0.0.1; port=3306;username=root;password=;database=cinema_management_system";

        public event Action RefreshData;
        private Users usersForm;

        public string _userId;

        public UsersFormEdit(Users usersForm)
        {
            InitializeComponent();
            ApplyRoundedCorners();
            this.usersForm = usersForm;
        }

        public string UserId
        {
            get { return _userId; }
            set { _userId = value; }
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


        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void userEditButton_Click(object sender, EventArgs e)
        {
            // Avoid blank textbox
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Texts) ||
                string.IsNullOrWhiteSpace(lastNameTextBox.Texts) ||
                string.IsNullOrWhiteSpace(phoneNumberTextBox.Texts) ||
                string.IsNullOrWhiteSpace(addressTextBox.Texts) ||
                string.IsNullOrWhiteSpace(emailTextBox.Texts))
            {
                MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate phone number
            if (!UtilityHelper.IsValidPhoneNumber(phoneNumberTextBox.Texts))
            {
                MessageBox.Show("Please enter a valid phone number starting with '09' and containing 11 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate email format
            if (!UtilityHelper.IsValidEmail(emailTextBox.Texts))
            {
                MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "UPDATE users SET FirstName = @FirstName, LastName = @LastName, Address = @Address, " +
                               "BirthDate = @BirthDate, PhoneNumber = @PhoneNumber, Email = @Email WHERE UserID = @UserID";

                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                        command.Parameters.AddWithValue("@FirstName", firstNameTextBox.Texts);
                        command.Parameters.AddWithValue("@LastName", lastNameTextBox.Texts);
                        command.Parameters.AddWithValue("@BirthDate", birthDate.Value.ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@PhoneNumber", phoneNumberTextBox.Texts);
                        command.Parameters.AddWithValue("@Address", addressTextBox.Texts);
                        command.Parameters.AddWithValue("@Email", emailTextBox.Texts);
                        command.Parameters.AddWithValue("@UserID", _userId);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Users.CurrentInstance.DisplayData();
                            MessageBox.Show("Admin data inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert admin data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        this.Close();
                }
            }
        }
    }
}
