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
    public partial class AdminForm : Form
    {
        private AdminController _controller;

        public AdminForm()
        {
            InitializeComponent();
            _controller = new AdminController("Data Source=UMS_DB.db;Version=3;");
            LoadAdmins();
            LoadUserIDs();

            Admins_dataGridView.CellClick += Admins_dataGridView_CellClick;
            Add_button.Click += Add_button_Click;
            Update_button.Click += Update_button_Click;
            Delete_button.Click += Delete_button_Click;
        }

        private void LoadAdmins()
        {
            Admins_dataGridView.DataSource = _controller.GetAllAdmins();
        }

        private void LoadUserIDs()
        {
            using (var conn = new SQLiteConnection("Data Source=UMS_DB.db;Version=3;"))
            {
                conn.Open();
                var cmd = new SQLiteCommand("SELECT UserID FROM Users", conn);
                var reader = cmd.ExecuteReader();
                UserID_comboBox.Items.Clear();
                while (reader.Read())
                {
                    UserID_comboBox.Items.Add(reader["UserID"].ToString());
                }
            }
        }

        private void ClearFields()
        {
            AdminID_textBox.Text = "";
            Name_textBox.Text = "";
            UserID_comboBox.SelectedIndex = -1;
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            try
            {
                if
                    (int.TryParse(UserID_comboBox.Text, out int userId))
                {
                    string name = Name_textBox.Text;
                    _controller.AddAdmin(userId, name);
                    MessageBox.Show("Admin added.");
                    LoadAdmins();
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
                if (int.TryParse(AdminID_textBox.Text, out int adminId) &&
                    int.TryParse(UserID_comboBox.Text, out int userId))
                {
                    string name = Name_textBox.Text;
                    _controller.UpdateAdmin(adminId, userId, name);
                    MessageBox.Show("Admin updated.");
                    LoadAdmins();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Please enter valid Admin ID and select a User ID.");
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
                if (int.TryParse(AdminID_textBox.Text, out int adminId))
                {
                    _controller.DeleteAdmin(adminId);
                    MessageBox.Show("Admin deleted.");
                    LoadAdmins();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Please enter a valid Admin ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed: " + ex.Message);
            }
        }

        private void Admins_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = Admins_dataGridView.Rows[e.RowIndex];
                AdminID_textBox.Text = row.Cells["AdminID"].Value.ToString();
                Name_textBox.Text = row.Cells["Name"].Value.ToString();
                UserID_comboBox.Text = row.Cells["UserID"].Value.ToString();
            }
        }

        private void UserID_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
