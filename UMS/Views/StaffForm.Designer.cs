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
            Role_comboBox = new ComboBox();
            Role_label = new Label();
            dataGridView1 = new DataGridView();
            Delete_button = new Button();
            Update_button = new Button();
            Add_button = new Button();
            Address_textBox = new TextBox();
            Name_textBox = new TextBox();
            StaffID_textBox = new TextBox();
            Address_label = new Label();
            Name_label = new Label();
            StaffID_label = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Role_comboBox
            // 
            Role_comboBox.FormattingEnabled = true;
            Role_comboBox.Location = new Point(87, 76);
            Role_comboBox.Name = "Role_comboBox";
            Role_comboBox.Size = new Size(204, 28);
            Role_comboBox.TabIndex = 43;
            // 
            // Role_label
            // 
            Role_label.AutoSize = true;
            Role_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Role_label.Location = new Point(32, 81);
            Role_label.Name = "Role_label";
            Role_label.Size = new Size(48, 17);
            Role_label.TabIndex = 42;
            Role_label.Text = "Role :";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 218);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 212);
            dataGridView1.TabIndex = 41;
            // 
            // Delete_button
            // 
            Delete_button.BackColor = SystemColors.WindowFrame;
            Delete_button.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Delete_button.ForeColor = SystemColors.ButtonFace;
            Delete_button.Location = new Point(452, 142);
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
            Update_button.Location = new Point(328, 142);
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
            Add_button.Location = new Point(210, 142);
            Add_button.Name = "Add_button";
            Add_button.Size = new Size(81, 30);
            Add_button.TabIndex = 38;
            Add_button.Text = "Add";
            Add_button.UseVisualStyleBackColor = false;
            // 
            // Address_textBox
            // 
            Address_textBox.Location = new Point(395, 77);
            Address_textBox.Name = "Address_textBox";
            Address_textBox.Size = new Size(395, 27);
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
            Address_label.Location = new Point(314, 82);
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
            // StaffForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Role_comboBox);
            Controls.Add(Role_label);
            Controls.Add(dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Role_comboBox;
        private Label Role_label;
        private DataGridView dataGridView1;
        private Button Delete_button;
        private Button Update_button;
        private Button Add_button;
        private TextBox Address_textBox;
        private TextBox Name_textBox;
        private TextBox StaffID_textBox;
        private Label Address_label;
        private Label Name_label;
        private Label StaffID_label;
    }
}