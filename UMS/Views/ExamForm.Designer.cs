namespace UMS.Views
{
    partial class ExamForm
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
            ExamName_textBox = new TextBox();
            SubjectID_label = new Label();
            dataGridView1 = new DataGridView();
            Delete_button = new Button();
            Update_button = new Button();
            Add_button = new Button();
            ExamID_textBox = new TextBox();
            ExamName_label = new Label();
            SubjectID_textBox = new TextBox();
            ExamID_label = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ExamName_textBox
            // 
            ExamName_textBox.Location = new Point(334, 18);
            ExamName_textBox.Name = "ExamName_textBox";
            ExamName_textBox.Size = new Size(204, 27);
            ExamName_textBox.TabIndex = 57;
            // 
            // SubjectID_label
            // 
            SubjectID_label.AutoSize = true;
            SubjectID_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubjectID_label.Location = new Point(558, 23);
            SubjectID_label.Name = "SubjectID_label";
            SubjectID_label.Size = new Size(86, 17);
            SubjectID_label.TabIndex = 56;
            SubjectID_label.Text = "Subject ID :";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 220);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 212);
            dataGridView1.TabIndex = 55;
            // 
            // Delete_button
            // 
            Delete_button.BackColor = SystemColors.WindowFrame;
            Delete_button.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Delete_button.ForeColor = SystemColors.ButtonFace;
            Delete_button.Location = new Point(460, 85);
            Delete_button.Name = "Delete_button";
            Delete_button.Size = new Size(81, 30);
            Delete_button.TabIndex = 54;
            Delete_button.Text = "Delete";
            Delete_button.UseVisualStyleBackColor = false;
            // 
            // Update_button
            // 
            Update_button.BackColor = SystemColors.WindowFrame;
            Update_button.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Update_button.ForeColor = SystemColors.ButtonFace;
            Update_button.Location = new Point(336, 85);
            Update_button.Name = "Update_button";
            Update_button.Size = new Size(81, 30);
            Update_button.TabIndex = 53;
            Update_button.Text = "Update";
            Update_button.UseVisualStyleBackColor = false;
            // 
            // Add_button
            // 
            Add_button.BackColor = SystemColors.GrayText;
            Add_button.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add_button.ForeColor = SystemColors.ButtonFace;
            Add_button.Location = new Point(213, 85);
            Add_button.Name = "Add_button";
            Add_button.Size = new Size(81, 30);
            Add_button.TabIndex = 52;
            Add_button.Text = "Add";
            Add_button.UseVisualStyleBackColor = false;
            // 
            // ExamID_textBox
            // 
            ExamID_textBox.Location = new Point(100, 18);
            ExamID_textBox.Name = "ExamID_textBox";
            ExamID_textBox.Size = new Size(110, 27);
            ExamID_textBox.TabIndex = 51;
            // 
            // ExamName_label
            // 
            ExamName_label.AutoSize = true;
            ExamName_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExamName_label.Location = new Point(232, 23);
            ExamName_label.Name = "ExamName_label";
            ExamName_label.Size = new Size(96, 17);
            ExamName_label.TabIndex = 50;
            ExamName_label.Text = "Exam Name :";
            ExamName_label.Click += ExamName_label_Click;
            // 
            // SubjectID_textBox
            // 
            SubjectID_textBox.Location = new Point(650, 18);
            SubjectID_textBox.Name = "SubjectID_textBox";
            SubjectID_textBox.Size = new Size(110, 27);
            SubjectID_textBox.TabIndex = 47;
            // 
            // ExamID_label
            // 
            ExamID_label.AutoSize = true;
            ExamID_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExamID_label.Location = new Point(19, 23);
            ExamID_label.Name = "ExamID_label";
            ExamID_label.Size = new Size(75, 17);
            ExamID_label.TabIndex = 46;
            ExamID_label.Text = "Exam ID :";
            // 
            // ExamForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ExamName_textBox);
            Controls.Add(SubjectID_label);
            Controls.Add(dataGridView1);
            Controls.Add(Delete_button);
            Controls.Add(Update_button);
            Controls.Add(Add_button);
            Controls.Add(ExamID_textBox);
            Controls.Add(ExamName_label);
            Controls.Add(SubjectID_textBox);
            Controls.Add(ExamID_label);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ExamForm";
            Text = "Exam";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox ExamName_textBox;
        private Label SubjectID_label;
        private DataGridView dataGridView1;
        private Button Delete_button;
        private Button Update_button;
        private Button Add_button;
        private TextBox ExamID_textBox;
        private Label ExamName_label;
        private TextBox SubjectID_textBox;
        private Label ExamID_label;
    }
}