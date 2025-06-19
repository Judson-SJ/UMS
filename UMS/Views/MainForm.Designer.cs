namespace UMS.Views
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Left_panel = new Panel();
            Logo_Pic_Box = new PictureBox();
            Exam_button = new Button();
            Rooms_button = new Button();
            Users_button = new Button();
            Lecturers_button = new Button();
            TimeTable_button = new Button();
            Marks_button = new Button();
            Courses_button = new Button();
            Staff_button = new Button();
            Students_button = new Button();
            Top_panel = new Panel();
            Back_button = new Button();
            Main_panel = new Panel();
            Left_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo_Pic_Box).BeginInit();
            Top_panel.SuspendLayout();
            SuspendLayout();
            // 
            // Left_panel
            // 
            Left_panel.BackColor = SystemColors.ControlLight;
            Left_panel.Controls.Add(Logo_Pic_Box);
            Left_panel.Controls.Add(Exam_button);
            Left_panel.Controls.Add(Rooms_button);
            Left_panel.Controls.Add(Users_button);
            Left_panel.Controls.Add(Lecturers_button);
            Left_panel.Controls.Add(TimeTable_button);
            Left_panel.Controls.Add(Marks_button);
            Left_panel.Controls.Add(Courses_button);
            Left_panel.Controls.Add(Staff_button);
            Left_panel.Controls.Add(Students_button);
            Left_panel.Dock = DockStyle.Left;
            Left_panel.Location = new Point(0, 0);
            Left_panel.Name = "Left_panel";
            Left_panel.Size = new Size(159, 533);
            Left_panel.TabIndex = 2;
            // 
            // Logo_Pic_Box
            // 
            Logo_Pic_Box.Image = (Image)resources.GetObject("Logo_Pic_Box.Image");
            Logo_Pic_Box.Location = new Point(5, 9);
            Logo_Pic_Box.Name = "Logo_Pic_Box";
            Logo_Pic_Box.Size = new Size(148, 42);
            Logo_Pic_Box.SizeMode = PictureBoxSizeMode.StretchImage;
            Logo_Pic_Box.TabIndex = 10;
            Logo_Pic_Box.TabStop = false;
            // 
            // Exam_button
            // 
            Exam_button.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Exam_button.Location = new Point(12, 300);
            Exam_button.Name = "Exam_button";
            Exam_button.Size = new Size(139, 31);
            Exam_button.TabIndex = 9;
            Exam_button.Text = "Exam ⟫⟫⟫";
            Exam_button.UseVisualStyleBackColor = true;
            Exam_button.Click += Exam_button_Click;
            // 
            // Rooms_button
            // 
            Rooms_button.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Rooms_button.Location = new Point(12, 226);
            Rooms_button.Name = "Rooms_button";
            Rooms_button.Size = new Size(139, 31);
            Rooms_button.TabIndex = 8;
            Rooms_button.Text = "Rooms ⟫⟫⟫";
            Rooms_button.UseVisualStyleBackColor = true;
            Rooms_button.Click += Rooms_button_Click;
            // 
            // Users_button
            // 
            Users_button.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Users_button.Location = new Point(12, 337);
            Users_button.Name = "Users_button";
            Users_button.Size = new Size(139, 31);
            Users_button.TabIndex = 7;
            Users_button.Text = "Users ⟫⟫⟫";
            Users_button.UseVisualStyleBackColor = true;
            Users_button.Click += Users_button_Click;
            // 
            // Lecturers_button
            // 
            Lecturers_button.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Lecturers_button.Location = new Point(12, 115);
            Lecturers_button.Name = "Lecturers_button";
            Lecturers_button.Size = new Size(139, 31);
            Lecturers_button.TabIndex = 6;
            Lecturers_button.Text = "Lecturers ⟫⟫⟫";
            Lecturers_button.UseVisualStyleBackColor = true;
            Lecturers_button.Click += Lecturers_button_Click;
            // 
            // TimeTable_button
            // 
            TimeTable_button.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            TimeTable_button.Location = new Point(12, 78);
            TimeTable_button.Name = "TimeTable_button";
            TimeTable_button.Size = new Size(139, 31);
            TimeTable_button.TabIndex = 5;
            TimeTable_button.Text = "Time Table ⟫⟫⟫";
            TimeTable_button.UseVisualStyleBackColor = true;
            TimeTable_button.Click += TimeTable_button_Click;
            // 
            // Marks_button
            // 
            Marks_button.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Marks_button.Location = new Point(12, 263);
            Marks_button.Name = "Marks_button";
            Marks_button.Size = new Size(139, 31);
            Marks_button.TabIndex = 4;
            Marks_button.Text = "Marks ⟫⟫⟫";
            Marks_button.UseVisualStyleBackColor = true;
            Marks_button.Click += Marks_button_Click;
            // 
            // Courses_button
            // 
            Courses_button.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Courses_button.Location = new Point(12, 189);
            Courses_button.Name = "Courses_button";
            Courses_button.Size = new Size(139, 31);
            Courses_button.TabIndex = 3;
            Courses_button.Text = "Courses ⟫⟫⟫";
            Courses_button.UseVisualStyleBackColor = true;
            Courses_button.Click += Courses_button_Click;
            // 
            // Staff_button
            // 
            Staff_button.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Staff_button.Location = new Point(12, 374);
            Staff_button.Name = "Staff_button";
            Staff_button.Size = new Size(139, 31);
            Staff_button.TabIndex = 2;
            Staff_button.Text = "Staff ⟫⟫⟫";
            Staff_button.UseVisualStyleBackColor = true;
            Staff_button.Click += Staff_button_Click;
            // 
            // Students_button
            // 
            Students_button.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Students_button.Location = new Point(12, 152);
            Students_button.Name = "Students_button";
            Students_button.Size = new Size(139, 31);
            Students_button.TabIndex = 0;
            Students_button.Text = "Students ⟫⟫⟫";
            Students_button.UseVisualStyleBackColor = true;
            Students_button.Click += Students_button_Click;
            // 
            // Top_panel
            // 
            Top_panel.BackColor = SystemColors.ControlLight;
            Top_panel.Controls.Add(Back_button);
            Top_panel.Dock = DockStyle.Top;
            Top_panel.Location = new Point(159, 0);
            Top_panel.Name = "Top_panel";
            Top_panel.Size = new Size(815, 39);
            Top_panel.TabIndex = 3;
            // 
            // Back_button
            // 
            Back_button.Location = new Point(757, 6);
            Back_button.Name = "Back_button";
            Back_button.Size = new Size(46, 28);
            Back_button.TabIndex = 0;
            Back_button.Text = "🔙";
            Back_button.UseVisualStyleBackColor = true;
            Back_button.Click += Back_button_Click;
            // 
            // Main_panel
            // 
            Main_panel.Dock = DockStyle.Fill;
            Main_panel.ForeColor = SystemColors.ActiveCaptionText;
            Main_panel.Location = new Point(159, 39);
            Main_panel.Name = "Main_panel";
            Main_panel.Size = new Size(815, 494);
            Main_panel.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 533);
            Controls.Add(Main_panel);
            Controls.Add(Top_panel);
            Controls.Add(Left_panel);
            Name = "MainForm";
            Text = "Dashboard";
            Left_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Logo_Pic_Box).EndInit();
            Top_panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel Left_panel;
        private Panel Top_panel;
        private Panel Main_panel;
        private Button Marks_button;
        private Button Courses_button;
        private Button Staff_button;
        private Button Students_button;
        private Button Lecturers_button;
        private Button TimeTable_button;
        private Button Back_button;
        private Button Users_button;
        private Button Rooms_button;
        private Button Exam_button;
        private PictureBox Logo_Pic_Box;
    }
}