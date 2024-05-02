namespace Cinema_Booking_Management_System.UserControls
{
    partial class Schedules
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cinemaPanel2 = new Cinema_Booking_Management_System.UserControls.CinemaPanel();
            this.thisWeekButton = new Cinema_Booking_Management_System.UserControls.CinemaButton();
            this.todayButton = new Cinema_Booking_Management_System.UserControls.CinemaButton();
            this.addUsersButton = new Cinema_Booking_Management_System.UserControls.CinemaButton();
            this.schedulesTable = new System.Windows.Forms.DataGridView();
            this.comboBoxMovie = new Cinema_Booking_Management_System.UserControls.CinemaComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cinemaPanel1 = new Cinema_Booking_Management_System.UserControls.CinemaPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cinemaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedulesTable)).BeginInit();
            this.cinemaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cinemaPanel2
            // 
            this.cinemaPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.cinemaPanel2.BorderColor = System.Drawing.Color.Black;
            this.cinemaPanel2.BorderWidth = 1F;
            this.cinemaPanel2.Controls.Add(this.thisWeekButton);
            this.cinemaPanel2.Controls.Add(this.todayButton);
            this.cinemaPanel2.Controls.Add(this.addUsersButton);
            this.cinemaPanel2.Controls.Add(this.schedulesTable);
            this.cinemaPanel2.Controls.Add(this.comboBoxMovie);
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
            // thisWeekButton
            // 
            this.thisWeekButton.BackColor = System.Drawing.Color.Transparent;
            this.thisWeekButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.thisWeekButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.thisWeekButton.BorderRadius = 10;
            this.thisWeekButton.BorderSize = 1;
            this.thisWeekButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.thisWeekButton.FlatAppearance.BorderSize = 0;
            this.thisWeekButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.thisWeekButton.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thisWeekButton.ForeColor = System.Drawing.Color.White;
            this.thisWeekButton.Location = new System.Drawing.Point(177, 50);
            this.thisWeekButton.Name = "thisWeekButton";
            this.thisWeekButton.Size = new System.Drawing.Size(109, 40);
            this.thisWeekButton.TabIndex = 14;
            this.thisWeekButton.Text = "This Week";
            this.thisWeekButton.TextColor = System.Drawing.Color.White;
            this.thisWeekButton.UseVisualStyleBackColor = false;
            this.thisWeekButton.Click += new System.EventHandler(this.thisWeekButton_Click);
            // 
            // todayButton
            // 
            this.todayButton.BackColor = System.Drawing.Color.Transparent;
            this.todayButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.todayButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.todayButton.BorderRadius = 10;
            this.todayButton.BorderSize = 1;
            this.todayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.todayButton.FlatAppearance.BorderSize = 0;
            this.todayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.todayButton.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayButton.ForeColor = System.Drawing.Color.White;
            this.todayButton.Location = new System.Drawing.Point(42, 50);
            this.todayButton.Name = "todayButton";
            this.todayButton.Size = new System.Drawing.Size(109, 40);
            this.todayButton.TabIndex = 14;
            this.todayButton.Text = "Today";
            this.todayButton.TextColor = System.Drawing.Color.White;
            this.todayButton.UseVisualStyleBackColor = false;
            this.todayButton.Click += new System.EventHandler(this.todayButton_Click);
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
            this.addUsersButton.Location = new System.Drawing.Point(806, 605);
            this.addUsersButton.Name = "addUsersButton";
            this.addUsersButton.Size = new System.Drawing.Size(150, 40);
            this.addUsersButton.TabIndex = 13;
            this.addUsersButton.Text = "ADD";
            this.addUsersButton.TextColor = System.Drawing.Color.White;
            this.addUsersButton.UseVisualStyleBackColor = false;
            this.addUsersButton.Click += new System.EventHandler(this.addUsersButton_Click);
            // 
            // schedulesTable
            // 
            this.schedulesTable.AllowUserToAddRows = false;
            this.schedulesTable.AllowUserToDeleteRows = false;
            this.schedulesTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.schedulesTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.schedulesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.schedulesTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.schedulesTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.schedulesTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.schedulesTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 5, 5, 20);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.schedulesTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.schedulesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.schedulesTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.schedulesTable.EnableHeadersVisualStyles = false;
            this.schedulesTable.GridColor = System.Drawing.Color.White;
            this.schedulesTable.Location = new System.Drawing.Point(42, 101);
            this.schedulesTable.Name = "schedulesTable";
            this.schedulesTable.ReadOnly = true;
            this.schedulesTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.schedulesTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.schedulesTable.RowHeadersVisible = false;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            this.schedulesTable.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.schedulesTable.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.schedulesTable.RowTemplate.Height = 35;
            this.schedulesTable.Size = new System.Drawing.Size(914, 470);
            this.schedulesTable.TabIndex = 12;
            this.schedulesTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.schedulesTable_CellClick);
            // 
            // comboBoxMovie
            // 
            this.comboBoxMovie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxMovie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.comboBoxMovie.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.comboBoxMovie.BorderSize = 1;
            this.comboBoxMovie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboBoxMovie.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMovie.ForeColor = System.Drawing.Color.White;
            this.comboBoxMovie.IconColor = System.Drawing.Color.White;
            this.comboBoxMovie.Items.AddRange(new object[] {
            "All Movies",
            "Upcoming",
            "Now showing",
            "Ended"});
            this.comboBoxMovie.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.comboBoxMovie.ListTextColor = System.Drawing.Color.White;
            this.comboBoxMovie.Location = new System.Drawing.Point(694, 50);
            this.comboBoxMovie.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboBoxMovie.Name = "comboBoxMovie";
            this.comboBoxMovie.Padding = new System.Windows.Forms.Padding(1);
            this.comboBoxMovie.Size = new System.Drawing.Size(262, 41);
            this.comboBoxMovie.TabIndex = 10;
            this.comboBoxMovie.Texts = "All Movies";
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
            this.label2.Size = new System.Drawing.Size(216, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "SCHEDULES";
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
            // Schedules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.cinemaPanel2);
            this.Controls.Add(this.cinemaPanel1);
            this.Name = "Schedules";
            this.Size = new System.Drawing.Size(997, 833);
            this.Load += new System.EventHandler(this.Schedules_Load);
            this.cinemaPanel2.ResumeLayout(false);
            this.cinemaPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedulesTable)).EndInit();
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
        private CinemaComboBox comboBoxMovie;
        public System.Windows.Forms.DataGridView schedulesTable;
        private CinemaButton addUsersButton;
        private CinemaButton thisWeekButton;
        private CinemaButton todayButton;
    }
}
