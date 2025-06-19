namespace UMS.Views
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
            dataGridView1 = new DataGridView();
            Delete_button = new Button();
            Update_button = new Button();
            Add_button = new Button();
            Address_textBox = new TextBox();
            Name_textBox = new TextBox();
            UserID_textBox = new TextBox();
            Address_label = new Label();
            Name_label = new Label();
            UserID_label = new Label();
            Role_comboBox = new ComboBox();
            Role_label = new Label();
            PhoneNo_textBox = new TextBox();
            Password_textBox = new TextBox();
            PhoneNolabel = new Label();
            Password_label = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 214);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 212);
            dataGridView1.TabIndex = 19;
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
            // Address_textBox
            // 
            Address_textBox.Location = new Point(393, 102);
            Address_textBox.Name = "Address_textBox";
            Address_textBox.Size = new Size(395, 27);
            Address_textBox.TabIndex = 15;
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
            // Address_label
            // 
            Address_label.AutoSize = true;
            Address_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Address_label.Location = new Point(312, 107);
            Address_label.Name = "Address_label";
            Address_label.Size = new Size(72, 17);
            Address_label.TabIndex = 12;
            Address_label.Text = "Address :";
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
            Role_comboBox.Location = new Point(85, 101);
            Role_comboBox.Name = "Role_comboBox";
            Role_comboBox.Size = new Size(204, 28);
            Role_comboBox.TabIndex = 31;
            // 
            // Role_label
            // 
            Role_label.AutoSize = true;
            Role_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Role_label.Location = new Point(30, 106);
            Role_label.Name = "Role_label";
            Role_label.Size = new Size(48, 17);
            Role_label.TabIndex = 30;
            Role_label.Text = "Role :";
            // 
            // PhoneNo_textBox
            // 
            PhoneNo_textBox.Location = new Point(393, 58);
            PhoneNo_textBox.Name = "PhoneNo_textBox";
            PhoneNo_textBox.Size = new Size(147, 27);
            PhoneNo_textBox.TabIndex = 35;
            // 
            // Password_textBox
            // 
            Password_textBox.Location = new Point(85, 58);
            Password_textBox.Name = "Password_textBox";
            Password_textBox.Size = new Size(204, 27);
            Password_textBox.TabIndex = 34;
            // 
            // PhoneNolabel
            // 
            PhoneNolabel.AutoSize = true;
            PhoneNolabel.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PhoneNolabel.Location = new Point(303, 63);
            PhoneNolabel.Name = "PhoneNolabel";
            PhoneNolabel.Size = new Size(81, 17);
            PhoneNolabel.TabIndex = 33;
            PhoneNolabel.Text = "Phone No :";
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
            Controls.Add(PhoneNo_textBox);
            Controls.Add(Password_textBox);
            Controls.Add(PhoneNolabel);
            Controls.Add(Password_label);
            Controls.Add(Role_comboBox);
            Controls.Add(Role_label);
            Controls.Add(dataGridView1);
            Controls.Add(Delete_button);
            Controls.Add(Update_button);
            Controls.Add(Add_button);
            Controls.Add(Address_textBox);
            Controls.Add(Name_textBox);
            Controls.Add(UserID_textBox);
            Controls.Add(Address_label);
            Controls.Add(Name_label);
            Controls.Add(UserID_label);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UsersForm";
            Text = "Users";
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
        private TextBox Name_textBox;
        private TextBox UserID_textBox;
        private Label Address_label;
        private Label Name_label;
        private Label UserID_label;
        private ComboBox Role_comboBox;
        private Label Role_label;
        private TextBox PhoneNo_textBox;
        private TextBox Password_textBox;
        private Label PhoneNolabel;
        private Label Password_label;
    }
}