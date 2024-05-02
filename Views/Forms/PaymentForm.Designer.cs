namespace Cinema_Booking_Management_System.Views.Forms
{
    partial class PaymentForm
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
            this.cinemaPanel2 = new Cinema_Booking_Management_System.UserControls.CinemaPanel();
            this.completeButton = new Cinema_Booking_Management_System.UserControls.CinemaButton();
            this.cinemaPanel3 = new Cinema_Booking_Management_System.UserControls.CinemaPanel();
            this.paymentInProgressLabel = new System.Windows.Forms.Label();
            this.totalLabelBig = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cinemaPanel1 = new Cinema_Booking_Management_System.UserControls.CinemaPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.ticketQtyLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.vatLabel = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.seatsLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Label();
            this.cinemaLabel = new System.Windows.Forms.Label();
            this.movieTitleLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.cinemaPanel2.SuspendLayout();
            this.cinemaPanel3.SuspendLayout();
            this.cinemaPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cinemaPanel2);
            this.panel1.Controls.Add(this.cinemaPanel1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 910);
            this.panel1.TabIndex = 0;
            // 
            // cinemaPanel2
            // 
            this.cinemaPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.cinemaPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.cinemaPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.cinemaPanel2.BorderWidth = 0F;
            this.cinemaPanel2.Controls.Add(this.completeButton);
            this.cinemaPanel2.Controls.Add(this.cinemaPanel3);
            this.cinemaPanel2.Controls.Add(this.totalLabelBig);
            this.cinemaPanel2.Controls.Add(this.label16);
            this.cinemaPanel2.Controls.Add(this.label15);
            this.cinemaPanel2.ForeColor = System.Drawing.Color.White;
            this.cinemaPanel2.Location = new System.Drawing.Point(389, 35);
            this.cinemaPanel2.Name = "cinemaPanel2";
            this.cinemaPanel2.paddingBottom = 0;
            this.cinemaPanel2.paddingLeft = 0;
            this.cinemaPanel2.paddingRight = 0;
            this.cinemaPanel2.paddingTop = 0;
            this.cinemaPanel2.Radius = 5;
            this.cinemaPanel2.Size = new System.Drawing.Size(890, 874);
            this.cinemaPanel2.TabIndex = 9;
            // 
            // completeButton
            // 
            this.completeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.completeButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.completeButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.completeButton.BorderRadius = 10;
            this.completeButton.BorderSize = 0;
            this.completeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.completeButton.FlatAppearance.BorderSize = 0;
            this.completeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.completeButton.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completeButton.ForeColor = System.Drawing.Color.Black;
            this.completeButton.Location = new System.Drawing.Point(334, 520);
            this.completeButton.Name = "completeButton";
            this.completeButton.Size = new System.Drawing.Size(235, 54);
            this.completeButton.TabIndex = 4;
            this.completeButton.Text = "Transaction Complete";
            this.completeButton.TextColor = System.Drawing.Color.Black;
            this.completeButton.UseVisualStyleBackColor = false;
            this.completeButton.Click += new System.EventHandler(this.completeButton_Click);
            // 
            // cinemaPanel3
            // 
            this.cinemaPanel3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.cinemaPanel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.cinemaPanel3.BorderWidth = 0F;
            this.cinemaPanel3.Controls.Add(this.paymentInProgressLabel);
            this.cinemaPanel3.Location = new System.Drawing.Point(277, 398);
            this.cinemaPanel3.Name = "cinemaPanel3";
            this.cinemaPanel3.paddingBottom = 10;
            this.cinemaPanel3.paddingLeft = 10;
            this.cinemaPanel3.paddingRight = 10;
            this.cinemaPanel3.paddingTop = 10;
            this.cinemaPanel3.Radius = 10;
            this.cinemaPanel3.Size = new System.Drawing.Size(355, 102);
            this.cinemaPanel3.TabIndex = 2;
            // 
            // paymentInProgressLabel
            // 
            this.paymentInProgressLabel.BackColor = System.Drawing.Color.Transparent;
            this.paymentInProgressLabel.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentInProgressLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.paymentInProgressLabel.Location = new System.Drawing.Point(61, 36);
            this.paymentInProgressLabel.Name = "paymentInProgressLabel";
            this.paymentInProgressLabel.Size = new System.Drawing.Size(291, 39);
            this.paymentInProgressLabel.TabIndex = 2;
            this.paymentInProgressLabel.Text = "Payment in Progress";
            this.paymentInProgressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalLabelBig
            // 
            this.totalLabelBig.Font = new System.Drawing.Font("Helvetica", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabelBig.Location = new System.Drawing.Point(0, 318);
            this.totalLabelBig.Name = "totalLabelBig";
            this.totalLabelBig.Size = new System.Drawing.Size(898, 77);
            this.totalLabelBig.TabIndex = 1;
            this.totalLabelBig.Text = " ₱ 2240.00";
            this.totalLabelBig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(3, 275);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(898, 68);
            this.label16.TabIndex = 1;
            this.label16.Text = "TOTAL";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(50, 75);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(373, 24);
            this.label15.TabIndex = 1;
            this.label15.Text = "PAYMENT METHOD: CASH";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cinemaPanel1
            // 
            this.cinemaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.cinemaPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.cinemaPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.cinemaPanel1.BorderWidth = 0F;
            this.cinemaPanel1.Controls.Add(this.panel7);
            this.cinemaPanel1.Controls.Add(this.panel6);
            this.cinemaPanel1.Controls.Add(this.panel5);
            this.cinemaPanel1.Controls.Add(this.panel4);
            this.cinemaPanel1.Controls.Add(this.backButton);
            this.cinemaPanel1.Controls.Add(this.cinemaLabel);
            this.cinemaPanel1.Controls.Add(this.movieTitleLabel);
            this.cinemaPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.cinemaPanel1.Font = new System.Drawing.Font("Zeitgeist Demo", 8.25F);
            this.cinemaPanel1.ForeColor = System.Drawing.Color.White;
            this.cinemaPanel1.Location = new System.Drawing.Point(0, 36);
            this.cinemaPanel1.Name = "cinemaPanel1";
            this.cinemaPanel1.paddingBottom = 0;
            this.cinemaPanel1.paddingLeft = 0;
            this.cinemaPanel1.paddingRight = 0;
            this.cinemaPanel1.paddingTop = 0;
            this.cinemaPanel1.Radius = 5;
            this.cinemaPanel1.Size = new System.Drawing.Size(383, 872);
            this.cinemaPanel1.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = global::Cinema_Booking_Management_System.Properties.Resources.logo_system_6;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel7.Location = new System.Drawing.Point(42, 28);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(298, 100);
            this.panel7.TabIndex = 17;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.ticketQtyLabel);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.totalLabel);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.vatLabel);
            this.panel6.Controls.Add(this.subtotalLabel);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 457);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(383, 192);
            this.panel6.TabIndex = 5;
            // 
            // ticketQtyLabel
            // 
            this.ticketQtyLabel.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketQtyLabel.Location = new System.Drawing.Point(157, 25);
            this.ticketQtyLabel.Name = "ticketQtyLabel";
            this.ticketQtyLabel.Size = new System.Drawing.Size(183, 26);
            this.ticketQtyLabel.TabIndex = 0;
            this.ticketQtyLabel.Text = "4x ₱500.00";
            this.ticketQtyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 26);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ticket Qty.";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 26);
            this.label9.TabIndex = 0;
            this.label9.Text = "Subtotal";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.ForeColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(36, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 1);
            this.panel2.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(32, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 26);
            this.label11.TabIndex = 0;
            this.label11.Text = "12% VAT";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalLabel
            // 
            this.totalLabel.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(185, 135);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(155, 26);
            this.totalLabel.TabIndex = 0;
            this.totalLabel.Text = " ₱2240.00";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(32, 135);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(147, 26);
            this.label13.TabIndex = 0;
            this.label13.Text = "TOTAL";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // vatLabel
            // 
            this.vatLabel.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vatLabel.Location = new System.Drawing.Point(157, 77);
            this.vatLabel.Name = "vatLabel";
            this.vatLabel.Size = new System.Drawing.Size(183, 26);
            this.vatLabel.TabIndex = 0;
            this.vatLabel.Text = " ₱240.00";
            this.vatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.Location = new System.Drawing.Point(153, 51);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(187, 26);
            this.subtotalLabel.TabIndex = 0;
            this.subtotalLabel.Text = " ₱2000.00";
            this.subtotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.seatsLabel);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 233);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(383, 224);
            this.panel5.TabIndex = 16;
            // 
            // seatsLabel
            // 
            this.seatsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.seatsLabel.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seatsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.seatsLabel.Location = new System.Drawing.Point(0, 45);
            this.seatsLabel.Name = "seatsLabel";
            this.seatsLabel.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.seatsLabel.Size = new System.Drawing.Size(383, 168);
            this.seatsLabel.TabIndex = 0;
            this.seatsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(383, 45);
            this.label5.TabIndex = 0;
            this.label5.Text = "SEATS:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.timeLabel);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.dateLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 203);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(383, 30);
            this.panel4.TabIndex = 15;
            // 
            // timeLabel
            // 
            this.timeLabel.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(197, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(173, 30);
            this.timeLabel.TabIndex = 1;
            this.timeLabel.Text = "11:00 PM";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(182, 3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(18, 24);
            this.label18.TabIndex = 1;
            this.label18.Text = "•";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateLabel
            // 
            this.dateLabel.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(0, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(181, 30);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "DEC 23, 2023";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(39, 815);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(56, 15);
            this.backButton.TabIndex = 14;
            this.backButton.Text = "< BACK";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // cinemaLabel
            // 
            this.cinemaLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.cinemaLabel.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cinemaLabel.Location = new System.Drawing.Point(0, 169);
            this.cinemaLabel.Name = "cinemaLabel";
            this.cinemaLabel.Size = new System.Drawing.Size(383, 34);
            this.cinemaLabel.TabIndex = 0;
            this.cinemaLabel.Text = "CINEMA 3";
            this.cinemaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // movieTitleLabel
            // 
            this.movieTitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.movieTitleLabel.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieTitleLabel.Location = new System.Drawing.Point(0, 0);
            this.movieTitleLabel.Name = "movieTitleLabel";
            this.movieTitleLabel.Size = new System.Drawing.Size(383, 169);
            this.movieTitleLabel.TabIndex = 0;
            this.movieTitleLabel.Text = "MOVIE TITLE";
            this.movieTitleLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.minimizeButton);
            this.panel3.Controls.Add(this.panel11);
            this.panel3.Controls.Add(this.exitButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1278, 36);
            this.panel3.TabIndex = 7;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.label3.Location = new System.Drawing.Point(38, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cinematrix";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label3_MouseDown);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            this.minimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Image = global::Cinema_Booking_Management_System.Properties.Resources.Minimize;
            this.minimizeButton.Location = new System.Drawing.Point(1162, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(58, 36);
            this.minimizeButton.TabIndex = 2;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // panel11
            // 
            this.panel11.BackgroundImage = global::Cinema_Booking_Management_System.Properties.Resources.logo_small_4;
            this.panel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(44, 36);
            this.panel11.TabIndex = 3;
            this.panel11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel11_MouseDown);
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
            this.exitButton.Location = new System.Drawing.Point(1220, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(58, 36);
            this.exitButton.TabIndex = 0;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1280, 910);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentForm";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            this.panel1.ResumeLayout(false);
            this.cinemaPanel2.ResumeLayout(false);
            this.cinemaPanel3.ResumeLayout(false);
            this.cinemaPanel1.ResumeLayout(false);
            this.cinemaPanel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private UserControls.CinemaPanel cinemaPanel2;
        private UserControls.CinemaButton completeButton;
        private UserControls.CinemaPanel cinemaPanel3;
        private System.Windows.Forms.Label paymentInProgressLabel;
        private System.Windows.Forms.Label totalLabelBig;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private UserControls.CinemaPanel cinemaPanel1;
        private System.Windows.Forms.Label backButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label seatsLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label vatLabel;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label ticketQtyLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label cinemaLabel;
        private System.Windows.Forms.Label movieTitleLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
    }
}