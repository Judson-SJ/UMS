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
    public partial class MarksForm : Form
    {
        private MarkController _controller;

        public MarksForm()
        {
            InitializeComponent();
            _controller = new MarkController("Data Source=UMS_DB.db;Version=3;");
            LoadMarks();
            LoadComboBoxData();

            Add_button.Click += Add_button_Click;
            Update_button.Click += Update_button_Click;
            Delete_button.Click += Delete_button_Click;
            Marks_dataGridView.CellClick += Marks_dataGridView_CellClick;
        }

        private void LoadMarks()
        {
            Marks_dataGridView.DataSource = _controller.GetAllMarks();
        }

        private void LoadComboBoxData()
        {
            using var conn = new SQLiteConnection("Data Source=UMS_DB.db;Version=3;");
            conn.Open();

            using var examCmd = new SQLiteCommand("SELECT ExamID FROM Exams", conn);
            using var examReader = examCmd.ExecuteReader();
            ExamID_comboBox.Items.Clear();
            while (examReader.Read())
            {
                ExamID_comboBox.Items.Add(examReader["ExamID"].ToString());
            }

            using var studentCmd = new SQLiteCommand("SELECT StudentID FROM Students", conn);
            using var studentReader = studentCmd.ExecuteReader();
            StudentID_comboBox.Items.Clear();
            while (studentReader.Read())
            {
                StudentID_comboBox.Items.Add(studentReader["StudentID"].ToString());
            }
        }

        private void ClearFields()
        {
            MarksID_textBox.Text = "";
            Score_textBox.Text = "";
            Grade_comboBox.Text = "";
            ExamID_comboBox.SelectedIndex = -1;
            StudentID_comboBox.SelectedIndex = -1;
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(Score_textBox.Text, out int score) &&
                    !string.IsNullOrWhiteSpace(Grade_comboBox.Text) &&
                    int.TryParse(ExamID_comboBox.Text, out int examId) &&
                    int.TryParse(StudentID_comboBox.Text, out int studentId))
                {
                    _controller.AddMark(score, examId, studentId, Grade_comboBox.Text);
                    MessageBox.Show("Mark added.");
                    LoadMarks();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Please enter valid score and select IDs.");
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
                if (int.TryParse(MarksID_textBox.Text, out int markId) &&
                    int.TryParse(Score_textBox.Text, out int score) &&
                    int.TryParse(ExamID_comboBox.Text, out int examId) &&
                    int.TryParse(StudentID_comboBox.Text, out int studentId))
                {
                    _controller.UpdateMark(markId, score, examId, studentId, Grade_comboBox.Text);
                    MessageBox.Show("Mark updated.");
                    LoadMarks();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Please enter valid data.");
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
                if (int.TryParse(MarksID_textBox.Text, out int markId))
                {
                    _controller.DeleteMark(markId);
                    MessageBox.Show("Mark deleted.");
                    LoadMarks();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Enter a valid Mark ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed: " + ex.Message);
            }
        }

        private void Marks_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = Marks_dataGridView.Rows[e.RowIndex];
                MarksID_textBox.Text = row.Cells["MarksID"].Value.ToString();
                Score_textBox.Text = row.Cells["Score"].Value.ToString();
                Grade_comboBox.Text = row.Cells["Grade"].Value.ToString();
                ExamID_comboBox.Text = row.Cells["ExamID"].Value.ToString();
                StudentID_comboBox.Text = row.Cells["StudentID"].Value.ToString();
            }
        }
    }
}
