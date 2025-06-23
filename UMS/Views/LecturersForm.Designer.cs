namespace UMS.Views
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
            dataGridView1 = new DataGridView();
            Delete_button = new Button();
            Update_button = new Button();
            Add_button = new Button();
            Address_textBox = new TextBox();
            StudentName_textBox = new TextBox();
            StudentID_textBox = new TextBox();
            Address_label = new Label();
            Name_label = new Label();
            LectureID_label = new Label();
            PhoneNo_label = new Label();
            PhoneNo_textBox = new TextBox();
            UserIDcomboBox = new ComboBox();
            UserIDlabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 249);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 177);
            dataGridView1.TabIndex = 19;
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
            // StudentName_textBox
            // 
            StudentName_textBox.Location = new Point(372, 25);
            StudentName_textBox.Name = "StudentName_textBox";
            StudentName_textBox.Size = new Size(416, 27);
            StudentName_textBox.TabIndex = 14;
            // 
            // StudentID_textBox
            // 
            StudentID_textBox.Location = new Point(105, 25);
            StudentID_textBox.Name = "StudentID_textBox";
            StudentID_textBox.Size = new Size(168, 27);
            StudentID_textBox.TabIndex = 13;
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
            Name_label.Click += Name_label_Click;
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
            PhoneNo_label.Click += PhoneNo_label_Click;
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
            Controls.Add(dataGridView1);
            Controls.Add(Delete_button);
            Controls.Add(Update_button);
            Controls.Add(Add_button);
            Controls.Add(Address_textBox);
            Controls.Add(StudentName_textBox);
            Controls.Add(StudentID_textBox);
            Controls.Add(Address_label);
            Controls.Add(Name_label);
            Controls.Add(LectureID_label);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LecturersForm";
            Text = "Lecturers";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button Delete_button;
        private Button Update_button;
        private Button Add_button;
        private TextBox Address_textBox;
        private TextBox StudentName_textBox;
        private TextBox StudentID_textBox;
        private Label Address_label;
        private Label Name_label;
        private Label LectureID_label;
        private Label PhoneNo_label;
        private TextBox PhoneNo_textBox;
        private ComboBox UserIDcomboBox;
        private Label UserIDlabel;
    }
}