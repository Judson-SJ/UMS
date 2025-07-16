namespace UMS.Views
{
    partial class SubjectsForm
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
            SubjectID_textBox = new TextBox();
            Subject_ID_label = new Label();
            SubjectName_textBox = new TextBox();
            Subject_label = new Label();
            Lecture_label = new Label();
            Subjects_dataGridView = new DataGridView();
            Delete_button = new Button();
            Add_button = new Button();
            Update_button = new Button();
            Course_label = new Label();
            Course_comboBox = new ComboBox();
            Lecture_comboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)Subjects_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // SubjectID_textBox
            // 
            SubjectID_textBox.Location = new Point(113, 19);
            SubjectID_textBox.Name = "SubjectID_textBox";
            SubjectID_textBox.Size = new Size(243, 27);
            SubjectID_textBox.TabIndex = 31;
            // 
            // Subject_ID_label
            // 
            Subject_ID_label.AutoSize = true;
            Subject_ID_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Subject_ID_label.Location = new Point(26, 23);
            Subject_ID_label.Name = "Subject_ID_label";
            Subject_ID_label.Size = new Size(86, 17);
            Subject_ID_label.TabIndex = 30;
            Subject_ID_label.Text = "Subject ID :";
            // 
            // SubjectName_textBox
            // 
            SubjectName_textBox.Location = new Point(447, 19);
            SubjectName_textBox.Name = "SubjectName_textBox";
            SubjectName_textBox.Size = new Size(327, 27);
            SubjectName_textBox.TabIndex = 29;
            // 
            // Subject_label
            // 
            Subject_label.AutoSize = true;
            Subject_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Subject_label.Location = new Point(378, 23);
            Subject_label.Name = "Subject_label";
            Subject_label.Size = new Size(65, 17);
            Subject_label.TabIndex = 28;
            Subject_label.Text = "Subject :";
            // 
            // Lecture_label
            // 
            Lecture_label.AutoSize = true;
            Lecture_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lecture_label.Location = new Point(45, 77);
            Lecture_label.Name = "Lecture_label";
            Lecture_label.Size = new Size(69, 17);
            Lecture_label.TabIndex = 26;
            Lecture_label.Text = "Lecture :";
            // 
            // Subjects_dataGridView
            // 
            Subjects_dataGridView.BackgroundColor = SystemColors.ControlLight;
            Subjects_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Subjects_dataGridView.Location = new Point(72, 229);
            Subjects_dataGridView.Name = "Subjects_dataGridView";
            Subjects_dataGridView.RowHeadersWidth = 51;
            Subjects_dataGridView.Size = new Size(643, 192);
            Subjects_dataGridView.TabIndex = 35;
            // 
            // Delete_button
            // 
            Delete_button.BackColor = SystemColors.WindowFrame;
            Delete_button.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Delete_button.ForeColor = SystemColors.ButtonFace;
            Delete_button.Location = new Point(507, 152);
            Delete_button.Name = "Delete_button";
            Delete_button.Size = new Size(81, 29);
            Delete_button.TabIndex = 34;
            Delete_button.Text = "Delete";
            Delete_button.UseVisualStyleBackColor = false;
            // 
            // Add_button
            // 
            Add_button.BackColor = SystemColors.GrayText;
            Add_button.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add_button.ForeColor = SystemColors.ButtonFace;
            Add_button.Location = new Point(261, 152);
            Add_button.Name = "Add_button";
            Add_button.Size = new Size(81, 29);
            Add_button.TabIndex = 32;
            Add_button.Text = "Add";
            Add_button.UseVisualStyleBackColor = false;
            // 
            // Update_button
            // 
            Update_button.BackColor = SystemColors.WindowFrame;
            Update_button.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Update_button.ForeColor = SystemColors.ButtonFace;
            Update_button.Location = new Point(384, 152);
            Update_button.Name = "Update_button";
            Update_button.Size = new Size(81, 29);
            Update_button.TabIndex = 33;
            Update_button.Text = "Update";
            Update_button.UseVisualStyleBackColor = false;
            // 
            // Course_label
            // 
            Course_label.AutoSize = true;
            Course_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Course_label.Location = new Point(381, 77);
            Course_label.Name = "Course_label";
            Course_label.Size = new Size(65, 17);
            Course_label.TabIndex = 36;
            Course_label.Text = "Course :";
            // 
            // Course_comboBox
            // 
            Course_comboBox.FormattingEnabled = true;
            Course_comboBox.Location = new Point(447, 73);
            Course_comboBox.Margin = new Padding(3, 4, 3, 4);
            Course_comboBox.Name = "Course_comboBox";
            Course_comboBox.Size = new Size(268, 28);
            Course_comboBox.TabIndex = 37;
            // 
            // Lecture_comboBox
            // 
            Lecture_comboBox.FormattingEnabled = true;
            Lecture_comboBox.Location = new Point(113, 73);
            Lecture_comboBox.Margin = new Padding(3, 4, 3, 4);
            Lecture_comboBox.Name = "Lecture_comboBox";
            Lecture_comboBox.Size = new Size(243, 28);
            Lecture_comboBox.TabIndex = 38;
            // 
            // SubjectsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 455);
            Controls.Add(Lecture_comboBox);
            Controls.Add(Course_comboBox);
            Controls.Add(Course_label);
            Controls.Add(Subjects_dataGridView);
            Controls.Add(Delete_button);
            Controls.Add(Add_button);
            Controls.Add(Update_button);
            Controls.Add(SubjectID_textBox);
            Controls.Add(Subject_ID_label);
            Controls.Add(SubjectName_textBox);
            Controls.Add(Subject_label);
            Controls.Add(Lecture_label);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "SubjectsForm";
            Text = "SubjectsForm";
            ((System.ComponentModel.ISupportInitialize)Subjects_dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SubjectID_textBox;
        private Label Subject_ID_label;
        private TextBox SubjectName_textBox;
        private Label Subject_label;
        private Label Lecture_label;
        private DataGridView Subjects_dataGridView;
        private Button Delete_button;
        private Button Add_button;
        private Button Update_button;
        private Label Course_label;
        private ComboBox Course_comboBox;
        private ComboBox Lecture_comboBox;
    }
}