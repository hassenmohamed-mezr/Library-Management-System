using System;
using System.Windows.Forms;
using Library_Management_System.Services;

namespace Library_Management_System
{
    public partial class LoginForm : Form
    {
        private readonly AuthService _authService = new AuthService();

        public LoginForm()
        {
            InitializeComponent();

            btnLogin.Click += btnLogin_Click;
            btnRegister.Click += btnRegister_Click;

            this.AcceptButton = btnLogin;

            this.KeyPreview = true;
            this.KeyDown += LoginForm_KeyDown;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text?.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter email and password.");
                return;
            }

            var user = _authService.Login(email, password);

            if (user == null)
            {
                MessageBox.Show("Invalid email or password.");
                return;
            }

            bool isAdmin = user.IsAdmin;

            this.Hide(); // IMPORTANT: do not Close()

            try
            {
                if (isAdmin)
                {
                    
                    using (var adminDash = new AdminDashboardForm(user))
                    {
                        adminDash.ShowDialog(this);
                    }
                }
                else
                {
              
                    using (var userDash = new UserDashboardForm(user))
                    {
                        userDash.ShowDialog(this);
                    }
                }
            }
            finally
            {
                // If the form was disposed somewhere else, do not touch it
                if (!this.IsDisposed)
                {
                    txtPassword.Clear();
                    txtEmail.Focus();
                    this.Show();
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();

            try
            {
                using (var reg = new RegisterForm())
                {
                    reg.ShowDialog(this);
                }
            }
            finally
            {
                if (!this.IsDisposed)
                {
                    txtPassword.Clear();
                    txtEmail.Focus();
                    this.Show();
                }
            }
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Application.Exit(); // closes the whole app cleanly
        }
    }
}
