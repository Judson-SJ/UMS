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
    public partial class CoursesForm : Form
    {
        private CourseController _controller;

        public CoursesForm()
        {
            InitializeComponent();
            _controller = new CourseController("Data Source=UMS_DB.db;Version=3;");
            LoadCourses();
            Courses_dataGridView.CellClick += Courses_dataGridView_CellClick;
            button1.Click += Add_button_Click;
            Update_button.Click += Update_button_Click;
            Delete_button.Click += Delete_button_Click;
        }

        private void LoadCourses()
        {
            Courses_dataGridView.DataSource = _controller.GetCourses();
        }

        private void ClearFields()
        {
            CouseName_textBox.Text = "";
            CourseID_textBox.Text = "";
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            try
            {
                var courseName = CouseName_textBox.Text.Trim();
                if (!string.IsNullOrEmpty(courseName))
                {
                    _controller.AddCourse(courseName);
                    MessageBox.Show("Course added successfully.");
                    LoadCourses();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Course name cannot be empty.");
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
                if (int.TryParse(CourseID_textBox.Text, out int courseId))
                {
                    var courseName = CouseName_textBox.Text.Trim();
                    _controller.UpdateCourse(courseId, courseName);
                    MessageBox.Show("Course updated successfully.");
                    LoadCourses();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Please select a valid course.");
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
                if (int.TryParse(CourseID_textBox.Text, out int courseId))
                {
                    _controller.DeleteCourse(courseId);
                    MessageBox.Show("Course deleted successfully.");
                    LoadCourses();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Please select a valid course.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Courses_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && Courses_dataGridView.Rows[e.RowIndex].Cells["CourseID"].Value != null)
            {
                var row = Courses_dataGridView.Rows[e.RowIndex];
                CourseID_textBox.Text = row.Cells["CourseID"].Value.ToString();
                CouseName_textBox.Text = row.Cells["CourseName"].Value.ToString();
            }
        }

    }
}
