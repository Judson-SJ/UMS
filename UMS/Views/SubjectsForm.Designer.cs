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
            Subject_ID_textBox = new TextBox();
            Subject_ID_label = new Label();
            Subject_textBox = new TextBox();
            Subject_label = new Label();
            Lecture_label = new Label();
            dataGridView2 = new DataGridView();
            Delete_button = new Button();
            button1 = new Button();
            Update_button = new Button();
            Course_label = new Label();
            Course_comboBox = new ComboBox();
            Lecture_comboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // Subject_ID_textBox
            // 
            Subject_ID_textBox.Location = new Point(113, 19);
            Subject_ID_textBox.Name = "Subject_ID_textBox";
            Subject_ID_textBox.Size = new Size(243, 27);
            Subject_ID_textBox.TabIndex = 31;
            Subject_ID_textBox.TextChanged += Subject_ID_01_textBox_TextChanged;
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
            // Subject_textBox
            // 
            Subject_textBox.Location = new Point(447, 19);
            Subject_textBox.Name = "Subject_textBox";
            Subject_textBox.Size = new Size(327, 27);
            Subject_textBox.TabIndex = 29;
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
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.ControlLight;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(72, 229);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(643, 192);
            dataGridView2.TabIndex = 35;
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
            // button1
            // 
            button1.BackColor = SystemColors.GrayText;
            button1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(261, 152);
            button1.Name = "button1";
            button1.Size = new Size(81, 29);
            button1.TabIndex = 32;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
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
            Controls.Add(dataGridView2);
            Controls.Add(Delete_button);
            Controls.Add(button1);
            Controls.Add(Update_button);
            Controls.Add(Subject_ID_textBox);
            Controls.Add(Subject_ID_label);
            Controls.Add(Subject_textBox);
            Controls.Add(Subject_label);
            Controls.Add(Lecture_label);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "SubjectsForm";
            Text = "SubjectsForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Subject_ID_textBox;
        private Label Subject_ID_label;
        private TextBox Subject_textBox;
        private Label Subject_label;
        private Label Lecture_label;
        private DataGridView dataGridView2;
        private Button Delete_button;
        private Button button1;
        private Button Update_button;
        private Label Course_label;
        private ComboBox Course_comboBox;
        private ComboBox Lecture_comboBox;
    }
}