namespace UMS.Views
{
    partial class MarksForm
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
            Marks_dataGridView = new DataGridView();
            Delete_button = new Button();
            Update_button = new Button();
            Add_button = new Button();
            MarksID_textBox = new TextBox();
            MarksID_label = new Label();
            ExamID_label = new Label();
            Score_label = new Label();
            StudentID_label = new Label();
            Score_textBox = new TextBox();
            Grade_label = new Label();
            ExamID_comboBox = new ComboBox();
            Grade_comboBox = new ComboBox();
            StudentID_comboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)Marks_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // Marks_dataGridView
            // 
            Marks_dataGridView.BackgroundColor = SystemColors.ControlLight;
            Marks_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Marks_dataGridView.Location = new Point(14, 221);
            Marks_dataGridView.Name = "Marks_dataGridView";
            Marks_dataGridView.RowHeadersWidth = 51;
            Marks_dataGridView.Size = new Size(776, 212);
            Marks_dataGridView.TabIndex = 40;
            // 
            // Delete_button
            // 
            Delete_button.BackColor = SystemColors.WindowFrame;
            Delete_button.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Delete_button.ForeColor = SystemColors.ButtonFace;
            Delete_button.Location = new Point(481, 141);
            Delete_button.Name = "Delete_button";
            Delete_button.Size = new Size(81, 30);
            Delete_button.TabIndex = 39;
            Delete_button.Text = "Delete";
            Delete_button.UseVisualStyleBackColor = false;
            // 
            // Update_button
            // 
            Update_button.BackColor = SystemColors.WindowFrame;
            Update_button.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Update_button.ForeColor = SystemColors.ButtonFace;
            Update_button.Location = new Point(357, 141);
            Update_button.Name = "Update_button";
            Update_button.Size = new Size(81, 30);
            Update_button.TabIndex = 38;
            Update_button.Text = "Update";
            Update_button.UseVisualStyleBackColor = false;
            // 
            // Add_button
            // 
            Add_button.BackColor = SystemColors.GrayText;
            Add_button.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add_button.ForeColor = SystemColors.ButtonFace;
            Add_button.Location = new Point(234, 141);
            Add_button.Name = "Add_button";
            Add_button.Size = new Size(81, 30);
            Add_button.TabIndex = 37;
            Add_button.Text = "Add";
            Add_button.UseVisualStyleBackColor = false;
            // 
            // MarksID_textBox
            // 
            MarksID_textBox.Location = new Point(102, 19);
            MarksID_textBox.Name = "MarksID_textBox";
            MarksID_textBox.Size = new Size(110, 27);
            MarksID_textBox.TabIndex = 36;
            // 
            // MarksID_label
            // 
            MarksID_label.AutoSize = true;
            MarksID_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MarksID_label.Location = new Point(14, 24);
            MarksID_label.Name = "MarksID_label";
            MarksID_label.Size = new Size(82, 17);
            MarksID_label.TabIndex = 35;
            MarksID_label.Text = "Marks ID :";
            // 
            // ExamID_label
            // 
            ExamID_label.AutoSize = true;
            ExamID_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExamID_label.Location = new Point(240, 24);
            ExamID_label.Name = "ExamID_label";
            ExamID_label.Size = new Size(75, 17);
            ExamID_label.TabIndex = 32;
            ExamID_label.Text = "Exam ID :";
            // 
            // Score_label
            // 
            Score_label.AutoSize = true;
            Score_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Score_label.Location = new Point(42, 72);
            Score_label.Name = "Score_label";
            Score_label.Size = new Size(54, 17);
            Score_label.TabIndex = 31;
            Score_label.Text = "Score :";
            // 
            // StudentID_label
            // 
            StudentID_label.AutoSize = true;
            StudentID_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StudentID_label.Location = new Point(457, 24);
            StudentID_label.Name = "StudentID_label";
            StudentID_label.Size = new Size(88, 17);
            StudentID_label.TabIndex = 41;
            StudentID_label.Text = "Student ID :";
            // 
            // Score_textBox
            // 
            Score_textBox.Location = new Point(102, 67);
            Score_textBox.Name = "Score_textBox";
            Score_textBox.Size = new Size(110, 27);
            Score_textBox.TabIndex = 34;
            // 
            // Grade_label
            // 
            Grade_label.AutoSize = true;
            Grade_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Grade_label.Location = new Point(258, 72);
            Grade_label.Name = "Grade_label";
            Grade_label.Size = new Size(57, 17);
            Grade_label.TabIndex = 43;
            Grade_label.Text = "Grade :";
            // 
            // ExamID_comboBox
            // 
            ExamID_comboBox.FormattingEnabled = true;
            ExamID_comboBox.Location = new Point(321, 19);
            ExamID_comboBox.Name = "ExamID_comboBox";
            ExamID_comboBox.Size = new Size(117, 28);
            ExamID_comboBox.TabIndex = 45;
            // 
            // Grade_comboBox
            // 
            Grade_comboBox.FormattingEnabled = true;
            Grade_comboBox.Items.AddRange(new object[] { "A", "B", "C", "S", "F" });
            Grade_comboBox.Location = new Point(321, 67);
            Grade_comboBox.Name = "Grade_comboBox";
            Grade_comboBox.Size = new Size(117, 28);
            Grade_comboBox.TabIndex = 46;
            // 
            // StudentID_comboBox
            // 
            StudentID_comboBox.FormattingEnabled = true;
            StudentID_comboBox.Location = new Point(551, 19);
            StudentID_comboBox.Name = "StudentID_comboBox";
            StudentID_comboBox.Size = new Size(117, 28);
            StudentID_comboBox.TabIndex = 47;
            // 
            // MarksForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(StudentID_comboBox);
            Controls.Add(Grade_comboBox);
            Controls.Add(ExamID_comboBox);
            Controls.Add(Grade_label);
            Controls.Add(StudentID_label);
            Controls.Add(Marks_dataGridView);
            Controls.Add(Delete_button);
            Controls.Add(Update_button);
            Controls.Add(Add_button);
            Controls.Add(MarksID_textBox);
            Controls.Add(MarksID_label);
            Controls.Add(Score_textBox);
            Controls.Add(ExamID_label);
            Controls.Add(Score_label);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MarksForm";
            Text = "Marks";
            Load += MarksForm_Load;
            ((System.ComponentModel.ISupportInitialize)Marks_dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Marks_dataGridView;
        private Button Delete_button;
        private Button Update_button;
        private Button Add_button;
        private TextBox MarksID_textBox;
        private Label MarksID_label;
        private Label ExamID_label;
        private Label Score_label;
        private Label StudentID_label;
        private TextBox Score_textBox;
        private Label Grade_label;
        private ComboBox ExamID_comboBox;
        private ComboBox Grade_comboBox;
        private ComboBox StudentID_comboBox;
    }
}