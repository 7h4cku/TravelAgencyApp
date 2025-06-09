using System;
using System.Windows.Forms;

namespace TravelAgencyApp.Forms
{
    public class LoginForm : Form
    {
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;

        public LoginForm()
        {
            this.Text = "Login";
            this.Width = 300;
            this.Height = 200;

            txtUsername = new TextBox { PlaceholderText = "Username", Top = 20, Left = 50, Width = 200 };
            txtPassword = new TextBox { PlaceholderText = "Password", Top = 60, Left = 50, Width = 200, UseSystemPasswordChar = true };
            btnLogin = new Button { Text = "Login", Top = 100, Left = 50, Width = 200 };
            btnLogin.Click += BtnLogin_Click;

            this.Controls.Add(txtUsername);
            this.Controls.Add(txtPassword);
            this.Controls.Add(btnLogin);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login attempt");
        }
    }
}