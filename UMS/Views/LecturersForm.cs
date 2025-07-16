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
    public partial class LecturersForm : Form
    {
        private LectureController _controller;

        public LecturersForm()
        {
            InitializeComponent();
            _controller = new LectureController("Data Source=UMS_DB.db;Version=3;");
            LoadLecturers();
            LoadUserIDs();

            Add_button.Click += Add_button_Click;
            Update_button.Click += Update_button_Click;
            Delete_button.Click += Delete_button_Click;
            Lecturers_dataGridView.CellClick += Lecturers_dataGridView_CellClick;
        }

        private void LoadLecturers()
        {
            Lecturers_dataGridView.DataSource = _controller.GetAllLecturers();
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
            LectureID_textBox.Text = "";
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

                    _controller.AddLecture(userId, name, address, phone);
                    MessageBox.Show("Lecturer added.");
                    LoadLecturers();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Please select valid user id.");
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
                if (int.TryParse(LectureID_textBox.Text, out int lectureId) &&
                    int.TryParse(UserIDcomboBox.Text, out int userId))
                {
                    string name = Name_textBox.Text;
                    string address = Address_textBox.Text;
                    string phone = PhoneNo_textBox.Text;

                    _controller.UpdateLecture(lectureId, userId, name, address, phone);
                    MessageBox.Show("Lecturer updated.");
                    LoadLecturers();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Enter valid IDs.");
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
                if (int.TryParse(LectureID_textBox.Text, out int lectureId))
                {
                    _controller.DeleteLecture(lectureId);
                    MessageBox.Show("Lecturer deleted.");
                    LoadLecturers();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Enter valid Lecturer ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed: " + ex.Message);
            }
        }

        private void Lecturers_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = Lecturers_dataGridView.Rows[e.RowIndex];
                LectureID_textBox.Text = row.Cells["LectureID"].Value.ToString();
                Name_textBox.Text = row.Cells["Name"].Value.ToString();
                Address_textBox.Text = row.Cells["Address"].Value.ToString();
                PhoneNo_textBox.Text = row.Cells["PhoneNo"].Value.ToString();
                UserIDcomboBox.Text = row.Cells["UserID"].Value.ToString();
            }
        }
        }
    }

