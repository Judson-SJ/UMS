﻿namespace UMS.Views
{
    partial class UsersForm
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
            Users_dataGridView = new DataGridView();
            Delete_button = new Button();
            Update_button = new Button();
            Add_button = new Button();
            Name_textBox = new TextBox();
            UserID_textBox = new TextBox();
            Name_label = new Label();
            UserID_label = new Label();
            Role_comboBox = new ComboBox();
            Role_label = new Label();
            Password_textBox = new TextBox();
            Password_label = new Label();
            ((System.ComponentModel.ISupportInitialize)Users_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // Users_dataGridView
            // 
            Users_dataGridView.BackgroundColor = SystemColors.ControlLight;
            Users_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Users_dataGridView.Location = new Point(12, 214);
            Users_dataGridView.Name = "Users_dataGridView";
            Users_dataGridView.RowHeadersWidth = 51;
            Users_dataGridView.Size = new Size(776, 212);
            Users_dataGridView.TabIndex = 19;
            // 
            // Delete_button
            // 
            Delete_button.BackColor = SystemColors.WindowFrame;
            Delete_button.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Delete_button.ForeColor = SystemColors.ButtonFace;
            Delete_button.Location = new Point(450, 162);
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
            Update_button.Location = new Point(326, 162);
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
            Add_button.Location = new Point(208, 162);
            Add_button.Name = "Add_button";
            Add_button.Size = new Size(81, 30);
            Add_button.TabIndex = 16;
            Add_button.Text = "Add";
            Add_button.UseVisualStyleBackColor = false;
            // 
            // Name_textBox
            // 
            Name_textBox.Location = new Point(393, 16);
            Name_textBox.Name = "Name_textBox";
            Name_textBox.Size = new Size(395, 27);
            Name_textBox.TabIndex = 14;
            // 
            // UserID_textBox
            // 
            UserID_textBox.Location = new Point(85, 16);
            UserID_textBox.Name = "UserID_textBox";
            UserID_textBox.Size = new Size(204, 27);
            UserID_textBox.TabIndex = 13;
            // 
            // Name_label
            // 
            Name_label.AutoSize = true;
            Name_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name_label.Location = new Point(329, 21);
            Name_label.Name = "Name_label";
            Name_label.Size = new Size(55, 17);
            Name_label.TabIndex = 11;
            Name_label.Text = "Name :";
            // 
            // UserID_label
            // 
            UserID_label.AutoSize = true;
            UserID_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserID_label.Location = new Point(8, 21);
            UserID_label.Name = "UserID_label";
            UserID_label.Size = new Size(70, 17);
            UserID_label.TabIndex = 10;
            UserID_label.Text = "User ID :";
            // 
            // Role_comboBox
            // 
            Role_comboBox.FormattingEnabled = true;
            Role_comboBox.Items.AddRange(new object[] { "Admin", "Staff", "Lecture", "Student" });
            Role_comboBox.Location = new Point(393, 63);
            Role_comboBox.Name = "Role_comboBox";
            Role_comboBox.Size = new Size(204, 28);
            Role_comboBox.TabIndex = 31;
            // 
            // Role_label
            // 
            Role_label.AutoSize = true;
            Role_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Role_label.Location = new Point(338, 68);
            Role_label.Name = "Role_label";
            Role_label.Size = new Size(48, 17);
            Role_label.TabIndex = 30;
            Role_label.Text = "Role :";
            // 
            // Password_textBox
            // 
            Password_textBox.Location = new Point(85, 58);
            Password_textBox.Name = "Password_textBox";
            Password_textBox.Size = new Size(204, 27);
            Password_textBox.TabIndex = 34;
            // 
            // Password_label
            // 
            Password_label.AutoSize = true;
            Password_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Password_label.Location = new Point(8, 63);
            Password_label.Name = "Password_label";
            Password_label.Size = new Size(79, 17);
            Password_label.TabIndex = 32;
            Password_label.Text = "Password :";
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Password_textBox);
            Controls.Add(Password_label);
            Controls.Add(Role_comboBox);
            Controls.Add(Role_label);
            Controls.Add(Users_dataGridView);
            Controls.Add(Delete_button);
            Controls.Add(Update_button);
            Controls.Add(Add_button);
            Controls.Add(Name_textBox);
            Controls.Add(UserID_textBox);
            Controls.Add(Name_label);
            Controls.Add(UserID_label);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UsersForm";
            Text = "Users";
            ((System.ComponentModel.ISupportInitialize)Users_dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Users_dataGridView;
        private Button Delete_button;
        private Button Update_button;
        private Button Add_button;
        private TextBox Name_textBox;
        private TextBox UserID_textBox;
        private Label Name_label;
        private Label UserID_label;
        private ComboBox Role_comboBox;
        private Label Role_label;
        private TextBox Password_textBox;
        private Label Password_label;
    }
}