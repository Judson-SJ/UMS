﻿namespace UMS
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            Logo_Pic_Box = new PictureBox();
            Login_label = new Label();
            UserID_label = new Label();
            Password_label = new Label();
            UserID_textBox = new TextBox();
            Password_textBox = new TextBox();
            Login_button = new Button();
            ForgotPW_linkLabel = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)Logo_Pic_Box).BeginInit();
            SuspendLayout();
            // 
            // Logo_Pic_Box
            // 
            Logo_Pic_Box.Image = (Image)resources.GetObject("Logo_Pic_Box.Image");
            Logo_Pic_Box.Location = new Point(2, 2);
            Logo_Pic_Box.Margin = new Padding(3, 2, 3, 2);
            Logo_Pic_Box.Name = "Logo_Pic_Box";
            Logo_Pic_Box.Size = new Size(187, 56);
            Logo_Pic_Box.SizeMode = PictureBoxSizeMode.StretchImage;
            Logo_Pic_Box.TabIndex = 0;
            Logo_Pic_Box.TabStop = false;
            // 
            // Login_label
            // 
            Login_label.AutoSize = true;
            Login_label.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login_label.Location = new Point(342, 71);
            Login_label.Name = "Login_label";
            Login_label.Size = new Size(78, 26);
            Login_label.TabIndex = 1;
            Login_label.Text = "Log in";
            // 
            // UserID_label
            // 
            UserID_label.AutoSize = true;
            UserID_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserID_label.Location = new Point(202, 122);
            UserID_label.Name = "UserID_label";
            UserID_label.Size = new Size(54, 15);
            UserID_label.TabIndex = 2;
            UserID_label.Text = "User ID :";
            // 
            // Password_label
            // 
            Password_label.AutoSize = true;
            Password_label.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Password_label.Location = new Point(202, 161);
            Password_label.Name = "Password_label";
            Password_label.Size = new Size(62, 15);
            Password_label.TabIndex = 3;
            Password_label.Text = "Password :";
            // 
            // UserID_textBox
            // 
            UserID_textBox.Location = new Point(305, 115);
            UserID_textBox.Margin = new Padding(3, 2, 3, 2);
            UserID_textBox.Name = "UserID_textBox";
            UserID_textBox.Size = new Size(177, 23);
            UserID_textBox.TabIndex = 4;
            // 
            // Password_textBox
            // 
            Password_textBox.Location = new Point(305, 154);
            Password_textBox.Margin = new Padding(3, 2, 3, 2);
            Password_textBox.Name = "Password_textBox";
            Password_textBox.Size = new Size(177, 23);
            Password_textBox.TabIndex = 5;
            // 
            // Login_button
            // 
            Login_button.BackColor = SystemColors.WindowFrame;
            Login_button.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login_button.ForeColor = SystemColors.ButtonFace;
            Login_button.Location = new Point(352, 204);
            Login_button.Margin = new Padding(3, 2, 3, 2);
            Login_button.Name = "Login_button";
            Login_button.Size = new Size(75, 22);
            Login_button.TabIndex = 6;
            Login_button.Text = "Login";
            Login_button.UseVisualStyleBackColor = false;
            // 
            // ForgotPW_linkLabel
            // 
            ForgotPW_linkLabel.AutoSize = true;
            ForgotPW_linkLabel.Location = new Point(333, 240);
            ForgotPW_linkLabel.Name = "ForgotPW_linkLabel";
            ForgotPW_linkLabel.Size = new Size(100, 15);
            ForgotPW_linkLabel.TabIndex = 7;
            ForgotPW_linkLabel.TabStop = true;
            ForgotPW_linkLabel.Text = "Forgot Password?";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(ForgotPW_linkLabel);
            Controls.Add(Login_button);
            Controls.Add(Password_textBox);
            Controls.Add(UserID_textBox);
            Controls.Add(Password_label);
            Controls.Add(UserID_label);
            Controls.Add(Login_label);
            Controls.Add(Logo_Pic_Box);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginForm";
            Text = "Log in";
            ((System.ComponentModel.ISupportInitialize)Logo_Pic_Box).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Logo_Pic_Box;
        private Label Login_label;
        private Label UserID_label;
        private Label Password_label;
        private TextBox UserID_textBox;
        private TextBox Password_textBox;
        private Button Login_button;
        private LinkLabel ForgotPW_linkLabel;
    }
}
