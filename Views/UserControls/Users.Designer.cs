namespace Cinema_Booking_Management_System.UserControls
{
    partial class Users
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
            this.emp = new Cinema_Booking_Management_System.UserControls.CinemaPanel();
            this.addUsersButton = new Cinema_Booking_Management_System.UserControls.CinemaButton();
            this.usersTable = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cinemaPanel1 = new Cinema_Booking_Management_System.UserControls.CinemaPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.emp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersTable)).BeginInit();
            this.cinemaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // emp
            // 
            this.emp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.emp.BorderColor = System.Drawing.Color.Black;
            this.emp.BorderWidth = 1F;
            this.emp.Controls.Add(this.addUsersButton);
            this.emp.Controls.Add(this.usersTable);
            this.emp.Controls.Add(this.label4);
            this.emp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emp.Location = new System.Drawing.Point(0, 160);
            this.emp.Name = "emp";
            this.emp.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.emp.paddingBottom = 5;
            this.emp.paddingLeft = 5;
            this.emp.paddingRight = 0;
            this.emp.paddingTop = 0;
            this.emp.Radius = 8;
            this.emp.Size = new System.Drawing.Size(997, 673);
            this.emp.TabIndex = 3;
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
            this.addUsersButton.Location = new System.Drawing.Point(809, 596);
            this.addUsersButton.Name = "addUsersButton";
            this.addUsersButton.Size = new System.Drawing.Size(150, 40);
            this.addUsersButton.TabIndex = 4;
            this.addUsersButton.Text = "ADD";
            this.addUsersButton.TextColor = System.Drawing.Color.White;
            this.addUsersButton.UseVisualStyleBackColor = false;
            this.addUsersButton.Click += new System.EventHandler(this.addUsersButton_Click);
            this.addUsersButton.MouseEnter += new System.EventHandler(this.addUsersButton_MouseEnter);
            this.addUsersButton.MouseLeave += new System.EventHandler(this.addUsersButton_MouseLeave);
            // 
            // usersTable
            // 
            this.usersTable.AllowUserToAddRows = false;
            this.usersTable.AllowUserToDeleteRows = false;
            this.usersTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.usersTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.usersTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.usersTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usersTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.usersTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 5, 5, 20);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.usersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.usersTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.usersTable.EnableHeadersVisualStyles = false;
            this.usersTable.GridColor = System.Drawing.Color.White;
            this.usersTable.Location = new System.Drawing.Point(44, 67);
            this.usersTable.Name = "usersTable";
            this.usersTable.ReadOnly = true;
            this.usersTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.usersTable.RowHeadersVisible = false;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            this.usersTable.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.usersTable.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.usersTable.RowTemplate.Height = 35;
            this.usersTable.Size = new System.Drawing.Size(915, 512);
            this.usersTable.TabIndex = 0;
            this.usersTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersTable_CellClick);
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
            this.cinemaPanel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Helvetica", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(55, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "USERS / ADMIN";
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
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.emp);
            this.Controls.Add(this.cinemaPanel1);
            this.Name = "Users";
            this.Size = new System.Drawing.Size(997, 833);
            this.Load += new System.EventHandler(this.Users_Load);
            this.emp.ResumeLayout(false);
            this.emp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersTable)).EndInit();
            this.cinemaPanel1.ResumeLayout(false);
            this.cinemaPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CinemaPanel cinemaPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private CinemaPanel emp;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private CinemaButton addUsersButton;
        public System.Windows.Forms.DataGridView usersTable;
    }
}
