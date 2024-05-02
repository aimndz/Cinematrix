namespace Cinema_Booking_Management_System
{
    partial class MoviesForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearButton = new Cinema_Booking_Management_System.UserControls.CinemaButton();
            this.saveButton = new Cinema_Booking_Management_System.UserControls.CinemaButton();
            this.posterPictureBox = new System.Windows.Forms.PictureBox();
            this.statusComboBox = new Cinema_Booking_Management_System.UserControls.CinemaComboBox();
            this.ratingComboBox = new Cinema_Booking_Management_System.UserControls.CinemaComboBox();
            this.releaseDate = new Cinema_Booking_Management_System.UserControls.CinemaDataPicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rating = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ticketPriceTextBox = new Cinema_Booking_Management_System.UserControls.CinemaTextBox();
            this.durationTextBox = new Cinema_Booking_Management_System.UserControls.CinemaTextBox();
            this.directorsTextBox = new Cinema_Booking_Management_System.UserControls.CinemaTextBox();
            this.descriptionTextBox = new Cinema_Booking_Management_System.UserControls.CinemaTextBox();
            this.castTextBox = new Cinema_Booking_Management_System.UserControls.CinemaTextBox();
            this.genreTextBox = new Cinema_Booking_Management_System.UserControls.CinemaTextBox();
            this.movieTitleTextBox = new Cinema_Booking_Management_System.UserControls.CinemaTextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posterPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.exitButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(845, 36);
            this.panel2.TabIndex = 2;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Add Movie Form";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Image = global::Cinema_Booking_Management_System.Properties.Resources.Exit;
            this.exitButton.Location = new System.Drawing.Point(787, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(58, 36);
            this.exitButton.TabIndex = 0;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.posterPictureBox);
            this.panel1.Controls.Add(this.statusComboBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ratingComboBox);
            this.panel1.Controls.Add(this.releaseDate);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.rating);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ticketPriceTextBox);
            this.panel1.Controls.Add(this.durationTextBox);
            this.panel1.Controls.Add(this.directorsTextBox);
            this.panel1.Controls.Add(this.descriptionTextBox);
            this.panel1.Controls.Add(this.castTextBox);
            this.panel1.Controls.Add(this.genreTextBox);
            this.panel1.Controls.Add(this.movieTitleTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 696);
            this.panel1.TabIndex = 3;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Transparent;
            this.clearButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.clearButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.clearButton.BorderRadius = 10;
            this.clearButton.BorderSize = 1;
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(603, 444);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(200, 40);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear";
            this.clearButton.TextColor = System.Drawing.Color.White;
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.saveButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.saveButton.BorderColor = System.Drawing.Color.White;
            this.saveButton.BorderRadius = 10;
            this.saveButton.BorderSize = 0;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.Black;
            this.saveButton.Location = new System.Drawing.Point(603, 398);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(200, 40);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.TextColor = System.Drawing.Color.Black;
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // posterPictureBox
            // 
            this.posterPictureBox.BackColor = System.Drawing.Color.Black;
            this.posterPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.posterPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.posterPictureBox.Location = new System.Drawing.Point(603, 96);
            this.posterPictureBox.Name = "posterPictureBox";
            this.posterPictureBox.Size = new System.Drawing.Size(200, 275);
            this.posterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.posterPictureBox.TabIndex = 8;
            this.posterPictureBox.TabStop = false;
            this.posterPictureBox.Click += new System.EventHandler(this.posterPictureBox_Click);
            this.posterPictureBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.posterPictureBox_DragDrop);
            this.posterPictureBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.posterPictureBox_DragEnter);
            // 
            // statusComboBox
            // 
            this.statusComboBox.BackColor = System.Drawing.Color.Black;
            this.statusComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.statusComboBox.BorderSize = 1;
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.statusComboBox.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusComboBox.ForeColor = System.Drawing.Color.White;
            this.statusComboBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.statusComboBox.Items.AddRange(new object[] {
            "Upcoming",
            "Now showing",
            "Ended"});
            this.statusComboBox.ListBackColor = System.Drawing.Color.Black;
            this.statusComboBox.ListTextColor = System.Drawing.Color.White;
            this.statusComboBox.Location = new System.Drawing.Point(317, 345);
            this.statusComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Padding = new System.Windows.Forms.Padding(1);
            this.statusComboBox.Size = new System.Drawing.Size(250, 40);
            this.statusComboBox.TabIndex = 7;
            this.statusComboBox.Texts = "Select status";
            // 
            // ratingComboBox
            // 
            this.ratingComboBox.BackColor = System.Drawing.Color.Black;
            this.ratingComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ratingComboBox.BorderSize = 1;
            this.ratingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.ratingComboBox.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingComboBox.ForeColor = System.Drawing.Color.White;
            this.ratingComboBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ratingComboBox.Items.AddRange(new object[] {
            "G",
            "PG",
            "R-13",
            "R-16"});
            this.ratingComboBox.ListBackColor = System.Drawing.Color.Black;
            this.ratingComboBox.ListTextColor = System.Drawing.Color.White;
            this.ratingComboBox.Location = new System.Drawing.Point(36, 257);
            this.ratingComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.ratingComboBox.Name = "ratingComboBox";
            this.ratingComboBox.Padding = new System.Windows.Forms.Padding(1);
            this.ratingComboBox.Size = new System.Drawing.Size(250, 40);
            this.ratingComboBox.TabIndex = 7;
            this.ratingComboBox.Texts = "Select Rating";
            // 
            // releaseDate
            // 
            this.releaseDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.releaseDate.BorderSize = 1;
            this.releaseDate.CustomFormat = "MMMM dd, yyyy";
            this.releaseDate.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.releaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.releaseDate.Location = new System.Drawing.Point(317, 96);
            this.releaseDate.MinimumSize = new System.Drawing.Size(4, 35);
            this.releaseDate.Name = "releaseDate";
            this.releaseDate.Size = new System.Drawing.Size(250, 35);
            this.releaseDate.SkinColor = System.Drawing.Color.Black;
            this.releaseDate.TabIndex = 6;
            this.releaseDate.TextColor = System.Drawing.Color.White;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(600, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 15);
            this.label11.TabIndex = 5;
            this.label11.Text = "Poster";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(323, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Release Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(323, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Duration (min)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(42, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ticket Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(323, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(323, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Director/s";
            // 
            // rating
            // 
            this.rating.AutoSize = true;
            this.rating.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rating.ForeColor = System.Drawing.Color.White;
            this.rating.Location = new System.Drawing.Point(42, 239);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(44, 15);
            this.rating.TabIndex = 5;
            this.rating.Text = "Rating";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(42, 516);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 15);
            this.label10.TabIndex = 5;
            this.label10.Text = "Synopsis / Description";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(42, 411);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "Cast";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(42, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Genre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Movie Title";
            // 
            // ticketPriceTextBox
            // 
            this.ticketPriceTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ticketPriceTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ticketPriceTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.ticketPriceTextBox.BorderRadius = 8;
            this.ticketPriceTextBox.BorderSize = 1;
            this.ticketPriceTextBox.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketPriceTextBox.ForeColor = System.Drawing.Color.White;
            this.ticketPriceTextBox.Location = new System.Drawing.Point(36, 345);
            this.ticketPriceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ticketPriceTextBox.Multiline = false;
            this.ticketPriceTextBox.Name = "ticketPriceTextBox";
            this.ticketPriceTextBox.Padding = new System.Windows.Forms.Padding(10);
            this.ticketPriceTextBox.PasswordChar = false;
            this.ticketPriceTextBox.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ticketPriceTextBox.PlaceholderText = "Enter ticket price";
            this.ticketPriceTextBox.Size = new System.Drawing.Size(250, 40);
            this.ticketPriceTextBox.TabIndex = 4;
            this.ticketPriceTextBox.Texts = "";
            this.ticketPriceTextBox.UnderlinedStyle = false;
            // 
            // durationTextBox
            // 
            this.durationTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.durationTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.durationTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.durationTextBox.BorderRadius = 8;
            this.durationTextBox.BorderSize = 1;
            this.durationTextBox.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationTextBox.ForeColor = System.Drawing.Color.White;
            this.durationTextBox.Location = new System.Drawing.Point(317, 257);
            this.durationTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.durationTextBox.Multiline = false;
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Padding = new System.Windows.Forms.Padding(10);
            this.durationTextBox.PasswordChar = false;
            this.durationTextBox.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.durationTextBox.PlaceholderText = "Enter duration";
            this.durationTextBox.Size = new System.Drawing.Size(250, 40);
            this.durationTextBox.TabIndex = 4;
            this.durationTextBox.Texts = "";
            this.durationTextBox.UnderlinedStyle = false;
            // 
            // directorsTextBox
            // 
            this.directorsTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.directorsTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.directorsTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.directorsTextBox.BorderRadius = 8;
            this.directorsTextBox.BorderSize = 1;
            this.directorsTextBox.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directorsTextBox.ForeColor = System.Drawing.Color.White;
            this.directorsTextBox.Location = new System.Drawing.Point(317, 174);
            this.directorsTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.directorsTextBox.Multiline = false;
            this.directorsTextBox.Name = "directorsTextBox";
            this.directorsTextBox.Padding = new System.Windows.Forms.Padding(10);
            this.directorsTextBox.PasswordChar = false;
            this.directorsTextBox.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.directorsTextBox.PlaceholderText = "Enter directors";
            this.directorsTextBox.Size = new System.Drawing.Size(250, 40);
            this.directorsTextBox.TabIndex = 4;
            this.directorsTextBox.Texts = "";
            this.directorsTextBox.UnderlinedStyle = false;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.descriptionTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.descriptionTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.descriptionTextBox.BorderRadius = 8;
            this.descriptionTextBox.BorderSize = 1;
            this.descriptionTextBox.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.ForeColor = System.Drawing.Color.White;
            this.descriptionTextBox.Location = new System.Drawing.Point(36, 535);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Padding = new System.Windows.Forms.Padding(10);
            this.descriptionTextBox.PasswordChar = false;
            this.descriptionTextBox.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.descriptionTextBox.PlaceholderText = "Enter the synopsis";
            this.descriptionTextBox.Size = new System.Drawing.Size(531, 119);
            this.descriptionTextBox.TabIndex = 4;
            this.descriptionTextBox.Texts = "";
            this.descriptionTextBox.UnderlinedStyle = false;
            // 
            // castTextBox
            // 
            this.castTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.castTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.castTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.castTextBox.BorderRadius = 8;
            this.castTextBox.BorderSize = 1;
            this.castTextBox.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.castTextBox.ForeColor = System.Drawing.Color.White;
            this.castTextBox.Location = new System.Drawing.Point(36, 430);
            this.castTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.castTextBox.Multiline = true;
            this.castTextBox.Name = "castTextBox";
            this.castTextBox.Padding = new System.Windows.Forms.Padding(10);
            this.castTextBox.PasswordChar = false;
            this.castTextBox.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.castTextBox.PlaceholderText = "Enter the cast";
            this.castTextBox.Size = new System.Drawing.Size(531, 61);
            this.castTextBox.TabIndex = 4;
            this.castTextBox.Texts = "";
            this.castTextBox.UnderlinedStyle = false;
            // 
            // genreTextBox
            // 
            this.genreTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.genreTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.genreTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.genreTextBox.BorderRadius = 8;
            this.genreTextBox.BorderSize = 1;
            this.genreTextBox.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreTextBox.ForeColor = System.Drawing.Color.White;
            this.genreTextBox.Location = new System.Drawing.Point(36, 174);
            this.genreTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.genreTextBox.Multiline = false;
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Padding = new System.Windows.Forms.Padding(10);
            this.genreTextBox.PasswordChar = false;
            this.genreTextBox.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.genreTextBox.PlaceholderText = "Enter genre";
            this.genreTextBox.Size = new System.Drawing.Size(250, 40);
            this.genreTextBox.TabIndex = 4;
            this.genreTextBox.Texts = "";
            this.genreTextBox.UnderlinedStyle = false;
            // 
            // movieTitleTextBox
            // 
            this.movieTitleTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.movieTitleTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.movieTitleTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.movieTitleTextBox.BorderRadius = 8;
            this.movieTitleTextBox.BorderSize = 1;
            this.movieTitleTextBox.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieTitleTextBox.ForeColor = System.Drawing.Color.White;
            this.movieTitleTextBox.Location = new System.Drawing.Point(36, 94);
            this.movieTitleTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.movieTitleTextBox.Multiline = false;
            this.movieTitleTextBox.Name = "movieTitleTextBox";
            this.movieTitleTextBox.Padding = new System.Windows.Forms.Padding(10);
            this.movieTitleTextBox.PasswordChar = false;
            this.movieTitleTextBox.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.movieTitleTextBox.PlaceholderText = "Enter movie title";
            this.movieTitleTextBox.Size = new System.Drawing.Size(250, 40);
            this.movieTitleTextBox.TabIndex = 4;
            this.movieTitleTextBox.Texts = "";
            this.movieTitleTextBox.UnderlinedStyle = false;
            // 
            // MoviesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 696);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MoviesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoviesForm";
            this.Load += new System.EventHandler(this.MoviesForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posterPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        public UserControls.CinemaTextBox genreTextBox;
        public UserControls.CinemaTextBox movieTitleTextBox;
        private System.Windows.Forms.Label label5;
        public UserControls.CinemaTextBox directorsTextBox;
        public UserControls.CinemaDataPicker releaseDate;
        private System.Windows.Forms.Label rating;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public UserControls.CinemaTextBox ticketPriceTextBox;
        public UserControls.CinemaTextBox durationTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        public UserControls.CinemaTextBox descriptionTextBox;
        public UserControls.CinemaTextBox castTextBox;
        private System.Windows.Forms.Label label11;
        private UserControls.CinemaButton saveButton;
        private UserControls.CinemaButton clearButton;
        public UserControls.CinemaComboBox ratingComboBox;
        public UserControls.CinemaComboBox statusComboBox;
        public System.Windows.Forms.PictureBox posterPictureBox;
    }
}