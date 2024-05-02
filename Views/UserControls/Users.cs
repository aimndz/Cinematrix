using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Booking_Management_System.UserControls
{
    public partial class Users : UserControl
    {

        string connectionString = "datasource=127.0.0.1; port=3306;username=root;password=;database=cinema_management_system";

        public static Users CurrentInstance;

        public Users()
        {
            InitializeComponent();
            DisplayData();
            CurrentInstance = this;
        }

        public void DisplayData()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT UserID, FirstName, LastName, Address, BirthDate, PhoneNumber, Email FROM users;";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        usersTable.DataSource = dataTable;
                    }
                }
                connection.Close();
            }
        }

        private void Users_Load(object sender, EventArgs e)
        {
            addEditButton();
        }

        private void addEditButton()
        {
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.HeaderText = "Edit";
            editButtonColumn.Text = "Edit";
            editButtonColumn.UseColumnTextForButtonValue = true;

            usersTable.Columns.Add(editButtonColumn);

            // Find the column with header text "Edit"
            foreach (DataGridViewColumn column in usersTable.Columns)
            {
                if (column.HeaderText == "Edit" && column is DataGridViewButtonColumn)
                {
                    DataGridViewButtonColumn c = (DataGridViewButtonColumn)column;
                    c.FlatStyle = FlatStyle.Flat;
                    c.DefaultCellStyle.ForeColor = Color.White;
                    c.DefaultCellStyle.BackColor = Color.FromArgb(16, 16, 20); ;
                    break;
                }
            }
        }

        private void addUsersButton_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm(this);
            usersForm.ShowDialog();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void addUsersButton_MouseEnter(object sender, EventArgs e)
        {
            addUsersButton.BackColor = Color.FromArgb(22, 23, 26);
        }

        private void addUsersButton_MouseLeave(object sender, EventArgs e)
        {
            addUsersButton.BackColor = Color.FromArgb(16, 16, 20);
        }

        private void usersTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int editButtonColumnIndex = GetEditButtonColumnIndex();

            if (e.ColumnIndex == editButtonColumnIndex && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = usersTable.Rows[e.RowIndex];

                UsersFormEdit usersForm = new UsersFormEdit(this);
                usersForm.firstNameTextBox.Texts = selectedRow.Cells["FirstName"].Value.ToString();
                usersForm.lastNameTextBox.Texts = selectedRow.Cells["LastName"].Value.ToString();
                usersForm.addressTextBox.Texts = selectedRow.Cells["Address"].Value.ToString();
                usersForm.birthDate.Value = Convert.ToDateTime(selectedRow.Cells["BirthDate"].Value);
                usersForm.phoneNumberTextBox.Texts = selectedRow.Cells["PhoneNumber"].Value.ToString();
                usersForm.emailTextBox.Texts = selectedRow.Cells["Email"].Value.ToString();
                usersForm._userId = selectedRow.Cells["UserID"].Value.ToString();

                // Set text color to white for all textboxes
                usersForm.firstNameTextBox.ForeColor = Color.White;
                usersForm.lastNameTextBox.ForeColor = Color.White;
                usersForm.addressTextBox.ForeColor = Color.White;
                usersForm.birthDate.CalendarForeColor = Color.White;
                usersForm.phoneNumberTextBox.ForeColor = Color.White;
                usersForm.emailTextBox.ForeColor = Color.White;

                usersForm.ShowDialog();
            }
        }

        private int GetEditButtonColumnIndex()
        {
            foreach (DataGridViewColumn column in usersTable.Columns)
            {
                if (column.HeaderText == "Edit" && column is DataGridViewButtonColumn)
                {
                    return column.Index;
                }
            }

            return -1; // Return -1 if "Edit" button column is not found
        }

    }
}
