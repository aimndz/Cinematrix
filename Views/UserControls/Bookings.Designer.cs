namespace Cinema_Booking_Management_System.UserControls
{
    partial class Bookings
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
            this.bookingsTable = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cinemaPanel1 = new Cinema_Booking_Management_System.UserControls.CinemaPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cinemaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsTable)).BeginInit();
            this.cinemaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cinemaPanel2
            // 
            this.cinemaPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.cinemaPanel2.BorderColor = System.Drawing.Color.Black;
            this.cinemaPanel2.BorderWidth = 1F;
            this.cinemaPanel2.Controls.Add(this.bookingsTable);
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
            // bookingsTable
            // 
            this.bookingsTable.AllowUserToAddRows = false;
            this.bookingsTable.AllowUserToDeleteRows = false;
            this.bookingsTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.bookingsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bookingsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookingsTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.bookingsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookingsTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.bookingsTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 5, 5, 20);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookingsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bookingsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bookingsTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.bookingsTable.EnableHeadersVisualStyles = false;
            this.bookingsTable.GridColor = System.Drawing.Color.White;
            this.bookingsTable.Location = new System.Drawing.Point(41, 64);
            this.bookingsTable.Name = "bookingsTable";
            this.bookingsTable.ReadOnly = true;
            this.bookingsTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookingsTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.bookingsTable.RowHeadersVisible = false;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            this.bookingsTable.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.bookingsTable.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.bookingsTable.RowTemplate.Height = 35;
            this.bookingsTable.Size = new System.Drawing.Size(915, 544);
            this.bookingsTable.TabIndex = 4;
            this.bookingsTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookingsTable_CellClick);
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
            this.label2.Size = new System.Drawing.Size(191, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "BOOKINGS";
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
            // Bookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.cinemaPanel2);
            this.Controls.Add(this.cinemaPanel1);
            this.Name = "Bookings";
            this.Size = new System.Drawing.Size(997, 833);
            this.Load += new System.EventHandler(this.Bookings_Load);
            this.cinemaPanel2.ResumeLayout(false);
            this.cinemaPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsTable)).EndInit();
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
        public System.Windows.Forms.DataGridView bookingsTable;
    }
}
