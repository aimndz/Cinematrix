namespace Cinema_Booking_Management_System.Views.Forms
{
    partial class SchedulesFormEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchedulesFormEdit));
            this.panel1 = new System.Windows.Forms.Panel();
            this.showingDate = new Cinema_Booking_Management_System.UserControls.CinemaDataPicker();
            this.comboBoxCinema = new Cinema_Booking_Management_System.UserControls.CinemaComboBox();
            this.comboBoxMovie = new Cinema_Booking_Management_System.UserControls.CinemaComboBox();
            this.userEditButton = new Cinema_Booking_Management_System.UserControls.CinemaButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.schedulesStartTime = new Cinema_Booking_Management_System.UserControls.CinemaTextBox();
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
            this.panel1.Controls.Add(this.showingDate);
            this.panel1.Controls.Add(this.comboBoxCinema);
            this.panel1.Controls.Add(this.comboBoxMovie);
            this.panel1.Controls.Add(this.userEditButton);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.schedulesStartTime);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Helvetica Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 355);
            this.panel1.TabIndex = 3;
            // 
            // showingDate
            // 
            this.showingDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.showingDate.BorderSize = 1;
            this.showingDate.CustomFormat = "MMMM dd, yyyy";
            this.showingDate.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.showingDate.Location = new System.Drawing.Point(41, 186);
            this.showingDate.MinimumSize = new System.Drawing.Size(4, 35);
            this.showingDate.Name = "showingDate";
            this.showingDate.Size = new System.Drawing.Size(250, 35);
            this.showingDate.SkinColor = System.Drawing.Color.Black;
            this.showingDate.TabIndex = 12;
            this.showingDate.TextColor = System.Drawing.Color.White;
            // 
            // comboBoxCinema
            // 
            this.comboBoxCinema.BackColor = System.Drawing.Color.Black;
            this.comboBoxCinema.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.comboBoxCinema.BorderSize = 1;
            this.comboBoxCinema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboBoxCinema.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCinema.ForeColor = System.Drawing.Color.White;
            this.comboBoxCinema.IconColor = System.Drawing.Color.White;
            this.comboBoxCinema.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxCinema.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.comboBoxCinema.ListTextColor = System.Drawing.Color.White;
            this.comboBoxCinema.Location = new System.Drawing.Point(327, 102);
            this.comboBoxCinema.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboBoxCinema.Name = "comboBoxCinema";
            this.comboBoxCinema.Padding = new System.Windows.Forms.Padding(1);
            this.comboBoxCinema.Size = new System.Drawing.Size(250, 41);
            this.comboBoxCinema.TabIndex = 11;
            this.comboBoxCinema.Texts = "Select Cinema";
            // 
            // comboBoxMovie
            // 
            this.comboBoxMovie.BackColor = System.Drawing.Color.Black;
            this.comboBoxMovie.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.comboBoxMovie.BorderSize = 1;
            this.comboBoxMovie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboBoxMovie.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMovie.ForeColor = System.Drawing.Color.White;
            this.comboBoxMovie.IconColor = System.Drawing.Color.White;
            this.comboBoxMovie.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.comboBoxMovie.ListTextColor = System.Drawing.Color.White;
            this.comboBoxMovie.Location = new System.Drawing.Point(41, 102);
            this.comboBoxMovie.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboBoxMovie.Name = "comboBoxMovie";
            this.comboBoxMovie.Padding = new System.Windows.Forms.Padding(1);
            this.comboBoxMovie.Size = new System.Drawing.Size(250, 41);
            this.comboBoxMovie.TabIndex = 11;
            this.comboBoxMovie.Texts = "Select Movie";
            // 
            // userEditButton
            // 
            this.userEditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.userEditButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.userEditButton.BorderColor = System.Drawing.Color.White;
            this.userEditButton.BorderRadius = 10;
            this.userEditButton.BorderSize = 0;
            this.userEditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userEditButton.FlatAppearance.BorderSize = 0;
            this.userEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userEditButton.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userEditButton.ForeColor = System.Drawing.Color.Black;
            this.userEditButton.Location = new System.Drawing.Point(180, 265);
            this.userEditButton.Name = "userEditButton";
            this.userEditButton.Size = new System.Drawing.Size(250, 40);
            this.userEditButton.TabIndex = 5;
            this.userEditButton.Text = "Save";
            this.userEditButton.TextColor = System.Drawing.Color.Black;
            this.userEditButton.UseVisualStyleBackColor = false;
            this.userEditButton.Click += new System.EventHandler(this.userEditButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(333, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cinema";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(333, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(47, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Showing Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Movie Title";
            // 
            // schedulesStartTime
            // 
            this.schedulesStartTime.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.schedulesStartTime.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.schedulesStartTime.BorderFocusColor = System.Drawing.Color.HotPink;
            this.schedulesStartTime.BorderRadius = 8;
            this.schedulesStartTime.BorderSize = 1;
            this.schedulesStartTime.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedulesStartTime.ForeColor = System.Drawing.Color.White;
            this.schedulesStartTime.Location = new System.Drawing.Point(327, 186);
            this.schedulesStartTime.Margin = new System.Windows.Forms.Padding(4);
            this.schedulesStartTime.Multiline = false;
            this.schedulesStartTime.Name = "schedulesStartTime";
            this.schedulesStartTime.Padding = new System.Windows.Forms.Padding(10);
            this.schedulesStartTime.PasswordChar = false;
            this.schedulesStartTime.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.schedulesStartTime.PlaceholderText = "";
            this.schedulesStartTime.Size = new System.Drawing.Size(250, 40);
            this.schedulesStartTime.TabIndex = 2;
            this.schedulesStartTime.Texts = "";
            this.schedulesStartTime.UnderlinedStyle = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.exitButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(623, 36);
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
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Edit Schedule";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label3_MouseDown);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(565, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(58, 36);
            this.exitButton.TabIndex = 0;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // SchedulesFormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 355);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SchedulesFormEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SchedulesFormEdit";
            this.Load += new System.EventHandler(this.SchedulesFormEdit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public UserControls.CinemaDataPicker showingDate;
        public UserControls.CinemaComboBox comboBoxMovie;
        private UserControls.CinemaButton userEditButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exitButton;
        public UserControls.CinemaTextBox schedulesStartTime;
        public UserControls.CinemaComboBox comboBoxCinema;
    }
}