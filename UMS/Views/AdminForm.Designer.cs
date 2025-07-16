namespace UMS.Views
{
    partial class AdminForm
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
            UserID_comboBox = new ComboBox();
            AdminID_label = new Label();
            Admins_dataGridView = new DataGridView();
            Delete_button = new Button();
            Update_button = new Button();
            Add_button = new Button();
            Name_textBox = new TextBox();
            AdminID_textBox = new TextBox();
            Name_label = new Label();
            UserID_label = new Label();
            ((System.ComponentModel.ISupportInitialize)Admins_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // UserID_comboBox
            // 
            UserID_comboBox.FormattingEnabled = true;
            UserID_comboBox.Items.AddRange(new object[] { "Admin", "Staff", "Lecture", "Student" });
            UserID_comboBox.Location = new Point(120, 78);
            UserID_comboBox.Name = "UserID_comboBox";
            UserID_comboBox.Size = new Size(204, 28);
            UserID_comboBox.TabIndex = 41;
            // 
            // AdminID_label
            // 
            AdminID_label.AutoSize = true;
            AdminID_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AdminID_label.Location = new Point(33, 25);
            AdminID_label.Name = "AdminID_label";
            AdminID_label.Size = new Size(81, 17);
            AdminID_label.TabIndex = 40;
            AdminID_label.Text = "Admin ID :";
            // 
            // Admins_dataGridView
            // 
            Admins_dataGridView.BackgroundColor = SystemColors.ControlLight;
            Admins_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Admins_dataGridView.Location = new Point(14, 200);
            Admins_dataGridView.Name = "Admins_dataGridView";
            Admins_dataGridView.RowHeadersWidth = 51;
            Admins_dataGridView.Size = new Size(776, 230);
            Admins_dataGridView.TabIndex = 39;
            // 
            // Delete_button
            // 
            Delete_button.BackColor = SystemColors.WindowFrame;
            Delete_button.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Delete_button.ForeColor = SystemColors.ButtonFace;
            Delete_button.Location = new Point(452, 142);
            Delete_button.Name = "Delete_button";
            Delete_button.Size = new Size(81, 30);
            Delete_button.TabIndex = 38;
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
            Update_button.TabIndex = 37;
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
            Add_button.TabIndex = 36;
            Add_button.Text = "Add";
            Add_button.UseVisualStyleBackColor = false;
            // 
            // Name_textBox
            // 
            Name_textBox.Location = new Point(395, 20);
            Name_textBox.Name = "Name_textBox";
            Name_textBox.Size = new Size(395, 27);
            Name_textBox.TabIndex = 35;
            // 
            // AdminID_textBox
            // 
            AdminID_textBox.Location = new Point(120, 20);
            AdminID_textBox.Name = "AdminID_textBox";
            AdminID_textBox.Size = new Size(164, 27);
            AdminID_textBox.TabIndex = 34;
            AdminID_textBox.TextChanged += UserID_textBox_TextChanged;
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
            // UserID_label
            // 
            UserID_label.AutoSize = true;
            UserID_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserID_label.Location = new Point(41, 83);
            UserID_label.Name = "UserID_label";
            UserID_label.Size = new Size(70, 17);
            UserID_label.TabIndex = 32;
            UserID_label.Text = "User ID :";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(UserID_comboBox);
            Controls.Add(AdminID_label);
            Controls.Add(Admins_dataGridView);
            Controls.Add(Delete_button);
            Controls.Add(Update_button);
            Controls.Add(Add_button);
            Controls.Add(Name_textBox);
            Controls.Add(AdminID_textBox);
            Controls.Add(Name_label);
            Controls.Add(UserID_label);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminForm";
            Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)Admins_dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox UserID_comboBox;
        private Label AdminID_label;
        private DataGridView Admins_dataGridView;
        private Button Delete_button;
        private Button Update_button;
        private Button Add_button;
        private TextBox Name_textBox;
        private TextBox AdminID_textBox;
        private Label Name_label;
        private Label UserID_label;
    }
}