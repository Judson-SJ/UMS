﻿namespace UMS.Views
{
    partial class LecturersForm
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
            Lecturers_dataGridView = new DataGridView();
            Delete_button = new Button();
            Update_button = new Button();
            Add_button = new Button();
            Address_textBox = new TextBox();
            Name_textBox = new TextBox();
            LectureID_textBox = new TextBox();
            Address_label = new Label();
            Name_label = new Label();
            LectureID_label = new Label();
            PhoneNo_label = new Label();
            PhoneNo_textBox = new TextBox();
            UserIDcomboBox = new ComboBox();
            UserIDlabel = new Label();
            ((System.ComponentModel.ISupportInitialize)Lecturers_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // Lecturers_dataGridView
            // 
            Lecturers_dataGridView.BackgroundColor = SystemColors.ControlLight;
            Lecturers_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Lecturers_dataGridView.Location = new Point(12, 249);
            Lecturers_dataGridView.Name = "Lecturers_dataGridView";
            Lecturers_dataGridView.RowHeadersWidth = 51;
            Lecturers_dataGridView.Size = new Size(776, 177);
            Lecturers_dataGridView.TabIndex = 19;
            // 
            // Delete_button
            // 
            Delete_button.BackColor = SystemColors.WindowFrame;
            Delete_button.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Delete_button.ForeColor = SystemColors.ButtonFace;
            Delete_button.Location = new Point(462, 201);
            Delete_button.Name = "Delete_button";
            Delete_button.Size = new Size(81, 30);
            Delete_button.TabIndex = 18;
            Delete_button.Text = "Delete";
            Delete_button.UseVisualStyleBackColor = false;
            // 
            // Update_button
            // 
            Update_button.BackColor = SystemColors.WindowFrame;
            Update_button.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Update_button.ForeColor = SystemColors.ButtonFace;
            Update_button.Location = new Point(338, 201);
            Update_button.Name = "Update_button";
            Update_button.Size = new Size(81, 30);
            Update_button.TabIndex = 17;
            Update_button.Text = "Update";
            Update_button.UseVisualStyleBackColor = false;
            // 
            // Add_button
            // 
            Add_button.BackColor = SystemColors.GrayText;
            Add_button.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add_button.ForeColor = SystemColors.ButtonFace;
            Add_button.Location = new Point(215, 201);
            Add_button.Name = "Add_button";
            Add_button.Size = new Size(81, 30);
            Add_button.TabIndex = 16;
            Add_button.Text = "Add";
            Add_button.UseVisualStyleBackColor = false;
            // 
            // Address_textBox
            // 
            Address_textBox.Location = new Point(372, 80);
            Address_textBox.Name = "Address_textBox";
            Address_textBox.Size = new Size(416, 27);
            Address_textBox.TabIndex = 15;
            // 
            // Name_textBox
            // 
            Name_textBox.Location = new Point(372, 25);
            Name_textBox.Name = "Name_textBox";
            Name_textBox.Size = new Size(416, 27);
            Name_textBox.TabIndex = 14;
            // 
            // LectureID_textBox
            // 
            LectureID_textBox.Location = new Point(105, 25);
            LectureID_textBox.Name = "LectureID_textBox";
            LectureID_textBox.Size = new Size(168, 27);
            LectureID_textBox.TabIndex = 13;
            // 
            // Address_label
            // 
            Address_label.AutoSize = true;
            Address_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Address_label.Location = new Point(294, 85);
            Address_label.Name = "Address_label";
            Address_label.Size = new Size(72, 17);
            Address_label.TabIndex = 12;
            Address_label.Text = "Address :";
            // 
            // Name_label
            // 
            Name_label.AutoSize = true;
            Name_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name_label.Location = new Point(311, 30);
            Name_label.Name = "Name_label";
            Name_label.Size = new Size(55, 17);
            Name_label.TabIndex = 11;
            Name_label.Text = "Name :";
            // 
            // LectureID_label
            // 
            LectureID_label.AutoSize = true;
            LectureID_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LectureID_label.Location = new Point(11, 30);
            LectureID_label.Name = "LectureID_label";
            LectureID_label.Size = new Size(90, 17);
            LectureID_label.TabIndex = 10;
            LectureID_label.Text = "Lecture ID :";
            // 
            // PhoneNo_label
            // 
            PhoneNo_label.AutoSize = true;
            PhoneNo_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PhoneNo_label.Location = new Point(285, 140);
            PhoneNo_label.Name = "PhoneNo_label";
            PhoneNo_label.Size = new Size(81, 17);
            PhoneNo_label.TabIndex = 20;
            PhoneNo_label.Text = "Phone No :";
            // 
            // PhoneNo_textBox
            // 
            PhoneNo_textBox.Location = new Point(372, 135);
            PhoneNo_textBox.Name = "PhoneNo_textBox";
            PhoneNo_textBox.Size = new Size(168, 27);
            PhoneNo_textBox.TabIndex = 21;
            // 
            // UserIDcomboBox
            // 
            UserIDcomboBox.FormattingEnabled = true;
            UserIDcomboBox.Location = new Point(105, 79);
            UserIDcomboBox.Name = "UserIDcomboBox";
            UserIDcomboBox.Size = new Size(168, 28);
            UserIDcomboBox.TabIndex = 45;
            // 
            // UserIDlabel
            // 
            UserIDlabel.AutoSize = true;
            UserIDlabel.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserIDlabel.Location = new Point(29, 85);
            UserIDlabel.Name = "UserIDlabel";
            UserIDlabel.Size = new Size(70, 17);
            UserIDlabel.TabIndex = 44;
            UserIDlabel.Text = "User ID :";
            // 
            // LecturersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(UserIDcomboBox);
            Controls.Add(UserIDlabel);
            Controls.Add(PhoneNo_textBox);
            Controls.Add(PhoneNo_label);
            Controls.Add(Lecturers_dataGridView);
            Controls.Add(Delete_button);
            Controls.Add(Update_button);
            Controls.Add(Add_button);
            Controls.Add(Address_textBox);
            Controls.Add(Name_textBox);
            Controls.Add(LectureID_textBox);
            Controls.Add(Address_label);
            Controls.Add(Name_label);
            Controls.Add(LectureID_label);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LecturersForm";
            Text = "Lecturers";
            ((System.ComponentModel.ISupportInitialize)Lecturers_dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Lecturers_dataGridView;
        private Button Delete_button;
        private Button Update_button;
        private Button Add_button;
        private TextBox Address_textBox;
        private TextBox Name_textBox;
        private TextBox LectureID_textBox;
        private Label Address_label;
        private Label Name_label;
        private Label LectureID_label;
        private Label PhoneNo_label;
        private TextBox PhoneNo_textBox;
        private ComboBox UserIDcomboBox;
        private Label UserIDlabel;
    }
}