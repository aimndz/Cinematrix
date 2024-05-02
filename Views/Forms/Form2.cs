using Cinema_Booking_Management_System.Properties;
using Cinema_Booking_Management_System.UserControls;
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
    public partial class Form2 : Form
    {

        NavigationControl navigationControl;
        NavigationButtons navigationButtons;

        Color btnDefaultColor = Color.FromArgb(37, 38, 43);
        Color btnDefaultForeColor = Color.FromArgb(255, 255, 255);
        Color btnSelectedColor = Color.FromArgb(79, 191, 255);
        Color btnSelectedForeColor = Color.FromArgb(0, 0, 0);

        public Form2()
        {
            InitializeComponent();
            InitializeNavigationControl();
            InitializeNavigationButtons();
            ApplyRoundedCorners();
        }

        public Panel getMainPanel()
        {
            return mainPanel;
        }

        private void InitializeNavigationControl()
        {
            List<UserControl> userControls = new List<UserControl>() // Your UserControl list
            { new Dashboard(), new Movies(), new Schedules(), new Bookings(), new Users()};

            navigationControl = new NavigationControl(userControls, mainPanel); // Create an instance of NavigatonControl
            navigationControl.Display(0); // Display Dashboard as default
        }

        private void InitializeNavigationButtons()
        {
            List<Button> buttons = new List<Button>()
            {dashboardNav, moviesNav, scheduleNav, bookingsNav, userNav};

            // create a NavigationButtons instance
            navigationButtons = new NavigationButtons(buttons, btnDefaultColor, btnSelectedColor, btnSelectedForeColor, btnDefaultForeColor);

            // make a default selected button
            navigationButtons.Highlight(dashboardNav);
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

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dashboardNav_Click(object sender, EventArgs e)
        {
            navigationControl.Display(0);
            navigationButtons.Highlight(dashboardNav);
        }

        private void moviesNav_Click(object sender, EventArgs e)
        {
            navigationControl.Display(1);
            navigationButtons.Highlight(moviesNav);
        }

        private void scheduleNav_Click(object sender, EventArgs e)
        {
            navigationControl.Display(2);
            navigationButtons.Highlight(scheduleNav);
        }

        private void bookingsNav_Click(object sender, EventArgs e)
        {
            navigationControl.Display(3);
            navigationButtons.Highlight(bookingsNav);
        }

        private void userNav_Click(object sender, EventArgs e)
        {
            navigationControl.Display(4);
            navigationButtons.Highlight(userNav);
        }

        private void signOutNav_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to sign out?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            { 
                form1.Show();
                this.Hide();
            }
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void panel11_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }
}
