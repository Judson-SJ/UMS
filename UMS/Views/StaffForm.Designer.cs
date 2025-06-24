namespace UMS.Views
{
    partial class StaffForm
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
            Staff_dataGridView = new DataGridView();
            Delete_button = new Button();
            Update_button = new Button();
            Add_button = new Button();
            Address_textBox = new TextBox();
            Name_textBox = new TextBox();
            StaffID_textBox = new TextBox();
            Address_label = new Label();
            Name_label = new Label();
            StaffID_label = new Label();
            UserIDlabel = new Label();
            UserIDcomboBox = new ComboBox();
            PhoneNo_textBox = new TextBox();
            PhoneNo_label = new Label();
            ((System.ComponentModel.ISupportInitialize)Staff_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // Staff_dataGridView
            // 
            Staff_dataGridView.BackgroundColor = SystemColors.ControlLight;
            Staff_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Staff_dataGridView.Location = new Point(14, 218);
            Staff_dataGridView.Name = "Staff_dataGridView";
            Staff_dataGridView.RowHeadersWidth = 51;
            Staff_dataGridView.Size = new Size(776, 212);
            Staff_dataGridView.TabIndex = 41;
            // 
            // Delete_button
            // 
            Delete_button.BackColor = SystemColors.WindowFrame;
            Delete_button.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Delete_button.ForeColor = SystemColors.ButtonFace;
            Delete_button.Location = new Point(452, 174);
            Delete_button.Name = "Delete_button";
            Delete_button.Size = new Size(81, 30);
            Delete_button.TabIndex = 40;
            Delete_button.Text = "Delete";
            Delete_button.UseVisualStyleBackColor = false;
            // 
            // Update_button
            // 
            Update_button.BackColor = SystemColors.WindowFrame;
            Update_button.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Update_button.ForeColor = SystemColors.ButtonFace;
            Update_button.Location = new Point(328, 174);
            Update_button.Name = "Update_button";
            Update_button.Size = new Size(81, 30);
            Update_button.TabIndex = 39;
            Update_button.Text = "Update";
            Update_button.UseVisualStyleBackColor = false;
            // 
            // Add_button
            // 
            Add_button.BackColor = SystemColors.GrayText;
            Add_button.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add_button.ForeColor = SystemColors.ButtonFace;
            Add_button.Location = new Point(210, 174);
            Add_button.Name = "Add_button";
            Add_button.Size = new Size(81, 30);
            Add_button.TabIndex = 38;
            Add_button.Text = "Add";
            Add_button.UseVisualStyleBackColor = false;
            // 
            // Address_textBox
            // 
            Address_textBox.Location = new Point(395, 64);
            Address_textBox.Name = "Address_textBox";
            Address_textBox.Size = new Size(299, 27);
            Address_textBox.TabIndex = 37;
            // 
            // Name_textBox
            // 
            Name_textBox.Location = new Point(395, 20);
            Name_textBox.Name = "Name_textBox";
            Name_textBox.Size = new Size(395, 27);
            Name_textBox.TabIndex = 36;
            // 
            // StaffID_textBox
            // 
            StaffID_textBox.Location = new Point(87, 20);
            StaffID_textBox.Name = "StaffID_textBox";
            StaffID_textBox.Size = new Size(204, 27);
            StaffID_textBox.TabIndex = 35;
            // 
            // Address_label
            // 
            Address_label.AutoSize = true;
            Address_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Address_label.Location = new Point(314, 69);
            Address_label.Name = "Address_label";
            Address_label.Size = new Size(72, 17);
            Address_label.TabIndex = 34;
            Address_label.Text = "Address :";
            // 
            // Name_label
            // 
            Name_label.AutoSize = true;
            Name_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name_label.Location = new Point(331, 25);
            Name_label.Name = "Name_label";
            Name_label.Size = new Size(55, 17);
            Name_label.TabIndex = 33;
            Name_label.Text = "Name :";
            // 
            // StaffID_label
            // 
            StaffID_label.AutoSize = true;
            StaffID_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StaffID_label.Location = new Point(10, 25);
            StaffID_label.Name = "StaffID_label";
            StaffID_label.Size = new Size(66, 17);
            StaffID_label.TabIndex = 32;
            StaffID_label.Text = "Staff ID :";
            // 
            // UserIDlabel
            // 
            UserIDlabel.AutoSize = true;
            UserIDlabel.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserIDlabel.Location = new Point(10, 69);
            UserIDlabel.Name = "UserIDlabel";
            UserIDlabel.Size = new Size(70, 17);
            UserIDlabel.TabIndex = 42;
            UserIDlabel.Text = "User ID :";
            // 
            // UserIDcomboBox
            // 
            UserIDcomboBox.FormattingEnabled = true;
            UserIDcomboBox.Location = new Point(86, 63);
            UserIDcomboBox.Name = "UserIDcomboBox";
            UserIDcomboBox.Size = new Size(204, 28);
            UserIDcomboBox.TabIndex = 43;
            // 
            // PhoneNo_textBox
            // 
            PhoneNo_textBox.Location = new Point(395, 111);
            PhoneNo_textBox.Name = "PhoneNo_textBox";
            PhoneNo_textBox.Size = new Size(168, 27);
            PhoneNo_textBox.TabIndex = 45;
            // 
            // PhoneNo_label
            // 
            PhoneNo_label.AutoSize = true;
            PhoneNo_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PhoneNo_label.Location = new Point(305, 116);
            PhoneNo_label.Name = "PhoneNo_label";
            PhoneNo_label.Size = new Size(81, 17);
            PhoneNo_label.TabIndex = 44;
            PhoneNo_label.Text = "Phone No :";
            // 
            // StaffForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PhoneNo_textBox);
            Controls.Add(PhoneNo_label);
            Controls.Add(UserIDcomboBox);
            Controls.Add(UserIDlabel);
            Controls.Add(Staff_dataGridView);
            Controls.Add(Delete_button);
            Controls.Add(Update_button);
            Controls.Add(Add_button);
            Controls.Add(Address_textBox);
            Controls.Add(Name_textBox);
            Controls.Add(StaffID_textBox);
            Controls.Add(Address_label);
            Controls.Add(Name_label);
            Controls.Add(StaffID_label);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StaffForm";
            Text = "Staff";
            ((System.ComponentModel.ISupportInitialize)Staff_dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView Staff_dataGridView;
        private Button Delete_button;
        private Button Update_button;
        private Button Add_button;
        private TextBox Address_textBox;
        private TextBox Name_textBox;
        private TextBox StaffID_textBox;
        private Label Address_label;
        private Label Name_label;
        private Label StaffID_label;
        private Label UserIDlabel;
        private ComboBox UserIDcomboBox;
        private TextBox PhoneNo_textBox;
        private Label PhoneNo_label;
    }
}