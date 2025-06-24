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
    public partial class AdminForm : Form
    {
        private AdminController _controller;

        public AdminForm()
        {
            InitializeComponent();
            _controller = new AdminController("Data Source=UMS_DB.db;Version=3;");
            LoadAdmins();
            Admins_dataGridView.CellClick += Admins_dataGridView_CellClick;
            Add_button.Click += Add_button_Click;
            Update_button.Click += Update_button_Click;
            Delete_button.Click += Delete_button_Click;
        }

        private void LoadAdmins()
        {
            Admins_dataGridView.DataSource = _controller.GetAllAdmins();
        }

        private void ClearFields()
        {
            UserID_textBox.Text = "";
            Name_textBox.Text = "";
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(UserID_textBox.Text, out int userId))
                {
                    var name = Name_textBox.Text;
                    int newAdminId = new Random().Next(1000, 9999); // You may replace this with actual DB-generated ID
                    _controller.AddAdmin(newAdminId, userId, name);
                    MessageBox.Show("Admin added successfully.");
                    LoadAdmins();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Invalid User ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(UserID_textBox.Text, out int userId) &&
                    int.TryParse(Admins_dataGridView.CurrentRow?.Cells["AdminID"].Value.ToString(), out int adminId))
                {
                    var name = Name_textBox.Text;
                    _controller.UpdateAdmin(adminId, userId, name);
                    MessageBox.Show("Admin updated successfully.");
                    LoadAdmins();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Select an admin from the table first.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(Admins_dataGridView.CurrentRow?.Cells["AdminID"].Value.ToString(), out int adminId))
                {
                    _controller.DeleteAdmin(adminId);
                    MessageBox.Show("Admin deleted successfully.");
                    LoadAdmins();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Select an admin from the table first.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Admins_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && Admins_dataGridView.Rows[e.RowIndex].Cells["AdminID"].Value != null)
            {
                DataGridViewRow row = Admins_dataGridView.Rows[e.RowIndex];
                UserID_textBox.Text = row.Cells["UserID"].Value.ToString();
                Name_textBox.Text = row.Cells["Name"].Value.ToString();
            }
        }
    }
}
