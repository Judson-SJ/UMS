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
    public partial class RoomForm : Form
    {
        private RoomController _controller;

        public RoomForm()
        {
            InitializeComponent();
            _controller = new RoomController("Data Source=UMS_DB.db;Version=3;");
            LoadRooms();
            button1.Click += Add_button_Click;
            Update_button.Click += Update_button_Click;
            Delete_button.Click += Delete_button_Click;
            Rooms_dataGridView.CellClick += Rooms_dataGridView_CellClick;
        }

        private void LoadRooms()
        {
            Rooms_dataGridView.DataSource = _controller.GetAllRooms();
        }

        private void ClearFields()
        {
            RoomID_textBox.Text = "";
            RoomName_textBox.Text = "";
            RoomType_comboBox.SelectedIndex = -1;
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            try
            {
                string name = RoomName_textBox.Text.Trim();
                string type = RoomType_comboBox.Text.Trim();

                if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(type))
                {
                    _controller.AddRoom(name, type);
                    MessageBox.Show("Room added successfully.");
                    LoadRooms();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Please enter room name and select a type.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Room update is not implemented because RoomID is typically auto-generated and not updated directly. Implement if needed.");
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(RoomID_textBox.Text, out int roomId))
                {
                    _controller.DeleteRoom(roomId);
                    MessageBox.Show("Room deleted successfully.");
                    LoadRooms();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Please select a valid room.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Rooms_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && Rooms_dataGridView.Rows[e.RowIndex].Cells["RoomID"].Value != null)
            {
                DataGridViewRow row = Rooms_dataGridView.Rows[e.RowIndex];
                RoomID_textBox.Text = row.Cells["RoomID"].Value.ToString();
                RoomName_textBox.Text = row.Cells["RoomName"].Value.ToString();
                RoomType_comboBox.Text = row.Cells["RoomType"].Value.ToString();
            }
        }
    }
}
