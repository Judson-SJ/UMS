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
    public partial class ExamForm : Form
    {
        private ExamController _controller;

        public ExamForm()
        {
            InitializeComponent();
            _controller = new ExamController("Data Source=UMS_DB.db;Version=3;");
            LoadExams();
            LoadSubjectIDs();

            Add_button.Click += Add_button_Click;
            Update_button.Click += Update_button_Click;
            Delete_button.Click += Delete_button_Click;
            Exams_dataGridView.CellClick += Exams_dataGridView_CellClick;
        }

        private void LoadExams()
        {
            Exams_dataGridView.DataSource = _controller.GetAllExams();
        }

        private void LoadSubjectIDs()
        {
            using (var conn = new SQLiteConnection("Data Source=UMS_DB.db;Version=3;"))
            {
                conn.Open();
                using (var cmd = new SQLiteCommand("SELECT SubjectID FROM Subjects", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    SubjectID_comboBox.Items.Clear();
                    while (reader.Read())
                    {
                        SubjectID_comboBox.Items.Add(reader["SubjectID"].ToString());
                    }
                }
            }
        }

        private void ClearFields()
        {
            ExamID_textBox.Text = "";
            ExamName_textBox.Text = "";
            SubjectID_comboBox.SelectedIndex = -1;
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            try
            {
                string name = ExamName_textBox.Text;
                if (int.TryParse(SubjectID_comboBox.Text, out int subjectId))
                {
                    _controller.AddExam(name, subjectId);
                    MessageBox.Show("Exam added.");
                    LoadExams();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Select a valid Subject ID.");
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
                if (int.TryParse(ExamID_textBox.Text, out int examId) &&
                    int.TryParse(SubjectID_comboBox.Text, out int subjectId))
                {
                    string name = ExamName_textBox.Text;
                    _controller.UpdateExam(examId, name, subjectId);
                    MessageBox.Show("Exam updated.");
                    LoadExams();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Select a valid Exam ID and Subject ID.");
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
                if (int.TryParse(ExamID_textBox.Text, out int examId))
                {
                    _controller.DeleteExam(examId);
                    MessageBox.Show("Exam deleted.");
                    LoadExams();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Select a valid Exam ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed: " + ex.Message);
            }
        }

        private void Exams_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = Exams_dataGridView.Rows[e.RowIndex];
                ExamID_textBox.Text = row.Cells["ExamID"].Value.ToString();
                ExamName_textBox.Text = row.Cells["Name"].Value.ToString();
                SubjectID_comboBox.Text = row.Cells["SubjectID"].Value.ToString();
            }
        }
    }
}
