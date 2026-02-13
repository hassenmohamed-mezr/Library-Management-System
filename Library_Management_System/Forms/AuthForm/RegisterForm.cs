using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using Library_Management_System.Services;

namespace Library_Management_System
{
    public partial class RegisterForm : Form
    {
        private readonly AuthService _authService = new AuthService();

        public RegisterForm()
        {
            InitializeComponent();

            btnCreate.Click += btnCreate_Click;
            btnBack.Click += btnBack_Click;

            this.AcceptButton = btnCreate;

            this.KeyPreview = true;
            this.KeyDown += RegisterForm_KeyDown;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text?.Trim();
            string email = txtEmail.Text?.Trim();
            string password = txtPassword.Text;
            string phone = txtPhone.Text?.Trim();

            if (string.IsNullOrWhiteSpace(fullName) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill Full Name, Email, and Password.");
                return;
            }

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            var user = new User
            {
                FullName = fullName,
                Email = email,
                Password = password,
                Phone = string.IsNullOrWhiteSpace(phone) ? null : phone,
                CreatedAt = DateTime.Now
            };

            bool ok = _authService.Register(user);

            if (!ok)
            {
                MessageBox.Show("This email is already registered.");
                return;
            }

            MessageBox.Show("Account created successfully.");

            this.Close();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void RegisterForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}
