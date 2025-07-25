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
    public partial class TimeTableForm : Form
    {
        private TimetableController _controller;

        public TimeTableForm()
        {
            InitializeComponent();
            _controller = new TimetableController("Data Source=UMS_DB.db;Version=3;");
            LoadTimeTable();
            LoadComboBoxes();

            Add_button.Click += Add_button_Click;
            Update_button.Click += Update_button_Click;
            Delete_button.Click += Delete_button_Click;
            TimeTable_dataGridView.CellClick += TimeTable_dataGridView_CellClick;
        }

        private void LoadTimeTable()
        {
            TimeTable_dataGridView.DataSource = _controller.GetAllTimetables();
        }

        private void LoadComboBoxes()
        {
            using var conn = new SQLiteConnection("Data Source=UMS_DB.db;Version=3;");
            conn.Open();

            using var cmdSubjects = new SQLiteCommand("SELECT SubjectID FROM Subjects", conn);
            using var reader1 = cmdSubjects.ExecuteReader();
            while (reader1.Read()) SubjectID_comboBox.Items.Add(reader1["SubjectID"].ToString());

            using var cmdRooms = new SQLiteCommand("SELECT RoomID FROM Rooms", conn);
            using var reader2 = cmdRooms.ExecuteReader();
            while (reader2.Read()) RoomID_comboBox.Items.Add(reader2["RoomID"].ToString());

            using var cmdLecturers = new SQLiteCommand("SELECT LectureID FROM Lecturers", conn);
            using var reader3 = cmdLecturers.ExecuteReader();
            while (reader3.Read()) LectureID_comboBox.Items.Add(reader3["LectureID"].ToString());
        }

        private void ClearFields()
        {
            TimeTableID_textBox.Text = "";
            SubjectID_comboBox.SelectedIndex = -1;
            LectureID_comboBox.SelectedIndex = -1;
            DateTimePicker.Text = "";
            TimeSlot_comboBox.Text = "";
            RoomID_comboBox.SelectedIndex = -1;
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(SubjectID_comboBox.Text, out int subjectId) &&
                    int.TryParse(LectureID_comboBox.Text, out int lectureId) &&
                    int.TryParse(RoomID_comboBox.Text, out int roomId))
                {
                    string date = DateTimePicker.Text;
                    string timeSlot = TimeSlot_comboBox.Text;

                    _controller.AddTimetable(subjectId, lectureId, date, timeSlot, roomId);
                    MessageBox.Show("Timetable added.");
                    LoadTimeTable();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Please provide valid numeric IDs.");
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
                if (int.TryParse(TimeTableID_textBox.Text, out int timetableId) &&
                    int.TryParse(SubjectID_comboBox.Text, out int subjectId) &&
                    int.TryParse(LectureID_comboBox.Text, out int lectureId) &&
                    int.TryParse(RoomID_comboBox.Text, out int roomId))
                {
                    string date = DateTimePicker.Text;
                    string timeSlot = TimeSlot_comboBox.Text;

                    _controller.UpdateTimetable(timetableId, subjectId, lectureId, date, timeSlot, roomId);
                    MessageBox.Show("Timetable updated.");
                    LoadTimeTable();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Please provide valid numeric IDs.");
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
                if (int.TryParse(TimeTableID_textBox.Text, out int timetableId))
                {
                    _controller.DeleteTimetable(timetableId);
                    MessageBox.Show("Timetable deleted.");
                    LoadTimeTable();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Enter a valid timetable ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed: " + ex.Message);
            }
        }

        private void TimeTable_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = TimeTable_dataGridView.Rows[e.RowIndex];
                TimeTableID_textBox.Text = row.Cells["TimeTableID"].Value.ToString();
                SubjectID_comboBox.Text = row.Cells["SubjectID"].Value.ToString();
                LectureID_comboBox.Text = row.Cells["LectureID"].Value.ToString();
                DateTimePicker.Text = row.Cells["Date"].Value.ToString();
                TimeSlot_comboBox.Text = row.Cells["TimeSlot"].Value.ToString();
                RoomID_comboBox.Text = row.Cells["RoomID"].Value.ToString();
            }
        }
    }
}
