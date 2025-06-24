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
    public partial class UsersForm : Form
    {
        private UsersController _controller;

        public UsersForm()
        {
            InitializeComponent();
            _controller = new UsersController("Data Source=UMS_DB.db;Version=3;");
            LoadUsers();
            Users_dataGridView.CellClick += Users_dataGridView_CellClick;
            Add_button.Click += Add_button_Click;
            Update_button.Click += Update_button_Click;
            Delete_button.Click += Delete_button_Click;
        }

        private void LoadUsers()
        {
            Users_dataGridView.DataSource = _controller.GetAllUsers();
        }

        private void ClearFields()
        {
            UserID_textBox.Text = "";
            Name_textBox.Text = "";
            Password_textBox.Text = "";
            Role_comboBox.SelectedIndex = -1;
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            try
            {
                var name = Name_textBox.Text;
                var password = Password_textBox.Text;
                var role = Role_comboBox.Text;

                _controller.AddUser(name, password, role);
                MessageBox.Show("User added successfully.");
                LoadUsers();
                ClearFields();
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
                if (int.TryParse(UserID_textBox.Text, out int userId))
                {
                    var name = Name_textBox.Text;
                    var password = Password_textBox.Text;
                    var role = Role_comboBox.Text;

                    _controller.UpdateUser(userId, name, password, role);
                    MessageBox.Show("User updated successfully.");
                    LoadUsers();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Please select a valid user from the table.");
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
                if (int.TryParse(UserID_textBox.Text, out int userId))
                {
                    _controller.DeleteUser(userId);
                    MessageBox.Show("User deleted successfully.");
                    LoadUsers();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Please select a valid user from the table.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Users_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && Users_dataGridView.Rows[e.RowIndex].Cells["UserID"].Value != null)
            {
                DataGridViewRow row = Users_dataGridView.Rows[e.RowIndex];
                UserID_textBox.Text = row.Cells["UserID"].Value.ToString();
                Name_textBox.Text = row.Cells["Name"].Value.ToString();
                Password_textBox.Text = row.Cells["Password"].Value.ToString();
                Role_comboBox.Text = row.Cells["Role"].Value.ToString();
            }
        }
    }
}
