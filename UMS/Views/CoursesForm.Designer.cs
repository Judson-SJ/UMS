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
            comboBox1 = new ComboBox();
            CourseID_label = new Label();
            Lecture_01_label = new Label();
            textBox1 = new TextBox();
            Lecture_01_textBox = new TextBox();
            Delete_button = new Button();
            Update_button = new Button();
            button1 = new Button();
            dataGridView2 = new DataGridView();
            Subject_01_textBox = new TextBox();
            Subject_01_label = new Label();
            Subject_02_textBox = new TextBox();
            Subject_02_label = new Label();
            Lecture_02_textBox = new TextBox();
            Lecture_02_label = new Label();
            Subject_03_textBox = new TextBox();
            Subject_03_label = new Label();
            Lecture_03_textBox = new TextBox();
            Lecture_03_label = new Label();
            Subject_ID_03_textBox = new TextBox();
            Subject_ID_03_label = new Label();
            Subject_ID_02_textBox = new TextBox();
            Subject_ID_02_label = new Label();
            Subject_ID_01_textBox = new TextBox();
            Subject_ID_01_label = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // Course_label
            // 
            Course_label.AutoSize = true;
            Course_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Course_label.Location = new Point(12, 14);
            Course_label.Name = "Course_label";
            Course_label.Size = new Size(65, 17);
            Course_label.TabIndex = 0;
            Course_label.Text = "Course :";
            Course_label.Click += Course_label_Click;
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteCustomSource.AddRange(new string[] { "Fundamental Of Computing" });
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(83, 9);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(287, 28);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // CourseID_label
            // 
            CourseID_label.AutoSize = true;
            CourseID_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CourseID_label.Location = new Point(402, 14);
            CourseID_label.Name = "CourseID_label";
            CourseID_label.Size = new Size(86, 17);
            CourseID_label.TabIndex = 2;
            CourseID_label.Text = "Course ID :";
            // 
            // Lecture_01_label
            // 
            Lecture_01_label.AutoSize = true;
            Lecture_01_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lecture_01_label.Location = new Point(12, 168);
            Lecture_01_label.Name = "Lecture_01_label";
            Lecture_01_label.Size = new Size(69, 17);
            Lecture_01_label.TabIndex = 3;
            Lecture_01_label.Text = "Lecture :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(500, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(287, 27);
            textBox1.TabIndex = 4;
            // 
            // Lecture_01_textBox
            // 
            Lecture_01_textBox.Location = new Point(11, 188);
            Lecture_01_textBox.Name = "Lecture_01_textBox";
            Lecture_01_textBox.Size = new Size(243, 27);
            Lecture_01_textBox.TabIndex = 5;
            // 
            // Delete_button
            // 
            Delete_button.BackColor = SystemColors.WindowFrame;
            Delete_button.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Delete_button.ForeColor = SystemColors.ButtonFace;
            Delete_button.Location = new Point(470, 254);
            Delete_button.Name = "Delete_button";
            Delete_button.Size = new Size(81, 30);
            Delete_button.TabIndex = 12;
            Delete_button.Text = "Delete";
            Delete_button.UseVisualStyleBackColor = false;
            // 
            // Update_button
            // 
            Update_button.BackColor = SystemColors.WindowFrame;
            Update_button.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Update_button.ForeColor = SystemColors.ButtonFace;
            Update_button.Location = new Point(346, 254);
            Update_button.Name = "Update_button";
            Update_button.Size = new Size(81, 30);
            Update_button.TabIndex = 11;
            Update_button.Text = "Update";
            Update_button.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GrayText;
            button1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(223, 254);
            button1.Name = "button1";
            button1.Size = new Size(81, 30);
            button1.TabIndex = 10;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.ControlLight;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(11, 323);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(776, 115);
            dataGridView2.TabIndex = 13;
            // 
            // Subject_01_textBox
            // 
            Subject_01_textBox.Location = new Point(11, 72);
            Subject_01_textBox.Name = "Subject_01_textBox";
            Subject_01_textBox.Size = new Size(243, 27);
            Subject_01_textBox.TabIndex = 15;
            Subject_01_textBox.TextChanged += textBox3_TextChanged;
            // 
            // Subject_01_label
            // 
            Subject_01_label.AutoSize = true;
            Subject_01_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Subject_01_label.Location = new Point(11, 52);
            Subject_01_label.Name = "Subject_01_label";
            Subject_01_label.Size = new Size(85, 17);
            Subject_01_label.TabIndex = 14;
            Subject_01_label.Text = "Subject 01 :";
            // 
            // Subject_02_textBox
            // 
            Subject_02_textBox.Location = new Point(276, 72);
            Subject_02_textBox.Name = "Subject_02_textBox";
            Subject_02_textBox.Size = new Size(243, 27);
            Subject_02_textBox.TabIndex = 19;
            // 
            // Subject_02_label
            // 
            Subject_02_label.AutoSize = true;
            Subject_02_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Subject_02_label.Location = new Point(276, 52);
            Subject_02_label.Name = "Subject_02_label";
            Subject_02_label.Size = new Size(85, 17);
            Subject_02_label.TabIndex = 18;
            Subject_02_label.Text = "Subject 02 :";
            // 
            // Lecture_02_textBox
            // 
            Lecture_02_textBox.Location = new Point(276, 188);
            Lecture_02_textBox.Name = "Lecture_02_textBox";
            Lecture_02_textBox.Size = new Size(243, 27);
            Lecture_02_textBox.TabIndex = 17;
            // 
            // Lecture_02_label
            // 
            Lecture_02_label.AutoSize = true;
            Lecture_02_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lecture_02_label.Location = new Point(277, 168);
            Lecture_02_label.Name = "Lecture_02_label";
            Lecture_02_label.Size = new Size(69, 17);
            Lecture_02_label.TabIndex = 16;
            Lecture_02_label.Text = "Lecture :";
            // 
            // Subject_03_textBox
            // 
            Subject_03_textBox.Location = new Point(544, 72);
            Subject_03_textBox.Name = "Subject_03_textBox";
            Subject_03_textBox.Size = new Size(243, 27);
            Subject_03_textBox.TabIndex = 23;
            // 
            // Subject_03_label
            // 
            Subject_03_label.AutoSize = true;
            Subject_03_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Subject_03_label.Location = new Point(544, 52);
            Subject_03_label.Name = "Subject_03_label";
            Subject_03_label.Size = new Size(85, 17);
            Subject_03_label.TabIndex = 22;
            Subject_03_label.Text = "Subject 03 :";
            // 
            // Lecture_03_textBox
            // 
            Lecture_03_textBox.Location = new Point(544, 188);
            Lecture_03_textBox.Name = "Lecture_03_textBox";
            Lecture_03_textBox.Size = new Size(243, 27);
            Lecture_03_textBox.TabIndex = 21;
            // 
            // Lecture_03_label
            // 
            Lecture_03_label.AutoSize = true;
            Lecture_03_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lecture_03_label.Location = new Point(545, 168);
            Lecture_03_label.Name = "Lecture_03_label";
            Lecture_03_label.Size = new Size(69, 17);
            Lecture_03_label.TabIndex = 20;
            Lecture_03_label.Text = "Lecture :";
            // 
            // Subject_ID_03_textBox
            // 
            Subject_ID_03_textBox.Location = new Point(545, 129);
            Subject_ID_03_textBox.Name = "Subject_ID_03_textBox";
            Subject_ID_03_textBox.Size = new Size(243, 27);
            Subject_ID_03_textBox.TabIndex = 29;
            // 
            // Subject_ID_03_label
            // 
            Subject_ID_03_label.AutoSize = true;
            Subject_ID_03_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Subject_ID_03_label.Location = new Point(545, 109);
            Subject_ID_03_label.Name = "Subject_ID_03_label";
            Subject_ID_03_label.Size = new Size(106, 17);
            Subject_ID_03_label.TabIndex = 28;
            Subject_ID_03_label.Text = "Subject ID 03 :";
            // 
            // Subject_ID_02_textBox
            // 
            Subject_ID_02_textBox.Location = new Point(277, 129);
            Subject_ID_02_textBox.Name = "Subject_ID_02_textBox";
            Subject_ID_02_textBox.Size = new Size(243, 27);
            Subject_ID_02_textBox.TabIndex = 27;
            // 
            // Subject_ID_02_label
            // 
            Subject_ID_02_label.AutoSize = true;
            Subject_ID_02_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Subject_ID_02_label.Location = new Point(277, 109);
            Subject_ID_02_label.Name = "Subject_ID_02_label";
            Subject_ID_02_label.Size = new Size(106, 17);
            Subject_ID_02_label.TabIndex = 26;
            Subject_ID_02_label.Text = "Subject ID 02 :";
            // 
            // Subject_ID_01_textBox
            // 
            Subject_ID_01_textBox.Location = new Point(12, 129);
            Subject_ID_01_textBox.Name = "Subject_ID_01_textBox";
            Subject_ID_01_textBox.Size = new Size(243, 27);
            Subject_ID_01_textBox.TabIndex = 25;
            // 
            // Subject_ID_01_label
            // 
            Subject_ID_01_label.AutoSize = true;
            Subject_ID_01_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Subject_ID_01_label.Location = new Point(12, 109);
            Subject_ID_01_label.Name = "Subject_ID_01_label";
            Subject_ID_01_label.Size = new Size(106, 17);
            Subject_ID_01_label.TabIndex = 24;
            Subject_ID_01_label.Text = "Subject ID 01 :";
            // 
            // CoursesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Subject_ID_03_textBox);
            Controls.Add(Subject_ID_03_label);
            Controls.Add(Subject_ID_02_textBox);
            Controls.Add(Subject_ID_02_label);
            Controls.Add(Subject_ID_01_textBox);
            Controls.Add(Subject_ID_01_label);
            Controls.Add(Subject_03_textBox);
            Controls.Add(Subject_03_label);
            Controls.Add(Lecture_03_textBox);
            Controls.Add(Lecture_03_label);
            Controls.Add(Subject_02_textBox);
            Controls.Add(Subject_02_label);
            Controls.Add(Lecture_02_textBox);
            Controls.Add(Lecture_02_label);
            Controls.Add(Subject_01_textBox);
            Controls.Add(Subject_01_label);
            Controls.Add(dataGridView2);
            Controls.Add(Delete_button);
            Controls.Add(button1);
            Controls.Add(Update_button);
            Controls.Add(Lecture_01_textBox);
            Controls.Add(textBox1);
            Controls.Add(Lecture_01_label);
            Controls.Add(CourseID_label);
            Controls.Add(comboBox1);
            Controls.Add(Course_label);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CoursesForm";
            Text = "Courses";
            Load += CoursesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Course_label;
        private ComboBox comboBox1;
        private Label CourseID_label;
        private Label Lecture_01_label;
        private TextBox textBox1;
        private TextBox Lecture_01_textBox;
        private Button Delete_button;
        private Button Update_button;
        private Button button1;
        private DataGridView dataGridView2;
        private TextBox Subject_01_textBox;
        private Label Subject_01_label;
        private TextBox Subject_02_textBox;
        private Label Subject_02_label;
        private TextBox Lecture_02_textBox;
        private Label Lecture_02_label;
        private TextBox Subject_03_textBox;
        private Label Subject_03_label;
        private TextBox Lecture_03_textBox;
        private Label Lecture_03_label;
        private TextBox Subject_ID_03_textBox;
        private Label Subject_ID_03_label;
        private TextBox Subject_ID_02_textBox;
        private Label Subject_ID_02_label;
        private TextBox Subject_ID_01_textBox;
        private Label Subject_ID_01_label;
    }
}