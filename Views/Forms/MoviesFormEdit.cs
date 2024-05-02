﻿using Cinema_Booking_Management_System.UserControls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Booking_Management_System.Views.Forms
{
    public partial class MoviesFormEdit : Form
    {
        string connectionString = "datasource=127.0.0.1; port=3306;username=root;password=;database=cinema_management_system";
        public bool IsImageLoaded { get; set; }
        public bool IsEditButtonCLicked { get; set; }

        public string _movieID;

        public MoviesFormEdit(Movies moviesForm)
        {
            InitializeComponent();
            ApplyRoundedCorners();

            clearButton.MouseEnter += OnMouseEnterButton;
            clearButton.MouseLeave += OnMouseLeaveButton;
        }

        private void OnMouseEnterButton(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(22, 23, 26);
        }

        private void OnMouseLeaveButton(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Transparent;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void ApplyRoundedCorners()
        {
            int radius = 1; // You can adjust this value to change the roundness

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
            path.AddArc(this.Width - radius * 2, 0, radius * 2, radius * 2, 270, 90);
            path.AddArc(this.Width - radius * 2, this.Height - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddArc(0, this.Height - radius * 2, radius * 2, radius * 2, 90, 90);

            this.Region = new Region(path);
        }

        private void MoviesFormEdit_Load(object sender, EventArgs e)
        {
            posterPictureBox.AllowDrop = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    //Check if textbox is blank
                    if (!CheckConstraints())
                    {
                        return;
                    }

                    if (!UtilityHelper.IsNumeric(ticketPriceTextBox.Texts))
                    {
                        MessageBox.Show("Please enter a valid ticket price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string query = @"UPDATE movies SET MovieTitle = @MovieTitle, ReleaseDate = @ReleaseDate, Genre = @Genre, Directors = @Directors, 
                                    Rating = @Rating, Duration = @Duration, TicketPrice = @TicketPrice, Status = @Status, 
                                    Cast = @Cast, Sypnosis = @Sypnosis, Poster = @Image 
                                    WHERE MovieID = @MovieID";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Assuming these are your TextBox controls
                        command.Parameters.AddWithValue("@MovieTitle", movieTitleTextBox.Texts);
                        command.Parameters.AddWithValue("@ReleaseDate", releaseDate.Value.ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@Genre", genreTextBox.Texts);
                        command.Parameters.AddWithValue("@Directors", directorsTextBox.Texts);
                        command.Parameters.AddWithValue("@Rating", ratingComboBox.SelectedItem);
                        command.Parameters.AddWithValue("@Duration", durationTextBox.Texts);
                        command.Parameters.AddWithValue("@TicketPrice", ticketPriceTextBox.Texts);
                        command.Parameters.AddWithValue("@Status", statusComboBox.SelectedItem);
                        command.Parameters.AddWithValue("@Cast", castTextBox.Texts);
                        command.Parameters.AddWithValue("@Sypnosis", descriptionTextBox.Texts);
                        command.Parameters.AddWithValue("@MovieID", _movieID);

                        byte[] imageBytes = ImageToByteArray(posterPictureBox.Image);
                        command.Parameters.AddWithValue("@Image", imageBytes);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Movies.CurrentInstance.DisplayData();
                            MessageBox.Show("Movie data edit successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearTextBoxes();
                            this.Hide();
                            connection.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert admin data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int defaultImageHashCode;
        private void MoviesForm_Load(object sender, EventArgs e)
        {
            posterPictureBox.AllowDrop = true;
            // Only set the default image if no other image has been loaded
            if (!IsImageLoaded)
            {
                posterPictureBox.Image = Properties.Resources.defaultImage;
                defaultImageHashCode = posterPictureBox.Image.GetHashCode();
            }
        }

        private bool CheckConstraints()
        {
            if (string.IsNullOrWhiteSpace(movieTitleTextBox.Texts) ||
                string.IsNullOrWhiteSpace(genreTextBox.Texts) ||
                string.IsNullOrWhiteSpace(directorsTextBox.Texts) ||
                ratingComboBox.Texts == "Select Rating" ||
                string.IsNullOrWhiteSpace(durationTextBox.Texts) ||
                string.IsNullOrWhiteSpace(ticketPriceTextBox.Texts) ||
                ratingComboBox.Texts == "Select status" ||
                string.IsNullOrWhiteSpace(castTextBox.Texts) ||
                string.IsNullOrWhiteSpace(descriptionTextBox.Texts) ||
                IsDefaultImage(posterPictureBox))
            {
                MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            return true;
        }

        public static byte[] ImageToByteArray(Image imageIn)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }

        bool IsDefaultImage(PictureBox pictureBox)
        {
            return pictureBox.Image.GetHashCode() == defaultImageHashCode;
        }

        private void ClearTextBoxes()
        {
            movieTitleTextBox.Texts = "";
            genreTextBox.Texts = "";
            releaseDate.Value = DateTime.Now;
            directorsTextBox.Texts = "";
            durationTextBox.Texts = "";
            ticketPriceTextBox.Texts = "";
            statusComboBox.Texts = "";
            castTextBox.Texts = "";
            descriptionTextBox.Texts = "";
            ratingComboBox.SelectedItem = "Select Rating";
            statusComboBox.SelectedItem = "Select status";
        }

        private void BrowseImage()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.gif;*.bmp|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected image file path
                string imagePath = openFileDialog.FileName;

                // Display the selected image in the PictureBox
                posterPictureBox.Image = System.Drawing.Image.FromFile(imagePath);
            }

        }

        private void posterPictureBox_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                var fileNames = data as string[];
                if (fileNames.Length > 0)
                {
                    posterPictureBox.Image = Image.FromFile(fileNames[0]);
                }
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void posterPictureBox_Click_1(object sender, EventArgs e)
        {
            BrowseImage();
        }

        private void posterPictureBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear text boxes
            movieTitleTextBox.Texts = "";
            genreTextBox.Texts = "";
            directorsTextBox.Texts = "";
            durationTextBox.Texts = "";
            ticketPriceTextBox.Texts = "";
            castTextBox.Texts = "";
            descriptionTextBox.Texts = "";

            releaseDate.Value = DateTime.Now;

            // Reset combo boxes to their default items
            ratingComboBox.Texts = "Select Rating";
            statusComboBox.Texts = "Select status";

            // Reset the image to the default image
            posterPictureBox.Image = Properties.Resources.defaultImage;
            IsImageLoaded = false;
        }
    }
}