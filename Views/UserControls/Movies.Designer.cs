namespace Cinema_Booking_Management_System.UserControls
{
    partial class Movies
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cinemaPanel2 = new Cinema_Booking_Management_System.UserControls.CinemaPanel();
            this.ratingComboBox = new Cinema_Booking_Management_System.UserControls.CinemaComboBox();
            this.comboBoxStatus = new Cinema_Booking_Management_System.UserControls.CinemaComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchTextBox = new Cinema_Booking_Management_System.UserControls.CinemaTextBox();
            this.addUsersButton = new Cinema_Booking_Management_System.UserControls.CinemaButton();
            this.moviesTable = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cinemaPanel1 = new Cinema_Booking_Management_System.UserControls.CinemaPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cinemaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviesTable)).BeginInit();
            this.cinemaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cinemaPanel2
            // 
            this.cinemaPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.cinemaPanel2.BorderColor = System.Drawing.Color.Black;
            this.cinemaPanel2.BorderWidth = 1F;
            this.cinemaPanel2.Controls.Add(this.ratingComboBox);
            this.cinemaPanel2.Controls.Add(this.comboBoxStatus);
            this.cinemaPanel2.Controls.Add(this.panel1);
            this.cinemaPanel2.Controls.Add(this.searchTextBox);
            this.cinemaPanel2.Controls.Add(this.addUsersButton);
            this.cinemaPanel2.Controls.Add(this.moviesTable);
            this.cinemaPanel2.Controls.Add(this.label4);
            this.cinemaPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cinemaPanel2.Location = new System.Drawing.Point(0, 160);
            this.cinemaPanel2.Name = "cinemaPanel2";
            this.cinemaPanel2.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.cinemaPanel2.paddingBottom = 5;
            this.cinemaPanel2.paddingLeft = 5;
            this.cinemaPanel2.paddingRight = 0;
            this.cinemaPanel2.paddingTop = 0;
            this.cinemaPanel2.Radius = 8;
            this.cinemaPanel2.Size = new System.Drawing.Size(997, 673);
            this.cinemaPanel2.TabIndex = 5;
            // 
            // ratingComboBox
            // 
            this.ratingComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.ratingComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ratingComboBox.BorderSize = 1;
            this.ratingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.ratingComboBox.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingComboBox.ForeColor = System.Drawing.Color.White;
            this.ratingComboBox.IconColor = System.Drawing.Color.White;
            this.ratingComboBox.Items.AddRange(new object[] {
            "All Rating",
            "G",
            "PG",
            "R-13",
            "R-16"});
            this.ratingComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.ratingComboBox.ListTextColor = System.Drawing.Color.White;
            this.ratingComboBox.Location = new System.Drawing.Point(259, 45);
            this.ratingComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.ratingComboBox.Name = "ratingComboBox";
            this.ratingComboBox.Padding = new System.Windows.Forms.Padding(1);
            this.ratingComboBox.Size = new System.Drawing.Size(200, 41);
            this.ratingComboBox.TabIndex = 10;
            this.ratingComboBox.Texts = "All Rating";
            this.ratingComboBox.OnSelectedIndexChanged += new System.EventHandler(this.ratingComboBox_OnSelectedIndexChanged);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.comboBoxStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.comboBoxStatus.BorderSize = 1;
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboBoxStatus.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStatus.ForeColor = System.Drawing.Color.White;
            this.comboBoxStatus.IconColor = System.Drawing.Color.White;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "All Movies",
            "Upcoming",
            "Now showing",
            "Ended"});
            this.comboBoxStatus.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.comboBoxStatus.ListTextColor = System.Drawing.Color.White;
            this.comboBoxStatus.Location = new System.Drawing.Point(44, 45);
            this.comboBoxStatus.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Padding = new System.Windows.Forms.Padding(1);
            this.comboBoxStatus.Size = new System.Drawing.Size(200, 41);
            this.comboBoxStatus.TabIndex = 9;
            this.comboBoxStatus.Texts = "All Movies";
            this.comboBoxStatus.OnSelectedIndexChanged += new System.EventHandler(this.comboBoxStatus_OnSelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.panel1.BackgroundImage = global::Cinema_Booking_Management_System.Properties.Resources.search;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(923, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 30);
            this.panel1.TabIndex = 7;
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.searchTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.searchTextBox.BorderFocusColor = System.Drawing.Color.White;
            this.searchTextBox.BorderRadius = 5;
            this.searchTextBox.BorderSize = 1;
            this.searchTextBox.Font = new System.Drawing.Font("Helvetica Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.ForeColor = System.Drawing.Color.White;
            this.searchTextBox.Location = new System.Drawing.Point(659, 45);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchTextBox.Multiline = false;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Padding = new System.Windows.Forms.Padding(10, 10, 30, 10);
            this.searchTextBox.PasswordChar = false;
            this.searchTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.searchTextBox.PlaceholderText = "Search movie title...";
            this.searchTextBox.Size = new System.Drawing.Size(297, 41);
            this.searchTextBox.TabIndex = 6;
            this.searchTextBox.Texts = "";
            this.searchTextBox.UnderlinedStyle = false;
            this.searchTextBox._TextChanged += new System.EventHandler(this.searchTextBox__TextChanged);
            // 
            // addUsersButton
            // 
            this.addUsersButton.BackColor = System.Drawing.Color.Transparent;
            this.addUsersButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.addUsersButton.BorderColor = System.Drawing.Color.White;
            this.addUsersButton.BorderRadius = 10;
            this.addUsersButton.BorderSize = 1;
            this.addUsersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addUsersButton.FlatAppearance.BorderSize = 0;
            this.addUsersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUsersButton.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUsersButton.ForeColor = System.Drawing.Color.White;
            this.addUsersButton.Location = new System.Drawing.Point(806, 615);
            this.addUsersButton.Name = "addUsersButton";
            this.addUsersButton.Size = new System.Drawing.Size(150, 40);
            this.addUsersButton.TabIndex = 5;
            this.addUsersButton.Text = "ADD";
            this.addUsersButton.TextColor = System.Drawing.Color.White;
            this.addUsersButton.UseVisualStyleBackColor = false;
            this.addUsersButton.Click += new System.EventHandler(this.addUsersButton_Click);
            // 
            // moviesTable
            // 
            this.moviesTable.AllowUserToAddRows = false;
            this.moviesTable.AllowUserToDeleteRows = false;
            this.moviesTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.moviesTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.moviesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.moviesTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.moviesTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.moviesTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.moviesTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5, 5, 5, 20);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.moviesTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.moviesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.moviesTable.DefaultCellStyle = dataGridViewCellStyle8;
            this.moviesTable.EnableHeadersVisualStyles = false;
            this.moviesTable.GridColor = System.Drawing.Color.White;
            this.moviesTable.Location = new System.Drawing.Point(41, 108);
            this.moviesTable.Name = "moviesTable";
            this.moviesTable.ReadOnly = true;
            this.moviesTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.moviesTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.moviesTable.RowHeadersVisible = false;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(5);
            this.moviesTable.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.moviesTable.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.moviesTable.RowTemplate.Height = 35;
            this.moviesTable.Size = new System.Drawing.Size(915, 470);
            this.moviesTable.TabIndex = 4;
            this.moviesTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.moviesTable_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.label4.Font = new System.Drawing.Font("Helvetica Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(59, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 14);
            this.label4.TabIndex = 3;
            // 
            // cinemaPanel1
            // 
            this.cinemaPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.cinemaPanel1.BorderColor = System.Drawing.Color.Black;
            this.cinemaPanel1.BorderWidth = 1F;
            this.cinemaPanel1.Controls.Add(this.label2);
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
            this.cinemaPanel1.Size = new System.Drawing.Size(997, 160);
            this.cinemaPanel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Helvetica", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(55, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "MOVIES";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // Movies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.cinemaPanel2);
            this.Controls.Add(this.cinemaPanel1);
            this.Name = "Movies";
            this.Size = new System.Drawing.Size(997, 833);
            this.Load += new System.EventHandler(this.Movies_Load);
            this.cinemaPanel2.ResumeLayout(false);
            this.cinemaPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviesTable)).EndInit();
            this.cinemaPanel1.ResumeLayout(false);
            this.cinemaPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CinemaPanel cinemaPanel2;
        private System.Windows.Forms.Label label4;
        private CinemaPanel cinemaPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView moviesTable;
        private CinemaButton addUsersButton;
        private CinemaTextBox searchTextBox;
        private System.Windows.Forms.Panel panel1;
        private CinemaComboBox comboBoxStatus;
        private CinemaComboBox ratingComboBox;
    }
}
