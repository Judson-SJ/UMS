using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            Add_button.Click += Add_button_Click;
            Update_button.Click += Update_button_Click;
            Delete_button.Click += Delete_button_Click;
            Staff_dataGridView.CellClick += Staff_dataGridView_CellClick;

            UserIDcomboBox.Items.Add("1");
            UserIDcomboBox.Items.Add("2");
        }

        private void LoadStaff()
        {
            Staff_dataGridView.DataSource = _controller.GetAllStaff();
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
                if (int.TryParse(StaffID_textBox.Text, out int staffId) &&
                    int.TryParse(UserIDcomboBox.Text, out int userId))
                {
                    var name = Name_textBox.Text.Trim();
                    var address = Address_textBox.Text.Trim();
                    var phone = PhoneNo_textBox.Text.Trim();

                    _controller.AddStaff(staffId, userId, name, address, phone);
                    MessageBox.Show("Staff added.");
                    LoadStaff();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Please enter valid Staff ID and User ID.");
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
                    var name = Name_textBox.Text.Trim();
                    var address = Address_textBox.Text.Trim();
                    var phone = PhoneNo_textBox.Text.Trim();

                    _controller.UpdateStaff(staffId, userId, name, address, phone);
                    MessageBox.Show("Staff updated.");
                    LoadStaff();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Please select a valid staff record.");
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
                    MessageBox.Show("Select a valid staff to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed: " + ex.Message);
            }
        }

        private void Staff_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && Staff_dataGridView.Rows[e.RowIndex].Cells["StaffID"].Value != null)
            {
                var row = Staff_dataGridView.Rows[e.RowIndex];
                StaffID_textBox.Text = row.Cells["StaffID"].Value.ToString();
                Name_textBox.Text = row.Cells["Name"].Value.ToString();
                Address_textBox.Text = row.Cells["Address"].Value.ToString();
                PhoneNo_textBox.Text = row.Cells["PhoneNo"].Value.ToString();
            }
        }

    }
}
