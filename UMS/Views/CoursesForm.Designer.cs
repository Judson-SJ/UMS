namespace UMS.Views
{
    partial class CoursesForm
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
            Course_label = new Label();
            CourseID_label = new Label();
            CourseID_textBox = new TextBox();
            dataGridView2 = new DataGridView();
            Delete_button = new Button();
            Update_button = new Button();
            button1 = new Button();
            CouseName_textBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // Course_label
            // 
            Course_label.AutoSize = true;
            Course_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Course_label.Location = new Point(12, 17);
            Course_label.Name = "Course_label";
            Course_label.Size = new Size(52, 15);
            Course_label.TabIndex = 0;
            Course_label.Text = "Course :";
            Course_label.Click += Course_label_Click;
            // 
            // CourseID_label
            // 
            CourseID_label.AutoSize = true;
            CourseID_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CourseID_label.Location = new Point(354, 17);
            CourseID_label.Name = "CourseID_label";
            CourseID_label.Size = new Size(68, 15);
            CourseID_label.TabIndex = 2;
            CourseID_label.Text = "Course ID :";
            // 
            // CourseID_textBox
            // 
            CourseID_textBox.Location = new Point(437, 11);
            CourseID_textBox.Margin = new Padding(3, 2, 3, 2);
            CourseID_textBox.Name = "CourseID_textBox";
            CourseID_textBox.Size = new Size(252, 23);
            CourseID_textBox.TabIndex = 4;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.ControlLight;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(10, 144);
            dataGridView2.Margin = new Padding(3, 2, 3, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(679, 184);
            dataGridView2.TabIndex = 13;
            // 
            // Delete_button
            // 
            Delete_button.BackColor = SystemColors.WindowFrame;
            Delete_button.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Delete_button.ForeColor = SystemColors.ButtonFace;
            Delete_button.Location = new Point(396, 73);
            Delete_button.Margin = new Padding(3, 2, 3, 2);
            Delete_button.Name = "Delete_button";
            Delete_button.Size = new Size(71, 22);
            Delete_button.TabIndex = 12;
            Delete_button.Text = "Delete";
            Delete_button.UseVisualStyleBackColor = false;
            // 
            // Update_button
            // 
            Update_button.BackColor = SystemColors.WindowFrame;
            Update_button.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Update_button.ForeColor = SystemColors.ButtonFace;
            Update_button.Location = new Point(288, 73);
            Update_button.Margin = new Padding(3, 2, 3, 2);
            Update_button.Name = "Update_button";
            Update_button.Size = new Size(71, 22);
            Update_button.TabIndex = 11;
            Update_button.Text = "Update";
            Update_button.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GrayText;
            button1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(180, 73);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(71, 22);
            button1.TabIndex = 10;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            // 
            // CouseName_textBox
            // 
            CouseName_textBox.Location = new Point(74, 11);
            CouseName_textBox.Margin = new Padding(3, 2, 3, 2);
            CouseName_textBox.Name = "CouseName_textBox";
            CouseName_textBox.Size = new Size(252, 23);
            CouseName_textBox.TabIndex = 14;
            // 
            // CoursesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(CouseName_textBox);
            Controls.Add(dataGridView2);
            Controls.Add(Delete_button);
            Controls.Add(button1);
            Controls.Add(Update_button);
            Controls.Add(CourseID_textBox);
            Controls.Add(CourseID_label);
            Controls.Add(Course_label);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "CoursesForm";
            Text = "Courses";
            Load += CoursesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Course_label;
        private Label CourseID_label;
        private TextBox CourseID_textBox;
        private DataGridView dataGridView2;
        private Button Delete_button;
        private Button Update_button;
        private Button button1;
        private TextBox CouseName_textBox;
    }
}