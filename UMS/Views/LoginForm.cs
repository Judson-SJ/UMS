using System.Data;
using UMS.Controllers;
using UMS.Views;

namespace UMS
{
    public partial class LoginForm : Form
    {
        private LoginController _controller;

        public LoginForm()
        {
            InitializeComponent();
            _controller = new LoginController("Data Source=UMS_DB.db;Version=3;");
            Login_button.Click += Login_button_Click;
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            try
            {
                string username = UserID_textBox.Text.Trim();
                string password = Password_textBox.Text.Trim();

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please enter both username and password.");
                    return;
                }

                DataRow user = _controller.Login(username, password);

                if (user != null)
                {
                    string role = user["Role"].ToString();
                    MessageBox.Show($"Login successful. Role: {role}");

                    // Redirect to main form
                    this.Hide();
                    var mainForm = new MainForm();
                    mainForm.FormClosed += (s, args) => this.Close();
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
