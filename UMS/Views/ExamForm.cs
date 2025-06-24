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
    public partial class ExamForm : Form
    {
        private ExamController _controller;

        public ExamForm()
        {
            InitializeComponent();
            _controller = new ExamController("Data Source=UMS_DB.db;Version=3;");
            LoadExams();
            Add_button.Click += Add_button_Click;
            Update_button.Click += Update_button_Click;
            Delete_button.Click += Delete_button_Click;
            Exams_dataGridView.CellClick += Exams_dataGridView_CellClick;

            // TODO: Replace this with dynamic subject loading
            SubjectID_comboBox.Items.Add("1");
            SubjectID_comboBox.Items.Add("2");
            SubjectID_comboBox.Items.Add("3");
        }

        private void LoadExams()
        {
            Exams_dataGridView.DataSource = _controller.GetAllExams();
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
                string name = ExamName_textBox.Text.Trim();
                if (int.TryParse(SubjectID_comboBox.Text, out int subjectId) && !string.IsNullOrEmpty(name))
                {
                    _controller.AddExam(name, subjectId);
                    MessageBox.Show("Exam added successfully.");
                    LoadExams();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Please provide a valid exam name and subject ID.");
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
                if (int.TryParse(ExamID_textBox.Text, out int examId) &&
                    int.TryParse(SubjectID_comboBox.Text, out int subjectId))
                {
                    string name = ExamName_textBox.Text.Trim();
                    _controller.UpdateExam(examId, name, subjectId);
                    MessageBox.Show("Exam updated successfully.");
                    LoadExams();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Please select a valid exam to update.");
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
                if (int.TryParse(ExamID_textBox.Text, out int examId))
                {
                    _controller.DeleteExam(examId);
                    MessageBox.Show("Exam deleted successfully.");
                    LoadExams();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Please select a valid exam to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Exams_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = Exams_dataGridView.Rows[e.RowIndex];
                ExamID_textBox.Text = row.Cells["ExamID"].Value.ToString();
                ExamName_textBox.Text = row.Cells["ExamName"].Value.ToString();
                SubjectID_comboBox.Text = row.Cells["SubjectID"].Value.ToString();
            }
        }
    }
}
