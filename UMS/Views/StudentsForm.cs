﻿using System;
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
    public partial class StudentsForm : Form
    {
        private StudentController _controller;

        public StudentsForm()
        {
            InitializeComponent();
            _controller = new StudentController("Data Source=UMS_DB.db;Version=3;");
            LoadStudents();
            LoadUserIDs();
            LoadCourses();

            Add_button.Click += Add_button_Click;
            Update_button.Click += Update_button_Click;
            Delete_button.Click += Delete_button_Click;
            Students_dataGridView.CellClick += Students_dataGridView_CellClick;
        }

        private void LoadStudents()
        {
            Students_dataGridView.DataSource = _controller.GetAllStudents();
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

        private void LoadCourses()
        {
            using (var conn = new SQLiteConnection("Data Source=UMS_DB.db;Version=3;"))
            {
                conn.Open();
                var cmd = new SQLiteCommand("SELECT Name FROM Courses", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    Course_comboBox.Items.Clear();
                    while (reader.Read())
                    {
                        Course_comboBox.Items.Add(reader["Name"].ToString());
                    }
                }
            }
        }

        private void ClearFields()
        {
            StudentID_textBox.Text = "";
            StudentName_textBox.Text = "";
            Address_textBox.Text = "";
            PhoneNo_textBox.Text = "";
            Course_comboBox.SelectedIndex = -1;
            UserIDcomboBox.SelectedIndex = -1;
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(UserIDcomboBox.Text, out int userId))
                {
                    string name = StudentName_textBox.Text;
                    string address = Address_textBox.Text;
                    string course = Course_comboBox.Text;
                    string phone = PhoneNo_textBox.Text;

                    _controller.AddStudent(userId, name, address, course, phone);
                    MessageBox.Show("Student added.");
                    LoadStudents();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Select a valid User ID.");
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
                if (int.TryParse(StudentID_textBox.Text, out int studentId) &&
                    int.TryParse(UserIDcomboBox.Text, out int userId))
                {
                    string name = StudentName_textBox.Text;
                    string address = Address_textBox.Text;
                    string course = Course_comboBox.Text;
                    string phone = PhoneNo_textBox.Text;

                    _controller.UpdateStudent(studentId, userId, name, address, course, phone);
                    MessageBox.Show("Student updated.");
                    LoadStudents();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Enter valid Student ID and select a User ID.");
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
                if (int.TryParse(StudentID_textBox.Text, out int studentId))
                {
                    _controller.DeleteStudent(studentId);
                    MessageBox.Show("Student deleted.");
                    LoadStudents();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Enter a valid Student ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed: " + ex.Message);
            }
        }

        private void Students_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = Students_dataGridView.Rows[e.RowIndex];
                StudentID_textBox.Text = row.Cells["StudentID"].Value.ToString();
                StudentName_textBox.Text = row.Cells["Name"].Value.ToString();
                Address_textBox.Text = row.Cells["Address"].Value.ToString();
                Course_comboBox.Text = row.Cells["Course"].Value.ToString();
                PhoneNo_textBox.Text = row.Cells["PhoneNo"].Value.ToString();
                UserIDcomboBox.Text = row.Cells["UserID"].Value.ToString();
            }
        }
    }
}
