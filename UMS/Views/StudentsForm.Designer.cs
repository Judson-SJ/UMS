namespace UMS.Views
{
    partial class StudentsForm
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
            StudentID_label = new Label();
            Name_label = new Label();
            Address_label = new Label();
            StudentID_textBox = new TextBox();
            StudentName_textBox = new TextBox();
            Address_textBox = new TextBox();
            Add_button = new Button();
            Update_button = new Button();
            Delete_button = new Button();
            Students_dataGridView = new DataGridView();
            Course_comboBox = new ComboBox();
            Course_label = new Label();
            PhoneNo_textBox = new TextBox();
            PhoneNo_label = new Label();
            UserIDcomboBox = new ComboBox();
            UserIDlabel = new Label();
            ((System.ComponentModel.ISupportInitialize)Students_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // StudentID_label
            // 
            StudentID_label.AutoSize = true;
            StudentID_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StudentID_label.Location = new Point(22, 26);
            StudentID_label.Name = "StudentID_label";
            StudentID_label.Size = new Size(88, 17);
            StudentID_label.TabIndex = 0;
            StudentID_label.Text = "Student ID :";
            // 
            // Name_label
            // 
            Name_label.AutoSize = true;
            Name_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name_label.Location = new Point(340, 26);
            Name_label.Name = "Name_label";
            Name_label.Size = new Size(55, 17);
            Name_label.TabIndex = 1;
            Name_label.Text = "Name :";
            // 
            // Address_label
            // 
            Address_label.AutoSize = true;
            Address_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Address_label.Location = new Point(323, 75);
            Address_label.Name = "Address_label";
            Address_label.Size = new Size(72, 17);
            Address_label.TabIndex = 2;
            Address_label.Text = "Address :";
            // 
            // StudentID_textBox
            // 
            StudentID_textBox.Location = new Point(109, 21);
            StudentID_textBox.Name = "StudentID_textBox";
            StudentID_textBox.Size = new Size(204, 27);
            StudentID_textBox.TabIndex = 3;
            // 
            // StudentName_textBox
            // 
            StudentName_textBox.Location = new Point(401, 21);
            StudentName_textBox.Name = "StudentName_textBox";
            StudentName_textBox.Size = new Size(368, 27);
            StudentName_textBox.TabIndex = 4;
            // 
            // Address_textBox
            // 
            Address_textBox.Location = new Point(401, 70);
            Address_textBox.Name = "Address_textBox";
            Address_textBox.Size = new Size(368, 27);
            Address_textBox.TabIndex = 5;
            // 
            // Add_button
            // 
            Add_button.BackColor = SystemColors.GrayText;
            Add_button.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add_button.ForeColor = SystemColors.ButtonFace;
            Add_button.Location = new Point(217, 179);
            Add_button.Name = "Add_button";
            Add_button.Size = new Size(81, 30);
            Add_button.TabIndex = 6;
            Add_button.Text = "Add";
            Add_button.UseVisualStyleBackColor = false;
            // 
            // Update_button
            // 
            Update_button.BackColor = SystemColors.WindowFrame;
            Update_button.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Update_button.ForeColor = SystemColors.ButtonFace;
            Update_button.Location = new Point(340, 179);
            Update_button.Name = "Update_button";
            Update_button.Size = new Size(81, 30);
            Update_button.TabIndex = 7;
            Update_button.Text = "Update";
            Update_button.UseVisualStyleBackColor = false;
            // 
            // Delete_button
            // 
            Delete_button.BackColor = SystemColors.WindowFrame;
            Delete_button.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Delete_button.ForeColor = SystemColors.ButtonFace;
            Delete_button.Location = new Point(464, 179);
            Delete_button.Name = "Delete_button";
            Delete_button.Size = new Size(81, 30);
            Delete_button.TabIndex = 8;
            Delete_button.Text = "Delete";
            Delete_button.UseVisualStyleBackColor = false;
            // 
            // Students_dataGridView
            // 
            Students_dataGridView.BackgroundColor = SystemColors.ControlLight;
            Students_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Students_dataGridView.Location = new Point(12, 226);
            Students_dataGridView.Name = "Students_dataGridView";
            Students_dataGridView.RowHeadersWidth = 51;
            Students_dataGridView.Size = new Size(776, 212);
            Students_dataGridView.TabIndex = 9;
            // 
            // Course_comboBox
            // 
            Course_comboBox.AutoCompleteCustomSource.AddRange(new string[] { "Fundamental Of Computing" });
            Course_comboBox.FormattingEnabled = true;
            Course_comboBox.Location = new Point(109, 122);
            Course_comboBox.Name = "Course_comboBox";
            Course_comboBox.Size = new Size(204, 28);
            Course_comboBox.TabIndex = 11;
            // 
            // Course_label
            // 
            Course_label.AutoSize = true;
            Course_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Course_label.Location = new Point(45, 127);
            Course_label.Name = "Course_label";
            Course_label.Size = new Size(65, 17);
            Course_label.TabIndex = 10;
            Course_label.Text = "Course :";
            // 
            // PhoneNo_textBox
            // 
            PhoneNo_textBox.Location = new Point(401, 123);
            PhoneNo_textBox.Name = "PhoneNo_textBox";
            PhoneNo_textBox.Size = new Size(168, 27);
            PhoneNo_textBox.TabIndex = 49;
            // 
            // PhoneNo_label
            // 
            PhoneNo_label.AutoSize = true;
            PhoneNo_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PhoneNo_label.Location = new Point(314, 127);
            PhoneNo_label.Name = "PhoneNo_label";
            PhoneNo_label.Size = new Size(81, 17);
            PhoneNo_label.TabIndex = 48;
            PhoneNo_label.Text = "Phone No :";
            // 
            // UserIDcomboBox
            // 
            UserIDcomboBox.FormattingEnabled = true;
            UserIDcomboBox.Location = new Point(109, 69);
            UserIDcomboBox.Name = "UserIDcomboBox";
            UserIDcomboBox.Size = new Size(204, 28);
            UserIDcomboBox.TabIndex = 47;
            // 
            // UserIDlabel
            // 
            UserIDlabel.AutoSize = true;
            UserIDlabel.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserIDlabel.Location = new Point(40, 74);
            UserIDlabel.Name = "UserIDlabel";
            UserIDlabel.Size = new Size(70, 17);
            UserIDlabel.TabIndex = 46;
            UserIDlabel.Text = "User ID :";
            // 
            // StudentsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PhoneNo_textBox);
            Controls.Add(PhoneNo_label);
            Controls.Add(UserIDcomboBox);
            Controls.Add(UserIDlabel);
            Controls.Add(Course_comboBox);
            Controls.Add(Course_label);
            Controls.Add(Students_dataGridView);
            Controls.Add(Delete_button);
            Controls.Add(Update_button);
            Controls.Add(Add_button);
            Controls.Add(Address_textBox);
            Controls.Add(StudentName_textBox);
            Controls.Add(StudentID_textBox);
            Controls.Add(Address_label);
            Controls.Add(Name_label);
            Controls.Add(StudentID_label);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentsForm";
            Text = "Students";
            ((System.ComponentModel.ISupportInitialize)Students_dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label StudentID_label;
        private Label Name_label;
        private Label Address_label;
        private TextBox StudentID_textBox;
        private TextBox StudentName_textBox;
        private TextBox Address_textBox;
        private Button Add_button;
        private Button Update_button;
        private Button Delete_button;
        private DataGridView Students_dataGridView;
        private ComboBox Course_comboBox;
        private Label Course_label;
        private TextBox PhoneNo_textBox;
        private Label PhoneNo_label;
        private ComboBox UserIDcomboBox;
        private Label UserIDlabel;
    }
}