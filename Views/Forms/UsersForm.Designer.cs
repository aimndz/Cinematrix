namespace Cinema_Booking_Management_System
{
    partial class UsersForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.userSaveButton = new Cinema_Booking_Management_System.UserControls.CinemaButton();
            this.birthDate = new Cinema_Booking_Management_System.UserControls.CinemaDataPicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lastNameTextBox = new Cinema_Booking_Management_System.UserControls.CinemaTextBox();
            this.emailTextBox = new Cinema_Booking_Management_System.UserControls.CinemaTextBox();
            this.confirmPasswordTextBox = new Cinema_Booking_Management_System.UserControls.CinemaTextBox();
            this.passwordTextBox = new Cinema_Booking_Management_System.UserControls.CinemaTextBox();
            this.usernameTextBox = new Cinema_Booking_Management_System.UserControls.CinemaTextBox();
            this.phoneNumberTextBox = new Cinema_Booking_Management_System.UserControls.CinemaTextBox();
            this.addressTextBox = new Cinema_Booking_Management_System.UserControls.CinemaTextBox();
            this.firstNameTextBox = new Cinema_Booking_Management_System.UserControls.CinemaTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.confirmPasswordTextBox);
            this.panel1.Controls.Add(this.userSaveButton);
            this.panel1.Controls.Add(this.birthDate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lastNameTextBox);
            this.panel1.Controls.Add(this.emailTextBox);
            this.panel1.Controls.Add(this.passwordTextBox);
            this.panel1.Controls.Add(this.usernameTextBox);
            this.panel1.Controls.Add(this.phoneNumberTextBox);
            this.panel1.Controls.Add(this.addressTextBox);
            this.panel1.Controls.Add(this.firstNameTextBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Helvetica Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 571);
            this.panel1.TabIndex = 0;
            // 
            // userSaveButton
            // 
            this.userSaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.userSaveButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.userSaveButton.BorderColor = System.Drawing.Color.White;
            this.userSaveButton.BorderRadius = 10;
            this.userSaveButton.BorderSize = 0;
            this.userSaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userSaveButton.FlatAppearance.BorderSize = 0;
            this.userSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userSaveButton.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSaveButton.ForeColor = System.Drawing.Color.Black;
            this.userSaveButton.Location = new System.Drawing.Point(211, 491);
            this.userSaveButton.Name = "userSaveButton";
            this.userSaveButton.Size = new System.Drawing.Size(205, 40);
            this.userSaveButton.TabIndex = 5;
            this.userSaveButton.Text = "Save";
            this.userSaveButton.TextColor = System.Drawing.Color.Black;
            this.userSaveButton.UseVisualStyleBackColor = false;
            this.userSaveButton.Click += new System.EventHandler(this.userSaveButton_Click);
            // 
            // birthDate
            // 
            this.birthDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.birthDate.BorderSize = 1;
            this.birthDate.CustomFormat = "MMMM dd, yyyy";
            this.birthDate.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthDate.Location = new System.Drawing.Point(41, 174);
            this.birthDate.MinimumSize = new System.Drawing.Size(4, 35);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(250, 35);
            this.birthDate.SkinColor = System.Drawing.Color.Black;
            this.birthDate.TabIndex = 4;
            this.birthDate.TextColor = System.Drawing.Color.White;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(335, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(48, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Birth Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(335, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(334, 396);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 15);
            this.label10.TabIndex = 3;
            this.label10.Text = "Confirm Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(47, 396);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(47, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(334, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(47, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "First name";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lastNameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.lastNameTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.lastNameTextBox.BorderRadius = 8;
            this.lastNameTextBox.BorderSize = 1;
            this.lastNameTextBox.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.ForeColor = System.Drawing.Color.White;
            this.lastNameTextBox.Location = new System.Drawing.Point(328, 91);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.lastNameTextBox.Multiline = false;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Padding = new System.Windows.Forms.Padding(10);
            this.lastNameTextBox.PasswordChar = false;
            this.lastNameTextBox.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.lastNameTextBox.PlaceholderText = "Enter your last name";
            this.lastNameTextBox.Size = new System.Drawing.Size(250, 40);
            this.lastNameTextBox.TabIndex = 2;
            this.lastNameTextBox.Texts = "";
            this.lastNameTextBox.UnderlinedStyle = false;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.emailTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.emailTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.emailTextBox.BorderRadius = 8;
            this.emailTextBox.BorderSize = 1;
            this.emailTextBox.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.ForeColor = System.Drawing.Color.White;
            this.emailTextBox.Location = new System.Drawing.Point(328, 333);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTextBox.Multiline = false;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Padding = new System.Windows.Forms.Padding(10);
            this.emailTextBox.PasswordChar = false;
            this.emailTextBox.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.emailTextBox.PlaceholderText = "Enter your email address";
            this.emailTextBox.Size = new System.Drawing.Size(250, 40);
            this.emailTextBox.TabIndex = 2;
            this.emailTextBox.Texts = "";
            this.emailTextBox.UnderlinedStyle = false;
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.confirmPasswordTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.confirmPasswordTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.confirmPasswordTextBox.BorderRadius = 8;
            this.confirmPasswordTextBox.BorderSize = 1;
            this.confirmPasswordTextBox.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordTextBox.ForeColor = System.Drawing.Color.White;
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(328, 415);
            this.confirmPasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.confirmPasswordTextBox.Multiline = false;
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.Padding = new System.Windows.Forms.Padding(10);
            this.confirmPasswordTextBox.PasswordChar = false;
            this.confirmPasswordTextBox.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.confirmPasswordTextBox.PlaceholderText = "Confirm Password";
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(250, 40);
            this.confirmPasswordTextBox.TabIndex = 2;
            this.confirmPasswordTextBox.Texts = "";
            this.confirmPasswordTextBox.UnderlinedStyle = false;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.passwordTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.passwordTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.passwordTextBox.BorderRadius = 8;
            this.passwordTextBox.BorderSize = 1;
            this.passwordTextBox.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.White;
            this.passwordTextBox.Location = new System.Drawing.Point(41, 415);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextBox.Multiline = false;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Padding = new System.Windows.Forms.Padding(10);
            this.passwordTextBox.PasswordChar = false;
            this.passwordTextBox.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.passwordTextBox.PlaceholderText = "Enter your password";
            this.passwordTextBox.Size = new System.Drawing.Size(250, 40);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.Texts = "";
            this.passwordTextBox.UnderlinedStyle = false;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.usernameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.usernameTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.usernameTextBox.BorderRadius = 8;
            this.usernameTextBox.BorderSize = 1;
            this.usernameTextBox.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.ForeColor = System.Drawing.Color.White;
            this.usernameTextBox.Location = new System.Drawing.Point(41, 333);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTextBox.Multiline = false;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Padding = new System.Windows.Forms.Padding(10);
            this.usernameTextBox.PasswordChar = false;
            this.usernameTextBox.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.usernameTextBox.PlaceholderText = "Username";
            this.usernameTextBox.Size = new System.Drawing.Size(250, 40);
            this.usernameTextBox.TabIndex = 2;
            this.usernameTextBox.Texts = "";
            this.usernameTextBox.UnderlinedStyle = false;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.phoneNumberTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.phoneNumberTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.phoneNumberTextBox.BorderRadius = 8;
            this.phoneNumberTextBox.BorderSize = 1;
            this.phoneNumberTextBox.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberTextBox.ForeColor = System.Drawing.Color.White;
            this.phoneNumberTextBox.Location = new System.Drawing.Point(328, 174);
            this.phoneNumberTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.phoneNumberTextBox.Multiline = false;
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Padding = new System.Windows.Forms.Padding(10);
            this.phoneNumberTextBox.PasswordChar = false;
            this.phoneNumberTextBox.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.phoneNumberTextBox.PlaceholderText = "09xxxxxxxx";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(250, 40);
            this.phoneNumberTextBox.TabIndex = 2;
            this.phoneNumberTextBox.Texts = "";
            this.phoneNumberTextBox.UnderlinedStyle = false;
            // 
            // addressTextBox
            // 
            this.addressTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addressTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.addressTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.addressTextBox.BorderRadius = 8;
            this.addressTextBox.BorderSize = 1;
            this.addressTextBox.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.ForeColor = System.Drawing.Color.White;
            this.addressTextBox.Location = new System.Drawing.Point(41, 247);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.addressTextBox.Multiline = false;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Padding = new System.Windows.Forms.Padding(10);
            this.addressTextBox.PasswordChar = false;
            this.addressTextBox.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.addressTextBox.PlaceholderText = "Enter address";
            this.addressTextBox.Size = new System.Drawing.Size(537, 40);
            this.addressTextBox.TabIndex = 2;
            this.addressTextBox.Texts = "";
            this.addressTextBox.UnderlinedStyle = false;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.firstNameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.firstNameTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.firstNameTextBox.BorderRadius = 8;
            this.firstNameTextBox.BorderSize = 1;
            this.firstNameTextBox.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.ForeColor = System.Drawing.Color.White;
            this.firstNameTextBox.Location = new System.Drawing.Point(41, 91);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.firstNameTextBox.Multiline = false;
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Padding = new System.Windows.Forms.Padding(10);
            this.firstNameTextBox.PasswordChar = false;
            this.firstNameTextBox.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.firstNameTextBox.PlaceholderText = "Enter your first name";
            this.firstNameTextBox.Size = new System.Drawing.Size(250, 40);
            this.firstNameTextBox.TabIndex = 2;
            this.firstNameTextBox.Texts = "";
            this.firstNameTextBox.UnderlinedStyle = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.exitButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(622, 36);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Add User Form";
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
            this.exitButton.Location = new System.Drawing.Point(564, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(58, 36);
            this.exitButton.TabIndex = 0;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 571);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsersForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private UserControls.CinemaButton userSaveButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        public UserControls.CinemaTextBox firstNameTextBox;
        public UserControls.CinemaTextBox lastNameTextBox;
        public UserControls.CinemaTextBox addressTextBox;
        public UserControls.CinemaTextBox emailTextBox;
        public UserControls.CinemaTextBox phoneNumberTextBox;
        public UserControls.CinemaDataPicker birthDate;
        public UserControls.CinemaTextBox confirmPasswordTextBox;
        public UserControls.CinemaTextBox passwordTextBox;
        public UserControls.CinemaTextBox usernameTextBox;
    }
}