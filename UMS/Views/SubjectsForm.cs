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
    public partial class SubjectsForm : Form
    {
        private SubjectController _controller;

        public SubjectsForm()
        {
            InitializeComponent();
            _controller = new SubjectController("Data Source=UMS_DB.db;Version=3;");
            LoadSubjects();
            LoadCourses();
            LoadLecturers();

            Add_button.Click += Add_button_Click;
            Update_button.Click += Update_button_Click;
            Delete_button.Click += Delete_button_Click;
            Subjects_dataGridView.CellClick += Subjects_dataGridView_CellClick;
        }

        private void LoadSubjects()
        {
            Subjects_dataGridView.DataSource = _controller.GetAllSubjects();
        }

        private void LoadCourses()
        {
            using (var conn = new SQLiteConnection("Data Source=UMS_DB.db;Version=3;"))
            {
                conn.Open();
                var cmd = new SQLiteCommand("SELECT CourseID, Name FROM Courses", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    Course_comboBox.Items.Clear();
                    while (reader.Read())
                    {
                        Course_comboBox.Items.Add(new ComboBoxItem
                        {
                            Text = reader["Name"].ToString(),
                            Value = reader["CourseID"].ToString()
                        });
                    }
                }
            }
        }

        private void LoadLecturers()
        {
            using (var conn = new SQLiteConnection("Data Source=UMS_DB.db;Version=3;"))
            {
                conn.Open();
                var cmd = new SQLiteCommand("SELECT LectureID, Name FROM Lecturers", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    Lecture_comboBox.Items.Clear();
                    while (reader.Read())
                    {
                        Lecture_comboBox.Items.Add(new ComboBoxItem
                        {
                            Text = reader["Name"].ToString(),
                            Value = reader["LectureID"].ToString()
                        });
                    }
                }
            }
        }

        private void ClearFields()
        {
            SubjectID_textBox.Text = "";
            SubjectName_textBox.Text = "";
            Course_comboBox.SelectedIndex = -1;
            Lecture_comboBox.SelectedIndex = -1;
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedCourse = Course_comboBox.SelectedItem as ComboBoxItem;
                var selectedLecture = Lecture_comboBox.SelectedItem as ComboBoxItem;

                if (selectedCourse != null && selectedLecture != null)
                {
                    string name = SubjectName_textBox.Text;
                    int courseId = int.Parse(selectedCourse.Value);
                    int lectureId = int.Parse(selectedLecture.Value);

                    _controller.AddSubject(name, courseId, lectureId);
                    MessageBox.Show("Subject added.");
                    LoadSubjects();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Please select valid Course and Lecturer.");
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
                var selectedCourse = Course_comboBox.SelectedItem as ComboBoxItem;
                var selectedLecture = Lecture_comboBox.SelectedItem as ComboBoxItem;

                if (int.TryParse(SubjectID_textBox.Text, out int subjectId) &&
                    selectedCourse != null && selectedLecture != null)
                {
                    string name = SubjectName_textBox.Text;
                    int courseId = int.Parse(selectedCourse.Value);
                    int lectureId = int.Parse(selectedLecture.Value);

                    _controller.UpdateSubject(subjectId, name, courseId, lectureId);
                    MessageBox.Show("Subject updated.");
                    LoadSubjects();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Please enter valid Subject ID and select Course and Lecturer.");
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
                if (int.TryParse(SubjectID_textBox.Text, out int subjectId))
                {
                    _controller.DeleteSubject(subjectId);
                    MessageBox.Show("Subject deleted.");
                    LoadSubjects();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Please enter valid Subject ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed: " + ex.Message);
            }
        }

        private void Subjects_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = Subjects_dataGridView.Rows[e.RowIndex];
                SubjectID_textBox.Text = row.Cells["SubjectID"].Value.ToString();
                SubjectName_textBox.Text = row.Cells["Name"].Value.ToString();
                Course_comboBox.Text = row.Cells["CourseID"].Value.ToString();
                Lecture_comboBox.Text = row.Cells["LectureID"].Value.ToString();
            }
        }

        private class ComboBoxItem
        {
            public string Text { get; set; }
            public string Value { get; set; }
            public override string ToString() => Text;
        }
    }
}
