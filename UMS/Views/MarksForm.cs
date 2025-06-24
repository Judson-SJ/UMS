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
    public partial class MarksForm : Form
    {
        private MarkController _controller;

        public MarksForm()
        {
            InitializeComponent();
            _controller = new MarkController("Data Source=UMS_DB.db;Version=3;");
            LoadMarks();
            Add_button.Click += Add_button_Click;
            Update_button.Click += Update_button_Click;
            Delete_button.Click += Delete_button_Click;
            Marks_dataGridView.CellClick += Marks_dataGridView_CellClick;

            // Static test values (replace with real data later)
            ExamID_comboBox.Items.Add("1");
            ExamID_comboBox.Items.Add("2");
            StudentID_comboBox.Items.Add("1");
            StudentID_comboBox.Items.Add("2");
        }

        private void LoadMarks()
        {
            Marks_dataGridView.DataSource = _controller.GetAllMarks();
        }

        private void ClearFields()
        {
            MarksID_textBox.Text = "";
            ExamID_comboBox.SelectedIndex = -1;
            StudentID_comboBox.SelectedIndex = -1;
            Score_textBox.Text = "";
            Grade_comboBox.SelectedIndex = -1;
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(StudentID_comboBox.Text, out int studentId) &&
                    int.TryParse(ExamID_comboBox.Text, out int examId) &&
                    int.TryParse(Score_textBox.Text, out int score))
                {
                    _controller.AddMark(studentId, examId, score);
                    MessageBox.Show("Mark added successfully.");
                    LoadMarks();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Please enter valid numeric values for IDs and Score.");
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
                if (int.TryParse(MarksID_textBox.Text, out int markId) &&
                    int.TryParse(Score_textBox.Text, out int score))
                {
                    _controller.UpdateMark(markId, score);
                    MessageBox.Show("Mark updated successfully.");
                    LoadMarks();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Please select a valid mark record.");
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
                if (int.TryParse(MarksID_textBox.Text, out int markId))
                {
                    _controller.DeleteMark(markId);
                    MessageBox.Show("Mark deleted successfully.");
                    LoadMarks();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Please select a valid mark record.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Marks_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = Marks_dataGridView.Rows[e.RowIndex];
                MarksID_textBox.Text = row.Cells["MarkID"].Value.ToString();
                Score_textBox.Text = row.Cells["Score"].Value.ToString();
                StudentID_comboBox.Text = row.Cells["StudentID"].Value.ToString();
                ExamID_comboBox.Text = row.Cells["ExamID"].Value.ToString();
                // Grade not handled in DB currently
            }
        }
    }
}
