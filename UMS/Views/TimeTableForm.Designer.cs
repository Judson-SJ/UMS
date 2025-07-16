namespace UMS.Views
{
    partial class TimeTableForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DateTimePicker = new DateTimePicker();
            TimeTable_dataGridView = new DataGridView();
            SubjectID_comboBox = new ComboBox();
            SubjectID_label = new Label();
            TimeSlot_comboBox = new ComboBox();
            TimeSlot_label = new Label();
            RoomID_comboBox = new ComboBox();
            RoomID_label = new Label();
            LectureID_comboBox = new ComboBox();
            LectureID_label = new Label();
            Delete_button = new Button();
            Add_button = new Button();
            Update_button = new Button();
            Date_label = new Label();
            ID_label = new Label();
            TimeTableID_textBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)TimeTable_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // DateTimePicker
            // 
            DateTimePicker.Location = new Point(87, 12);
            DateTimePicker.Name = "DateTimePicker";
            DateTimePicker.Size = new Size(156, 27);
            DateTimePicker.TabIndex = 0;
            // 
            // TimeTable_dataGridView
            // 
            TimeTable_dataGridView.BackgroundColor = SystemColors.ControlLight;
            TimeTable_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TimeTable_dataGridView.Location = new Point(12, 226);
            TimeTable_dataGridView.Name = "TimeTable_dataGridView";
            TimeTable_dataGridView.RowHeadersWidth = 51;
            TimeTable_dataGridView.Size = new Size(776, 212);
            TimeTable_dataGridView.TabIndex = 14;
            // 
            // SubjectID_comboBox
            // 
            SubjectID_comboBox.FormattingEnabled = true;
            SubjectID_comboBox.Location = new Point(619, 14);
            SubjectID_comboBox.Margin = new Padding(3, 4, 3, 4);
            SubjectID_comboBox.Name = "SubjectID_comboBox";
            SubjectID_comboBox.Size = new Size(162, 28);
            SubjectID_comboBox.TabIndex = 39;
            // 
            // SubjectID_label
            // 
            SubjectID_label.AutoSize = true;
            SubjectID_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubjectID_label.Location = new Point(528, 19);
            SubjectID_label.Name = "SubjectID_label";
            SubjectID_label.Size = new Size(86, 17);
            SubjectID_label.TabIndex = 38;
            SubjectID_label.Text = "Subject ID :";
            // 
            // TimeSlot_comboBox
            // 
            TimeSlot_comboBox.FormattingEnabled = true;
            TimeSlot_comboBox.Items.AddRange(new object[] { "9.00 am - 10.30 am", "10.30 am - 12.00 pm", "1.00 pm - 2.30 pm", "2.30 pm - 4.00 pm" });
            TimeSlot_comboBox.Location = new Point(347, 13);
            TimeSlot_comboBox.Margin = new Padding(3, 4, 3, 4);
            TimeSlot_comboBox.Name = "TimeSlot_comboBox";
            TimeSlot_comboBox.Size = new Size(162, 28);
            TimeSlot_comboBox.TabIndex = 41;
            // 
            // TimeSlot_label
            // 
            TimeSlot_label.AutoSize = true;
            TimeSlot_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TimeSlot_label.Location = new Point(256, 18);
            TimeSlot_label.Name = "TimeSlot_label";
            TimeSlot_label.Size = new Size(80, 17);
            TimeSlot_label.TabIndex = 40;
            TimeSlot_label.Text = "Time Slot :";
            // 
            // RoomID_comboBox
            // 
            RoomID_comboBox.FormattingEnabled = true;
            RoomID_comboBox.Location = new Point(347, 58);
            RoomID_comboBox.Margin = new Padding(3, 4, 3, 4);
            RoomID_comboBox.Name = "RoomID_comboBox";
            RoomID_comboBox.Size = new Size(162, 28);
            RoomID_comboBox.TabIndex = 43;
            // 
            // RoomID_label
            // 
            RoomID_label.AutoSize = true;
            RoomID_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RoomID_label.Location = new Point(259, 63);
            RoomID_label.Name = "RoomID_label";
            RoomID_label.Size = new Size(77, 17);
            RoomID_label.TabIndex = 42;
            RoomID_label.Text = "Room ID :";
            // 
            // LectureID_comboBox
            // 
            LectureID_comboBox.FormattingEnabled = true;
            LectureID_comboBox.Location = new Point(619, 58);
            LectureID_comboBox.Margin = new Padding(3, 4, 3, 4);
            LectureID_comboBox.Name = "LectureID_comboBox";
            LectureID_comboBox.Size = new Size(162, 28);
            LectureID_comboBox.TabIndex = 45;
            // 
            // LectureID_label
            // 
            LectureID_label.AutoSize = true;
            LectureID_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LectureID_label.Location = new Point(524, 63);
            LectureID_label.Name = "LectureID_label";
            LectureID_label.Size = new Size(90, 17);
            LectureID_label.TabIndex = 44;
            LectureID_label.Text = "Lecture ID :";
            // 
            // Delete_button
            // 
            Delete_button.BackColor = SystemColors.WindowFrame;
            Delete_button.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Delete_button.ForeColor = SystemColors.ButtonFace;
            Delete_button.Location = new Point(476, 125);
            Delete_button.Name = "Delete_button";
            Delete_button.Size = new Size(81, 29);
            Delete_button.TabIndex = 48;
            Delete_button.Text = "Delete";
            Delete_button.UseVisualStyleBackColor = false;
            // 
            // Add_button
            // 
            Add_button.BackColor = SystemColors.GrayText;
            Add_button.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add_button.ForeColor = SystemColors.ButtonFace;
            Add_button.Location = new Point(230, 125);
            Add_button.Name = "Add_button";
            Add_button.Size = new Size(81, 29);
            Add_button.TabIndex = 46;
            Add_button.Text = "Add";
            Add_button.UseVisualStyleBackColor = false;
            // 
            // Update_button
            // 
            Update_button.BackColor = SystemColors.WindowFrame;
            Update_button.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Update_button.ForeColor = SystemColors.ButtonFace;
            Update_button.Location = new Point(353, 125);
            Update_button.Name = "Update_button";
            Update_button.Size = new Size(81, 29);
            Update_button.TabIndex = 47;
            Update_button.Text = "Update";
            Update_button.UseVisualStyleBackColor = false;
            // 
            // Date_label
            // 
            Date_label.AutoSize = true;
            Date_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Date_label.Location = new Point(33, 18);
            Date_label.Name = "Date_label";
            Date_label.Size = new Size(48, 17);
            Date_label.TabIndex = 50;
            Date_label.Text = "Date :";
            // 
            // ID_label
            // 
            ID_label.AutoSize = true;
            ID_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ID_label.Location = new Point(47, 63);
            ID_label.Name = "ID_label";
            ID_label.Size = new Size(34, 17);
            ID_label.TabIndex = 51;
            ID_label.Text = "ID :";
            // 
            // TimeTableID_textBox
            // 
            TimeTableID_textBox.Location = new Point(87, 58);
            TimeTableID_textBox.Name = "TimeTableID_textBox";
            TimeTableID_textBox.Size = new Size(156, 27);
            TimeTableID_textBox.TabIndex = 52;
            // 
            // TimeTableForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 452);
            ControlBox = false;
            Controls.Add(TimeTableID_textBox);
            Controls.Add(ID_label);
            Controls.Add(Date_label);
            Controls.Add(Delete_button);
            Controls.Add(Add_button);
            Controls.Add(Update_button);
            Controls.Add(LectureID_comboBox);
            Controls.Add(LectureID_label);
            Controls.Add(RoomID_comboBox);
            Controls.Add(RoomID_label);
            Controls.Add(TimeSlot_comboBox);
            Controls.Add(TimeSlot_label);
            Controls.Add(SubjectID_comboBox);
            Controls.Add(SubjectID_label);
            Controls.Add(TimeTable_dataGridView);
            Controls.Add(DateTimePicker);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TimeTableForm";
            Text = "Time Table";
            ((System.ComponentModel.ISupportInitialize)TimeTable_dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker DateTimePicker;
        private DataGridView TimeTable_dataGridView;
        private ComboBox SubjectID_comboBox;
        private Label SubjectID_label;
        private ComboBox TimeSlot_comboBox;
        private Label TimeSlot_label;
        private ComboBox RoomID_comboBox;
        private Label RoomID_label;
        private ComboBox LectureID_comboBox;
        private Label LectureID_label;
        private Button Delete_button;
        private Button Add_button;
        private Button Update_button;
        private Label Date_label;
        private Label ID_label;
        private TextBox TimeTableID_textBox;
    }
}