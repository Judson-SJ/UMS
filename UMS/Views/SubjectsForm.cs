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
    public partial class SubjectsForm : Form
    {
        private SubjectController _controller;

        public SubjectsForm()
        {
            InitializeComponent();
            _controller = new SubjectController("Data Source=UMS_DB.db;Version=3;");
            LoadSubjects();
            button1.Click += Add_button_Click;
            Update_button.Click += Update_button_Click;
            Delete_button.Click += Delete_button_Click;
            Subjects_dataGridView.CellClick += Subjects_dataGridView_CellClick;

            Course_comboBox.Items.Add("1");
            Course_comboBox.Items.Add("2");
            Lecture_comboBox.Items.Add("1");
            Lecture_comboBox.Items.Add("2");
        }

        private void LoadSubjects()
        {
            Subjects_dataGridView.DataSource = _controller.GetAllSubjects();
        }

        private void ClearFields()
        {
            Subject_ID_textBox.Text = "";
            Subject_textBox.Text = "";
            Course_comboBox.SelectedIndex = -1;
            Lecture_comboBox.SelectedIndex = -1;
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            try
            {
                string name = Subject_textBox.Text;
                if (int.TryParse(Course_comboBox.Text, out int courseId))
                {
                    _controller.AddSubject(name, courseId);
                    MessageBox.Show("Subject added.");
                    LoadSubjects();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Select a valid Course ID.");
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
                if (int.TryParse(Subject_ID_textBox.Text, out int subjectId) &&
                    int.TryParse(Course_comboBox.Text, out int courseId))
                {
                    string name = Subject_textBox.Text;
                    _controller.UpdateSubject(subjectId, name, courseId);
                    MessageBox.Show("Subject updated.");
                    LoadSubjects();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Please enter valid Subject ID and Course ID.");
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
                if (int.TryParse(Subject_ID_textBox.Text, out int subjectId))
                {
                    _controller.DeleteSubject(subjectId);
                    MessageBox.Show("Subject deleted.");
                    LoadSubjects();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Please enter a valid Subject ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed: " + ex.Message);
            }
        }

        private void Subjects_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && Subjects_dataGridView.Rows[e.RowIndex].Cells["SubjectID"].Value != null)
            {
                var row = Subjects_dataGridView.Rows[e.RowIndex];
                Subject_ID_textBox.Text = row.Cells["SubjectID"].Value.ToString();
                Subject_textBox.Text = row.Cells["SubjectName"].Value.ToString();
                Course_comboBox.Text = row.Cells["CourseID"].Value.ToString();
            }
        }
    }
}
