namespace Cinema_Booking_Management_System
{
    partial class CancelBoookingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CancelBoookingForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cinemaPanel1 = new Cinema_Booking_Management_System.UserControls.CinemaPanel();
            this.dateLabel = new System.Windows.Forms.Label();
            this.cinemaLabel = new System.Windows.Forms.Label();
            this.movieTitleLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.seatsLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.cinemaButton1 = new Cinema_Booking_Management_System.UserControls.CinemaButton();
            this.cancelButton = new Cinema_Booking_Management_System.UserControls.CinemaButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.cinemaPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cinemaPanel1);
            this.panel1.Controls.Add(this.cinemaButton1);
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 450);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 75);
            this.label1.TabIndex = 3;
            this.label1.Text = "Confirming will cancel all reserved seats. Are you sure you want to proceed?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cinemaPanel1
            // 
            this.cinemaPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cinemaPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cinemaPanel1.BorderWidth = 0F;
            this.cinemaPanel1.Controls.Add(this.dateLabel);
            this.cinemaPanel1.Controls.Add(this.cinemaLabel);
            this.cinemaPanel1.Controls.Add(this.movieTitleLabel);
            this.cinemaPanel1.Controls.Add(this.label2);
            this.cinemaPanel1.Controls.Add(this.label6);
            this.cinemaPanel1.Controls.Add(this.totalLabel);
            this.cinemaPanel1.Controls.Add(this.label8);
            this.cinemaPanel1.Controls.Add(this.seatsLabel);
            this.cinemaPanel1.Controls.Add(this.timeLabel);
            this.cinemaPanel1.Location = new System.Drawing.Point(31, 135);
            this.cinemaPanel1.Name = "cinemaPanel1";
            this.cinemaPanel1.paddingBottom = 10;
            this.cinemaPanel1.paddingLeft = 10;
            this.cinemaPanel1.paddingRight = 10;
            this.cinemaPanel1.paddingTop = 10;
            this.cinemaPanel1.Radius = 5;
            this.cinemaPanel1.Size = new System.Drawing.Size(385, 212);
            this.cinemaPanel1.TabIndex = 5;
            // 
            // dateLabel
            // 
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(146, 98);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(193, 19);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "FEB 7, 2024";
            // 
            // cinemaLabel
            // 
            this.cinemaLabel.BackColor = System.Drawing.Color.Transparent;
            this.cinemaLabel.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cinemaLabel.ForeColor = System.Drawing.Color.White;
            this.cinemaLabel.Location = new System.Drawing.Point(22, 65);
            this.cinemaLabel.Name = "cinemaLabel";
            this.cinemaLabel.Size = new System.Drawing.Size(340, 19);
            this.cinemaLabel.TabIndex = 3;
            this.cinemaLabel.Text = "Cinema 1";
            // 
            // movieTitleLabel
            // 
            this.movieTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.movieTitleLabel.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieTitleLabel.ForeColor = System.Drawing.Color.White;
            this.movieTitleLabel.Location = new System.Drawing.Point(22, 28);
            this.movieTitleLabel.Name = "movieTitleLabel";
            this.movieTitleLabel.Size = new System.Drawing.Size(350, 22);
            this.movieTitleLabel.TabIndex = 3;
            this.movieTitleLabel.Text = "Avengers: Endgame";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date and Time:";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(22, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Seats:";
            // 
            // totalLabel
            // 
            this.totalLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalLabel.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.White;
            this.totalLabel.Location = new System.Drawing.Point(77, 168);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(308, 19);
            this.totalLabel.TabIndex = 3;
            this.totalLabel.Text = "₱ 1,400.00";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(24, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 19);
            this.label8.TabIndex = 3;
            this.label8.Text = "Total:";
            // 
            // seatsLabel
            // 
            this.seatsLabel.BackColor = System.Drawing.Color.Transparent;
            this.seatsLabel.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seatsLabel.ForeColor = System.Drawing.Color.White;
            this.seatsLabel.Location = new System.Drawing.Point(77, 133);
            this.seatsLabel.Name = "seatsLabel";
            this.seatsLabel.Size = new System.Drawing.Size(305, 19);
            this.seatsLabel.TabIndex = 3;
            this.seatsLabel.Text = "B3, C7";
            // 
            // timeLabel
            // 
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(265, 98);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(97, 19);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "10:00 AM";
            // 
            // cinemaButton1
            // 
            this.cinemaButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            this.cinemaButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            this.cinemaButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cinemaButton1.BorderRadius = 10;
            this.cinemaButton1.BorderSize = 0;
            this.cinemaButton1.FlatAppearance.BorderSize = 0;
            this.cinemaButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cinemaButton1.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cinemaButton1.ForeColor = System.Drawing.Color.White;
            this.cinemaButton1.Location = new System.Drawing.Point(39, 362);
            this.cinemaButton1.Name = "cinemaButton1";
            this.cinemaButton1.Size = new System.Drawing.Size(182, 47);
            this.cinemaButton1.TabIndex = 4;
            this.cinemaButton1.Text = "Cancel";
            this.cinemaButton1.TextColor = System.Drawing.Color.White;
            this.cinemaButton1.UseVisualStyleBackColor = false;
            this.cinemaButton1.Click += new System.EventHandler(this.cinemaButton1_Click_1);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.cancelButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.cancelButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cancelButton.BorderRadius = 10;
            this.cancelButton.BorderSize = 0;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.Black;
            this.cancelButton.Location = new System.Drawing.Point(232, 362);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(184, 47);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Confirm";
            this.cancelButton.TextColor = System.Drawing.Color.Black;
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.exitButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 36);
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
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cancel Booking";
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
            this.exitButton.Location = new System.Drawing.Point(397, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(58, 36);
            this.exitButton.TabIndex = 0;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // CancelBoookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CancelBoookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CancelBoookingForm";
            this.Load += new System.EventHandler(this.CancelBoookingForm_Load);
            this.panel1.ResumeLayout(false);
            this.cinemaPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exitButton;
        private UserControls.CinemaButton cancelButton;
        private System.Windows.Forms.Label movieTitleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cinemaLabel;
        private System.Windows.Forms.Label seatsLabel;
        private System.Windows.Forms.Label label6;
        private UserControls.CinemaPanel cinemaPanel1;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label label8;
        private UserControls.CinemaButton cinemaButton1;
    }
}