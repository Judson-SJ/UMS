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
    public partial class StudentsForm : Form
    {
        private StudentController _controller;

        public StudentsForm()
        {
            InitializeComponent();
            _controller = new StudentController("Data Source=UMS_DB.db;Version=3;");
            LoadStudents();
            Add_button.Click += Add_button_Click;
            Update_button.Click += Update_button_Click;
            Delete_button.Click += Delete_button_Click;
            Students_dataGridView.CellClick += Students_dataGridView_CellClick;

            Course_comboBox.Items.Add("Software Engineering");
            Course_comboBox.Items.Add("Computer Science");
            Course_comboBox.Items.Add("Business IT");

            UserIDcomboBox.Items.Add("1"); 
            UserIDcomboBox.Items.Add("2");
        }

        private void LoadStudents()
        {
            Students_dataGridView.DataSource = _controller.GetAllStudents();
        }

        private void ClearFields()
        {
            StudentID_textBox.Text = "";
            StudentName_textBox.Text = "";
            Address_textBox.Text = "";
            PhoneNo_textBox.Text = "";
            UserIDcomboBox.SelectedIndex = -1;
            Course_comboBox.SelectedIndex = -1;
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            try
            {
                string name = StudentName_textBox.Text;
                string course = Course_comboBox.Text;
                if (!string.IsNullOrWhiteSpace(course))
                {
                    _controller.AddStudent(name, course);
                    MessageBox.Show("Student added.");
                    LoadStudents();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Select a valid course.");
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
                if (int.TryParse(StudentID_textBox.Text, out int studentId))
                {
                    string name = StudentName_textBox.Text;
                    string course = Course_comboBox.Text;
                    _controller.UpdateStudent(studentId, name, course);
                    MessageBox.Show("Student updated.");
                    LoadStudents();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Select a valid student.");
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
                    MessageBox.Show("Select a valid student ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed: " + ex.Message);
            }
        }

        private void Students_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && Students_dataGridView.Rows[e.RowIndex].Cells["StudentID"].Value != null)
            {
                var row = Students_dataGridView.Rows[e.RowIndex];
                StudentID_textBox.Text = row.Cells["StudentID"].Value.ToString();
                StudentName_textBox.Text = row.Cells["Name"].Value.ToString();
                Course_comboBox.Text = row.Cells["Course"].Value.ToString();
            }
        }
    }
}
