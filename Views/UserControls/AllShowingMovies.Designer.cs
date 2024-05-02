namespace Cinema_Booking_Management_System.UserControls
{
    partial class AllShowingMovies
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
            this.cinemaPanel1 = new Cinema_Booking_Management_System.UserControls.CinemaPanel();
            this.allShowingPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.goBackLabel = new System.Windows.Forms.Label();
            this.nowShowingLabel2 = new System.Windows.Forms.Label();
            this.cinemaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cinemaPanel1
            // 
            this.cinemaPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.cinemaPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.cinemaPanel1.BorderWidth = 0F;
            this.cinemaPanel1.Controls.Add(this.allShowingPanel);
            this.cinemaPanel1.Controls.Add(this.goBackLabel);
            this.cinemaPanel1.Controls.Add(this.nowShowingLabel2);
            this.cinemaPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cinemaPanel1.Location = new System.Drawing.Point(0, 0);
            this.cinemaPanel1.Name = "cinemaPanel1";
            this.cinemaPanel1.paddingBottom = 0;
            this.cinemaPanel1.paddingLeft = 5;
            this.cinemaPanel1.paddingRight = 0;
            this.cinemaPanel1.paddingTop = 0;
            this.cinemaPanel1.Radius = 5;
            this.cinemaPanel1.Size = new System.Drawing.Size(1018, 865);
            this.cinemaPanel1.TabIndex = 0;
            // 
            // allShowingPanel
            // 
            this.allShowingPanel.AutoScroll = true;
            this.allShowingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.allShowingPanel.Location = new System.Drawing.Point(23, 106);
            this.allShowingPanel.Name = "allShowingPanel";
            this.allShowingPanel.Size = new System.Drawing.Size(972, 704);
            this.allShowingPanel.TabIndex = 5;
            // 
            // goBackLabel
            // 
            this.goBackLabel.AutoSize = true;
            this.goBackLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.goBackLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goBackLabel.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackLabel.ForeColor = System.Drawing.Color.White;
            this.goBackLabel.Location = new System.Drawing.Point(907, 49);
            this.goBackLabel.Name = "goBackLabel";
            this.goBackLabel.Size = new System.Drawing.Size(62, 19);
            this.goBackLabel.TabIndex = 4;
            this.goBackLabel.Text = "<  Back";
            this.goBackLabel.Click += new System.EventHandler(this.goBackLabel_Click);
            // 
            // nowShowingLabel2
            // 
            this.nowShowingLabel2.AutoSize = true;
            this.nowShowingLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.nowShowingLabel2.Font = new System.Drawing.Font("Helvetica", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nowShowingLabel2.ForeColor = System.Drawing.Color.White;
            this.nowShowingLabel2.Location = new System.Drawing.Point(36, 40);
            this.nowShowingLabel2.Name = "nowShowingLabel2";
            this.nowShowingLabel2.Size = new System.Drawing.Size(351, 38);
            this.nowShowingLabel2.TabIndex = 3;
            this.nowShowingLabel2.Text = "SCHEDULED MOVIES";
            // 
            // AllShowingMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.cinemaPanel1);
            this.Name = "AllShowingMovies";
            this.Size = new System.Drawing.Size(1018, 865);
            this.Load += new System.EventHandler(this.AllShowingMovies_Load);
            this.cinemaPanel1.ResumeLayout(false);
            this.cinemaPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CinemaPanel cinemaPanel1;
        private System.Windows.Forms.Label goBackLabel;
        private System.Windows.Forms.Label nowShowingLabel2;
        public System.Windows.Forms.FlowLayoutPanel allShowingPanel;
    }
}
