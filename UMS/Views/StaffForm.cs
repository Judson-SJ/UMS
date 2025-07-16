using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UMS.Controllers;

namespace UMS.Views
{
    public partial class StaffForm : Form
    {
        private StaffController _controller;

        public StaffForm()
        {
            InitializeComponent();
            _controller = new StaffController("Data Source=UMS_DB.db;Version=3;");
            LoadStaff();
            LoadUserIDs();

            Add_button.Click += Add_button_Click;
            Update_button.Click += Update_button_Click;
            Delete_button.Click += Delete_button_Click;
            Staff_dataGridView.CellClick += Staff_dataGridView_CellClick;
        }

        private void LoadStaff()
        {
            Staff_dataGridView.DataSource = _controller.GetAllStaff();
        }

        private void LoadUserIDs()
        {
            using (var conn = new SQLiteConnection("Data Source=UMS_DB.db;Version=3;"))
            {
                conn.Open();
                var cmd = new SQLiteCommand("SELECT UserID FROM Users", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    UserIDcomboBox.Items.Clear();
                    while (reader.Read())
                    {
                        UserIDcomboBox.Items.Add(reader["UserID"].ToString());
                    }
                }
            }
        }

        private void ClearFields()
        {
            StaffID_textBox.Text = "";
            Name_textBox.Text = "";
            Address_textBox.Text = "";
            PhoneNo_textBox.Text = "";
            UserIDcomboBox.SelectedIndex = -1;
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(UserIDcomboBox.Text, out int userId))
                {
                    string name = Name_textBox.Text;
                    string address = Address_textBox.Text;
                    string phone = PhoneNo_textBox.Text;
                    _controller.AddStaff(userId, name, address, phone);
                    MessageBox.Show("Staff added.");
                    LoadStaff();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Please select a User ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add failed: " + ex.Message);
            }
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(StaffID_textBox.Text, out int staffId) &&
                    int.TryParse(UserIDcomboBox.Text, out int userId))
                {
                    string name = Name_textBox.Text;
                    string address = Address_textBox.Text;
                    string phone = PhoneNo_textBox.Text;
                    _controller.UpdateStaff(staffId, userId, name, address, phone);
                    MessageBox.Show("Staff updated.");
                    LoadStaff();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Please enter valid Staff ID and select a User ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message);
            }
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(StaffID_textBox.Text, out int staffId))
                {
                    _controller.DeleteStaff(staffId);
                    MessageBox.Show("Staff deleted.");
                    LoadStaff();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Please enter a valid Staff ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed: " + ex.Message);
            }
        }

        private void Staff_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = Staff_dataGridView.Rows[e.RowIndex];
                StaffID_textBox.Text = row.Cells["StaffID"].Value.ToString();
                Name_textBox.Text = row.Cells["Name"].Value.ToString();
                Address_textBox.Text = row.Cells["Address"].Value.ToString();
                PhoneNo_textBox.Text = row.Cells["PhoneNo"].Value.ToString();
                UserIDcomboBox.Text = row.Cells["UserID"].Value.ToString();
            }
        }

    }
}
