using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UMS.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadForm(new TimeTableForm());
        }

        public void LoadForm(object formObj)

        {
            if (formObj is not Form form)
            {
                MessageBox.Show("Invalid form passed to LoadForm.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.Main_panel.Controls.Count > 0)
            {
                this.Main_panel.Controls.RemoveAt(0);
            }

            //Form form = formObj as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.Main_panel.Controls.Add(form);
            this.Main_panel.Tag = form;
            form.Show();
        }

        private void TimeTable_button_Click(object sender, EventArgs e)
        {
            LoadForm(new TimeTableForm());
        }

        private void Lecturers_button_Click(object sender, EventArgs e)
        {
            LoadForm(new LecturersForm());
        }

        private void Students_button_Click(object sender, EventArgs e)
        {
            LoadForm(new StudentsForm());
        }

        private void Courses_button_Click(object sender, EventArgs e)
        {
            LoadForm(new CoursesForm());
        }

        private void Rooms_button_Click(object sender, EventArgs e)
        {
            LoadForm(new RoomForm());
        }

        private void Marks_button_Click(object sender, EventArgs e)
        {
            LoadForm(new MarksForm());
        }

        private void Exam_button_Click(object sender, EventArgs e)
        {
            LoadForm(new ExamForm());
        }

        private void Users_button_Click(object sender, EventArgs e)
        {
            LoadForm(new UsersForm());
        }

        private void Staff_button_Click(object sender, EventArgs e)
        {
            LoadForm(new StaffForm());
        }
        private void Subjects_button_Click(object sender, EventArgs e)
        {
            LoadForm(new SubjectsForm());
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
