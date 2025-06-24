namespace UMS.Views
{
    partial class RoomForm
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
            Rooms_dataGridView = new DataGridView();
            Delete_button = new Button();
            button1 = new Button();
            Update_button = new Button();
            RoomID_textBox = new TextBox();
            RoomID_label = new Label();
            RoomType_comboBox = new ComboBox();
            RoomType_label = new Label();
            RoomName_label = new Label();
            RoomName_textBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Rooms_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // Rooms_dataGridView
            // 
            Rooms_dataGridView.BackgroundColor = SystemColors.ControlLight;
            Rooms_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Rooms_dataGridView.Location = new Point(12, 172);
            Rooms_dataGridView.Name = "Rooms_dataGridView";
            Rooms_dataGridView.RowHeadersWidth = 51;
            Rooms_dataGridView.Size = new Size(776, 268);
            Rooms_dataGridView.TabIndex = 21;
            // 
            // Delete_button
            // 
            Delete_button.BackColor = SystemColors.WindowFrame;
            Delete_button.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Delete_button.ForeColor = SystemColors.ButtonFace;
            Delete_button.Location = new Point(492, 81);
            Delete_button.Name = "Delete_button";
            Delete_button.Size = new Size(81, 30);
            Delete_button.TabIndex = 20;
            Delete_button.Text = "Delete";
            Delete_button.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GrayText;
            button1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(245, 81);
            button1.Name = "button1";
            button1.Size = new Size(81, 30);
            button1.TabIndex = 18;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            // 
            // Update_button
            // 
            Update_button.BackColor = SystemColors.WindowFrame;
            Update_button.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Update_button.ForeColor = SystemColors.ButtonFace;
            Update_button.Location = new Point(368, 81);
            Update_button.Name = "Update_button";
            Update_button.Size = new Size(81, 30);
            Update_button.TabIndex = 19;
            Update_button.Text = "Update";
            Update_button.UseVisualStyleBackColor = false;
            // 
            // RoomID_textBox
            // 
            RoomID_textBox.Location = new Point(95, 12);
            RoomID_textBox.Name = "RoomID_textBox";
            RoomID_textBox.Size = new Size(131, 27);
            RoomID_textBox.TabIndex = 17;
            // 
            // RoomID_label
            // 
            RoomID_label.AutoSize = true;
            RoomID_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RoomID_label.Location = new Point(12, 17);
            RoomID_label.Name = "RoomID_label";
            RoomID_label.Size = new Size(77, 17);
            RoomID_label.TabIndex = 16;
            RoomID_label.Text = "Room ID :";
            // 
            // RoomType_comboBox
            // 
            RoomType_comboBox.AutoCompleteCustomSource.AddRange(new string[] { "Fundamental Of Computing" });
            RoomType_comboBox.FormattingEnabled = true;
            RoomType_comboBox.Items.AddRange(new object[] { "Hall", "Lab" });
            RoomType_comboBox.Location = new Point(634, 12);
            RoomType_comboBox.Name = "RoomType_comboBox";
            RoomType_comboBox.Size = new Size(140, 28);
            RoomType_comboBox.TabIndex = 15;
            RoomType_comboBox.SelectedIndexChanged += RoomType_comboBox_SelectedIndexChanged;
            // 
            // RoomType_label
            // 
            RoomType_label.AutoSize = true;
            RoomType_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RoomType_label.Location = new Point(536, 17);
            RoomType_label.Name = "RoomType_label";
            RoomType_label.Size = new Size(92, 17);
            RoomType_label.TabIndex = 14;
            RoomType_label.Text = "Room Type :";
            // 
            // RoomName_label
            // 
            RoomName_label.AutoSize = true;
            RoomName_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RoomName_label.Location = new Point(258, 17);
            RoomName_label.Name = "RoomName_label";
            RoomName_label.Size = new Size(98, 17);
            RoomName_label.TabIndex = 22;
            RoomName_label.Text = "Room Name :";
            // 
            // RoomName_textBox
            // 
            RoomName_textBox.Location = new Point(362, 12);
            RoomName_textBox.Name = "RoomName_textBox";
            RoomName_textBox.Size = new Size(131, 27);
            RoomName_textBox.TabIndex = 23;
            // 
            // RoomForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RoomName_textBox);
            Controls.Add(RoomName_label);
            Controls.Add(Rooms_dataGridView);
            Controls.Add(Delete_button);
            Controls.Add(button1);
            Controls.Add(Update_button);
            Controls.Add(RoomID_textBox);
            Controls.Add(RoomID_label);
            Controls.Add(RoomType_comboBox);
            Controls.Add(RoomType_label);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RoomForm";
            Text = "Room";
            ((System.ComponentModel.ISupportInitialize)Rooms_dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Rooms_dataGridView;
        private Button Delete_button;
        private Button button1;
        private Button Update_button;
        private TextBox RoomID_textBox;
        private Label RoomID_label;
        private ComboBox RoomType_comboBox;
        private Label RoomType_label;
        private Label RoomName_label;
        private TextBox RoomName_textBox;
    }
}