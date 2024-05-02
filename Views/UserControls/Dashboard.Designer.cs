namespace Cinema_Booking_Management_System.UserControls
{
    partial class Dashboard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.cinemaPanel3 = new Cinema_Booking_Management_System.UserControls.CinemaPanel();
            this.moviesDashboard = new System.Windows.Forms.FlowLayoutPanel();
            this.viewAllButton = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cinemaPanel2 = new Cinema_Booking_Management_System.UserControls.CinemaPanel();
            this.cinemaPanel7 = new Cinema_Booking_Management_System.UserControls.CinemaPanel();
            this.showingCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cinemaPanel6 = new Cinema_Booking_Management_System.UserControls.CinemaPanel();
            this.totalRevenueLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cinemaPanel5 = new Cinema_Booking_Management_System.UserControls.CinemaPanel();
            this.todaysBookings = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cinemaPanel1 = new Cinema_Booking_Management_System.UserControls.CinemaPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.formattedDate = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.AMPM = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.greetingLabel = new System.Windows.Forms.Label();
            this.cinemaPanel10 = new Cinema_Booking_Management_System.UserControls.CinemaPanel();
            this.seconds = new System.Windows.Forms.Label();
            this.cinemaPanel9 = new Cinema_Booking_Management_System.UserControls.CinemaPanel();
            this.minutes = new System.Windows.Forms.Label();
            this.cinemaPanel8 = new Cinema_Booking_Management_System.UserControls.CinemaPanel();
            this.hours = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cinemaPanel3.SuspendLayout();
            this.cinemaPanel2.SuspendLayout();
            this.cinemaPanel7.SuspendLayout();
            this.cinemaPanel6.SuspendLayout();
            this.cinemaPanel5.SuspendLayout();
            this.cinemaPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.cinemaPanel10.SuspendLayout();
            this.cinemaPanel9.SuspendLayout();
            this.cinemaPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cinemaPanel3
            // 
            this.cinemaPanel3.BackColor = System.Drawing.Color.Black;
            this.cinemaPanel3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.cinemaPanel3.BorderColor = System.Drawing.Color.Black;
            this.cinemaPanel3.BorderWidth = 1F;
            this.cinemaPanel3.Controls.Add(this.moviesDashboard);
            this.cinemaPanel3.Controls.Add(this.viewAllButton);
            this.cinemaPanel3.Controls.Add(this.label8);
            this.cinemaPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.cinemaPanel3.Location = new System.Drawing.Point(0, 441);
            this.cinemaPanel3.Name = "cinemaPanel3";
            this.cinemaPanel3.paddingBottom = 0;
            this.cinemaPanel3.paddingLeft = 5;
            this.cinemaPanel3.paddingRight = 0;
            this.cinemaPanel3.paddingTop = 0;
            this.cinemaPanel3.Radius = 8;
            this.cinemaPanel3.Size = new System.Drawing.Size(1018, 487);
            this.cinemaPanel3.TabIndex = 3;
            // 
            // moviesDashboard
            // 
            this.moviesDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.moviesDashboard.Location = new System.Drawing.Point(28, 87);
            this.moviesDashboard.Name = "moviesDashboard";
            this.moviesDashboard.Size = new System.Drawing.Size(972, 294);
            this.moviesDashboard.TabIndex = 4;
            // 
            // viewAllButton
            // 
            this.viewAllButton.AutoSize = true;
            this.viewAllButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.viewAllButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewAllButton.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllButton.ForeColor = System.Drawing.Color.White;
            this.viewAllButton.Location = new System.Drawing.Point(887, 38);
            this.viewAllButton.Name = "viewAllButton";
            this.viewAllButton.Size = new System.Drawing.Size(84, 19);
            this.viewAllButton.TabIndex = 3;
            this.viewAllButton.Text = "View All  >";
            this.viewAllButton.Click += new System.EventHandler(this.viewAllButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.label8.Font = new System.Drawing.Font("Helvetica", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(39, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(351, 38);
            this.label8.TabIndex = 2;
            this.label8.Text = "SCHEDULED MOVIES";
            // 
            // cinemaPanel2
            // 
            this.cinemaPanel2.BackColor = System.Drawing.Color.Black;
            this.cinemaPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.cinemaPanel2.BorderColor = System.Drawing.Color.Black;
            this.cinemaPanel2.BorderWidth = 0F;
            this.cinemaPanel2.Controls.Add(this.cinemaPanel7);
            this.cinemaPanel2.Controls.Add(this.label9);
            this.cinemaPanel2.Controls.Add(this.cinemaPanel6);
            this.cinemaPanel2.Controls.Add(this.cinemaPanel5);
            this.cinemaPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.cinemaPanel2.Location = new System.Drawing.Point(0, 160);
            this.cinemaPanel2.Name = "cinemaPanel2";
            this.cinemaPanel2.paddingBottom = 5;
            this.cinemaPanel2.paddingLeft = 5;
            this.cinemaPanel2.paddingRight = 0;
            this.cinemaPanel2.paddingTop = 0;
            this.cinemaPanel2.Radius = 8;
            this.cinemaPanel2.Size = new System.Drawing.Size(1018, 281);
            this.cinemaPanel2.TabIndex = 2;
            // 
            // cinemaPanel7
            // 
            this.cinemaPanel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.cinemaPanel7.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.cinemaPanel7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.cinemaPanel7.BorderWidth = 0F;
            this.cinemaPanel7.Controls.Add(this.showingCount);
            this.cinemaPanel7.Controls.Add(this.label3);
            this.cinemaPanel7.Location = new System.Drawing.Point(362, 90);
            this.cinemaPanel7.Name = "cinemaPanel7";
            this.cinemaPanel7.paddingBottom = 0;
            this.cinemaPanel7.paddingLeft = 0;
            this.cinemaPanel7.paddingRight = 0;
            this.cinemaPanel7.paddingTop = 0;
            this.cinemaPanel7.Radius = 8;
            this.cinemaPanel7.Size = new System.Drawing.Size(289, 147);
            this.cinemaPanel7.TabIndex = 0;
            // 
            // showingCount
            // 
            this.showingCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.showingCount.Font = new System.Drawing.Font("Helvetica", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showingCount.ForeColor = System.Drawing.Color.White;
            this.showingCount.Location = new System.Drawing.Point(0, 61);
            this.showingCount.Name = "showingCount";
            this.showingCount.Size = new System.Drawing.Size(289, 57);
            this.showingCount.TabIndex = 2;
            this.showingCount.Text = "0";
            this.showingCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.label3.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(57, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "No. of Scheduled Movies";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.label9.Font = new System.Drawing.Font("Helvetica", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(39, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 38);
            this.label9.TabIndex = 2;
            this.label9.Text = "OVERVIEW";
            // 
            // cinemaPanel6
            // 
            this.cinemaPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.cinemaPanel6.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.cinemaPanel6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.cinemaPanel6.BorderWidth = 0F;
            this.cinemaPanel6.Controls.Add(this.totalRevenueLabel);
            this.cinemaPanel6.Controls.Add(this.label4);
            this.cinemaPanel6.Location = new System.Drawing.Point(680, 90);
            this.cinemaPanel6.Name = "cinemaPanel6";
            this.cinemaPanel6.paddingBottom = 0;
            this.cinemaPanel6.paddingLeft = 0;
            this.cinemaPanel6.paddingRight = 0;
            this.cinemaPanel6.paddingTop = 0;
            this.cinemaPanel6.Radius = 8;
            this.cinemaPanel6.Size = new System.Drawing.Size(289, 147);
            this.cinemaPanel6.TabIndex = 0;
            // 
            // totalRevenueLabel
            // 
            this.totalRevenueLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.totalRevenueLabel.Font = new System.Drawing.Font("Helvetica", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalRevenueLabel.ForeColor = System.Drawing.Color.White;
            this.totalRevenueLabel.Location = new System.Drawing.Point(0, 63);
            this.totalRevenueLabel.Name = "totalRevenueLabel";
            this.totalRevenueLabel.Size = new System.Drawing.Size(289, 55);
            this.totalRevenueLabel.TabIndex = 2;
            this.totalRevenueLabel.Text = "₱ 10,000.00";
            this.totalRevenueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.label4.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(77, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Today\'s Revenue";
            // 
            // cinemaPanel5
            // 
            this.cinemaPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.cinemaPanel5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.cinemaPanel5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.cinemaPanel5.BorderWidth = 0F;
            this.cinemaPanel5.Controls.Add(this.todaysBookings);
            this.cinemaPanel5.Controls.Add(this.label2);
            this.cinemaPanel5.Location = new System.Drawing.Point(43, 90);
            this.cinemaPanel5.Name = "cinemaPanel5";
            this.cinemaPanel5.paddingBottom = 0;
            this.cinemaPanel5.paddingLeft = 0;
            this.cinemaPanel5.paddingRight = 0;
            this.cinemaPanel5.paddingTop = 0;
            this.cinemaPanel5.Radius = 8;
            this.cinemaPanel5.Size = new System.Drawing.Size(289, 147);
            this.cinemaPanel5.TabIndex = 0;
            // 
            // todaysBookings
            // 
            this.todaysBookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.todaysBookings.Font = new System.Drawing.Font("Helvetica", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todaysBookings.ForeColor = System.Drawing.Color.White;
            this.todaysBookings.Location = new System.Drawing.Point(0, 63);
            this.todaysBookings.Name = "todaysBookings";
            this.todaysBookings.Size = new System.Drawing.Size(289, 57);
            this.todaysBookings.TabIndex = 2;
            this.todaysBookings.Text = "0";
            this.todaysBookings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.label2.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(75, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Today\'s Bookings";
            // 
            // cinemaPanel1
            // 
            this.cinemaPanel1.BackColor = System.Drawing.Color.Black;
            this.cinemaPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.cinemaPanel1.BorderColor = System.Drawing.Color.Black;
            this.cinemaPanel1.BorderWidth = 1F;
            this.cinemaPanel1.Controls.Add(this.panel2);
            this.cinemaPanel1.Controls.Add(this.panel1);
            this.cinemaPanel1.Controls.Add(this.label14);
            this.cinemaPanel1.Controls.Add(this.AMPM);
            this.cinemaPanel1.Controls.Add(this.label11);
            this.cinemaPanel1.Controls.Add(this.greetingLabel);
            this.cinemaPanel1.Controls.Add(this.cinemaPanel10);
            this.cinemaPanel1.Controls.Add(this.cinemaPanel9);
            this.cinemaPanel1.Controls.Add(this.cinemaPanel8);
            this.cinemaPanel1.Controls.Add(this.label1);
            this.cinemaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.cinemaPanel1.Location = new System.Drawing.Point(0, 0);
            this.cinemaPanel1.Name = "cinemaPanel1";
            this.cinemaPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.cinemaPanel1.paddingBottom = 5;
            this.cinemaPanel1.paddingLeft = 5;
            this.cinemaPanel1.paddingRight = 0;
            this.cinemaPanel1.paddingTop = 0;
            this.cinemaPanel1.Radius = 8;
            this.cinemaPanel1.Size = new System.Drawing.Size(1018, 160);
            this.cinemaPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.panel2.BackgroundImage = global::Cinema_Booking_Management_System.Properties.Resources.Male_User;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(43, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(55, 55);
            this.panel2.TabIndex = 6;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.formattedDate);
            this.panel1.Location = new System.Drawing.Point(621, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 31);
            this.panel1.TabIndex = 5;
            // 
            // formattedDate
            // 
            this.formattedDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.formattedDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.formattedDate.Font = new System.Drawing.Font("Helvetica Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formattedDate.ForeColor = System.Drawing.Color.White;
            this.formattedDate.Location = new System.Drawing.Point(36, 0);
            this.formattedDate.Name = "formattedDate";
            this.formattedDate.Size = new System.Drawing.Size(275, 20);
            this.formattedDate.TabIndex = 2;
            this.formattedDate.Text = "AUG 31, 2024 • Wednesday";
            this.formattedDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.label14.Font = new System.Drawing.Font("Helvetica", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(798, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 45);
            this.label14.TabIndex = 0;
            this.label14.Text = ":";
            // 
            // AMPM
            // 
            this.AMPM.AutoSize = true;
            this.AMPM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.AMPM.Font = new System.Drawing.Font("Helvetica", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AMPM.ForeColor = System.Drawing.Color.White;
            this.AMPM.Location = new System.Drawing.Point(908, 53);
            this.AMPM.Name = "AMPM";
            this.AMPM.Size = new System.Drawing.Size(57, 32);
            this.AMPM.TabIndex = 0;
            this.AMPM.Text = "AM";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.label11.Font = new System.Drawing.Font("Helvetica", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(692, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 45);
            this.label11.TabIndex = 0;
            this.label11.Text = ":";
            // 
            // greetingLabel
            // 
            this.greetingLabel.AutoSize = true;
            this.greetingLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.greetingLabel.Font = new System.Drawing.Font("Helvetica", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetingLabel.ForeColor = System.Drawing.Color.White;
            this.greetingLabel.Location = new System.Drawing.Point(104, 61);
            this.greetingLabel.Name = "greetingLabel";
            this.greetingLabel.Size = new System.Drawing.Size(217, 38);
            this.greetingLabel.TabIndex = 2;
            this.greetingLabel.Text = "Hello, Admin!";
            // 
            // cinemaPanel10
            // 
            this.cinemaPanel10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cinemaPanel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.cinemaPanel10.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.cinemaPanel10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.cinemaPanel10.BorderWidth = 0F;
            this.cinemaPanel10.Controls.Add(this.seconds);
            this.cinemaPanel10.Location = new System.Drawing.Point(831, 34);
            this.cinemaPanel10.Name = "cinemaPanel10";
            this.cinemaPanel10.paddingBottom = 0;
            this.cinemaPanel10.paddingLeft = 0;
            this.cinemaPanel10.paddingRight = 0;
            this.cinemaPanel10.paddingTop = 0;
            this.cinemaPanel10.Radius = 8;
            this.cinemaPanel10.Size = new System.Drawing.Size(70, 65);
            this.cinemaPanel10.TabIndex = 4;
            // 
            // seconds
            // 
            this.seconds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.seconds.AutoSize = true;
            this.seconds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.seconds.Font = new System.Drawing.Font("Helvetica", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seconds.ForeColor = System.Drawing.Color.White;
            this.seconds.Location = new System.Drawing.Point(6, 10);
            this.seconds.Name = "seconds";
            this.seconds.Size = new System.Drawing.Size(60, 45);
            this.seconds.TabIndex = 0;
            this.seconds.Text = "00";
            this.seconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cinemaPanel9
            // 
            this.cinemaPanel9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cinemaPanel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.cinemaPanel9.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.cinemaPanel9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.cinemaPanel9.BorderWidth = 0F;
            this.cinemaPanel9.Controls.Add(this.minutes);
            this.cinemaPanel9.Location = new System.Drawing.Point(726, 34);
            this.cinemaPanel9.Name = "cinemaPanel9";
            this.cinemaPanel9.paddingBottom = 0;
            this.cinemaPanel9.paddingLeft = 0;
            this.cinemaPanel9.paddingRight = 0;
            this.cinemaPanel9.paddingTop = 0;
            this.cinemaPanel9.Radius = 8;
            this.cinemaPanel9.Size = new System.Drawing.Size(70, 65);
            this.cinemaPanel9.TabIndex = 4;
            // 
            // minutes
            // 
            this.minutes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.minutes.AutoSize = true;
            this.minutes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.minutes.Font = new System.Drawing.Font("Helvetica", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutes.ForeColor = System.Drawing.Color.White;
            this.minutes.Location = new System.Drawing.Point(6, 10);
            this.minutes.Name = "minutes";
            this.minutes.Size = new System.Drawing.Size(60, 45);
            this.minutes.TabIndex = 0;
            this.minutes.Text = "00";
            this.minutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cinemaPanel8
            // 
            this.cinemaPanel8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cinemaPanel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.cinemaPanel8.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.cinemaPanel8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.cinemaPanel8.BorderWidth = 0F;
            this.cinemaPanel8.Controls.Add(this.hours);
            this.cinemaPanel8.Location = new System.Drawing.Point(621, 34);
            this.cinemaPanel8.Name = "cinemaPanel8";
            this.cinemaPanel8.paddingBottom = 0;
            this.cinemaPanel8.paddingLeft = 0;
            this.cinemaPanel8.paddingRight = 0;
            this.cinemaPanel8.paddingTop = 0;
            this.cinemaPanel8.Radius = 8;
            this.cinemaPanel8.Size = new System.Drawing.Size(70, 65);
            this.cinemaPanel8.TabIndex = 4;
            // 
            // hours
            // 
            this.hours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.hours.AutoSize = true;
            this.hours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.hours.Font = new System.Drawing.Font("Helvetica", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hours.ForeColor = System.Drawing.Color.White;
            this.hours.Location = new System.Drawing.Point(6, 10);
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(60, 45);
            this.hours.TabIndex = 0;
            this.hours.Text = "00";
            this.hours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.label1.Font = new System.Drawing.Font("Helvetica Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 14);
            this.label1.TabIndex = 3;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.cinemaPanel3);
            this.Controls.Add(this.cinemaPanel2);
            this.Controls.Add(this.cinemaPanel1);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(1018, 865);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.cinemaPanel3.ResumeLayout(false);
            this.cinemaPanel3.PerformLayout();
            this.cinemaPanel2.ResumeLayout(false);
            this.cinemaPanel2.PerformLayout();
            this.cinemaPanel7.ResumeLayout(false);
            this.cinemaPanel7.PerformLayout();
            this.cinemaPanel6.ResumeLayout(false);
            this.cinemaPanel6.PerformLayout();
            this.cinemaPanel5.ResumeLayout(false);
            this.cinemaPanel5.PerformLayout();
            this.cinemaPanel1.ResumeLayout(false);
            this.cinemaPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.cinemaPanel10.ResumeLayout(false);
            this.cinemaPanel10.PerformLayout();
            this.cinemaPanel9.ResumeLayout(false);
            this.cinemaPanel9.PerformLayout();
            this.cinemaPanel8.ResumeLayout(false);
            this.cinemaPanel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CinemaPanel cinemaPanel1;
        private CinemaPanel cinemaPanel2;
        private CinemaPanel cinemaPanel3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private CinemaPanel cinemaPanel5;
        private System.Windows.Forms.Label label2;
        private CinemaPanel cinemaPanel7;
        private CinemaPanel cinemaPanel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label showingCount;
        private System.Windows.Forms.Label totalRevenueLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label viewAllButton;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label greetingLabel;
        private CinemaPanel cinemaPanel8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private CinemaPanel cinemaPanel10;
        private System.Windows.Forms.Label seconds;
        private CinemaPanel cinemaPanel9;
        private System.Windows.Forms.Label minutes;
        private System.Windows.Forms.Label hours;
        private System.Windows.Forms.Label AMPM;
        public System.Windows.Forms.Label formattedDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel moviesDashboard;
        private System.Windows.Forms.Label todaysBookings;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panel2;
    }
}
