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
    public partial class LecturersForm : Form
    {
        private LectureController _controller;

        public LecturersForm()
        {
            InitializeComponent();
            _controller = new LectureController("Data Source=UMS_DB.db;Version=3;");
            LoadLecturers();
            Add_button.Click += Add_button_Click;
            Update_button.Click += Update_button_Click;
            Delete_button.Click += Delete_button_Click;
            Lecturers_dataGridView.CellClick += Lecturers_dataGridView_CellClick;

            
            UserIDcomboBox.Items.Add("1");
            UserIDcomboBox.Items.Add("2");
        }

        private void LoadLecturers()
        {
            Lecturers_dataGridView.DataSource = _controller.GetAllLecturers();
        }

        private void ClearFields()
        {
            StudentID_textBox.Text = "";
            StudentName_textBox.Text = "";
            Address_textBox.Text = "";
            PhoneNo_textBox.Text = "";
            UserIDcomboBox.SelectedIndex = -1;
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(StudentID_textBox.Text, out int lectureId) &&
                    int.TryParse(UserIDcomboBox.Text, out int userId))
                {
                    string name = StudentName_textBox.Text;
                    string address = Address_textBox.Text;
                    string phone = PhoneNo_textBox.Text;

                    _controller.AddLecture(lectureId, userId, name, address, phone);
                    MessageBox.Show("Lecturer added.");
                    LoadLecturers();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Enter valid Lecture ID and User ID.");
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
                if (int.TryParse(StudentID_textBox.Text, out int lectureId) &&
                    int.TryParse(UserIDcomboBox.Text, out int userId))
                {
                    string name = StudentName_textBox.Text;
                    string address = Address_textBox.Text;
                    string phone = PhoneNo_textBox.Text;

                    _controller.UpdateLecture(lectureId, userId, name, address, phone);
                    MessageBox.Show("Lecturer updated.");
                    LoadLecturers();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Select a valid lecturer.");
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
                if (int.TryParse(StudentID_textBox.Text, out int lectureId))
                {
                    _controller.DeleteLecture(lectureId);
                    MessageBox.Show("Lecturer deleted.");
                    LoadLecturers();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Select a valid lecturer to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Lecturers_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && Lecturers_dataGridView.Rows[e.RowIndex].Cells["LectureID"].Value != null)
            {
                var row = Lecturers_dataGridView.Rows[e.RowIndex];
                StudentID_textBox.Text = row.Cells["LectureID"].Value.ToString();
                StudentName_textBox.Text = row.Cells["Name"].Value.ToString();
                Address_textBox.Text = row.Cells["Address"].Value.ToString();
                PhoneNo_textBox.Text = row.Cells["PhoneNo"].Value.ToString();
                
            }
        }
    }
}
