namespace Cinema_Booking_Management_System
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.loginButton = new Cinema_Booking_Management_System.UserControls.CinemaButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.showHideImg = new System.Windows.Forms.Panel();
            this.passwordTextBox = new Cinema_Booking_Management_System.UserControls.CinemaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.usernameTextBox = new Cinema_Booking_Management_System.UserControls.CinemaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.loginFormLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.loginPanel);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 910);
            this.panel1.TabIndex = 0;
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.loginPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Controls.Add(this.panel7);
            this.loginPanel.Controls.Add(this.panel6);
            this.loginPanel.Controls.Add(this.panel5);
            this.loginPanel.Font = new System.Drawing.Font("Helvetica Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPanel.Location = new System.Drawing.Point(420, 349);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(448, 391);
            this.loginPanel.TabIndex = 2;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.loginButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.loginButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.loginButton.BorderRadius = 15;
            this.loginButton.BorderSize = 0;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.Black;
            this.loginButton.Location = new System.Drawing.Point(40, 296);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(371, 44);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.TextColor = System.Drawing.Color.Black;
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.showHideImg);
            this.panel7.Controls.Add(this.passwordTextBox);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 185);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(446, 87);
            this.panel7.TabIndex = 1;
            // 
            // showHideImg
            // 
            this.showHideImg.BackColor = System.Drawing.Color.Black;
            this.showHideImg.BackgroundImage = global::Cinema_Booking_Management_System.Properties.Resources.show1;
            this.showHideImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.showHideImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showHideImg.Location = new System.Drawing.Point(372, 31);
            this.showHideImg.Name = "showHideImg";
            this.showHideImg.Size = new System.Drawing.Size(30, 30);
            this.showHideImg.TabIndex = 2;
            this.showHideImg.Click += new System.EventHandler(this.showHideImg_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.passwordTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.passwordTextBox.BorderFocusColor = System.Drawing.Color.White;
            this.passwordTextBox.BorderRadius = 10;
            this.passwordTextBox.BorderSize = 1;
            this.passwordTextBox.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.White;
            this.passwordTextBox.Location = new System.Drawing.Point(40, 22);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextBox.Multiline = false;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Padding = new System.Windows.Forms.Padding(15, 12, 43, 12);
            this.passwordTextBox.PasswordChar = true;
            this.passwordTextBox.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.passwordTextBox.PlaceholderText = "Enter you password";
            this.passwordTextBox.Size = new System.Drawing.Size(371, 47);
            this.passwordTextBox.TabIndex = 0;
            this.passwordTextBox.Texts = "";
            this.passwordTextBox.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(51, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.usernameTextBox);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 67);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(446, 118);
            this.panel6.TabIndex = 0;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.usernameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.usernameTextBox.BorderFocusColor = System.Drawing.Color.White;
            this.usernameTextBox.BorderRadius = 10;
            this.usernameTextBox.BorderSize = 1;
            this.usernameTextBox.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.ForeColor = System.Drawing.Color.White;
            this.usernameTextBox.Location = new System.Drawing.Point(40, 40);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTextBox.Multiline = false;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Padding = new System.Windows.Forms.Padding(15, 12, 15, 12);
            this.usernameTextBox.PasswordChar = false;
            this.usernameTextBox.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.usernameTextBox.PlaceholderText = "Enter you username";
            this.usernameTextBox.Size = new System.Drawing.Size(371, 47);
            this.usernameTextBox.TabIndex = 0;
            this.usernameTextBox.Texts = "";
            this.usernameTextBox.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.loginFormLabel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(446, 67);
            this.panel5.TabIndex = 1;
            // 
            // loginFormLabel
            // 
            this.loginFormLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.loginFormLabel.Font = new System.Drawing.Font("Helvetica", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginFormLabel.ForeColor = System.Drawing.Color.White;
            this.loginFormLabel.Location = new System.Drawing.Point(0, 0);
            this.loginFormLabel.Name = "loginFormLabel";
            this.loginFormLabel.Size = new System.Drawing.Size(446, 96);
            this.loginFormLabel.TabIndex = 0;
            this.loginFormLabel.Text = "LOGIN";
            this.loginFormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::Cinema_Booking_Management_System.Properties.Resources.logo_system_5;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1278, 307);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.minimizeButton);
            this.panel2.Controls.Add(this.exitButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1278, 36);
            this.panel2.TabIndex = 0;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.label3.Location = new System.Drawing.Point(38, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cinematrix";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label3_MouseDown);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::Cinema_Booking_Management_System.Properties.Resources.logo_small_4;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(44, 36);
            this.panel4.TabIndex = 1;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown);
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
            this.minimizeButton.TabIndex = 0;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
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
            this.exitButton.TabStop = false;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 910);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "324343";
            this.panel1.ResumeLayout(false);
            this.loginPanel.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label loginFormLabel;
        private UserControls.CinemaButton loginButton;
        private UserControls.CinemaTextBox usernameTextBox;
        private UserControls.CinemaTextBox passwordTextBox;
        private System.Windows.Forms.Panel showHideImg;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
    }
}

