using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Library_Management_System
{
    public partial class AdminDashboardForm : Form
    {
        private readonly User _currentUser;

        public AdminDashboardForm(User currentUser)
        {
            InitializeComponent();

            _currentUser = currentUser;

            lblWelcome.Text = _currentUser == null
                ? "Welcome, Admin"
                : $"Welcome, {_currentUser.FullName} (Admin)";

            btnBack.Click += (s, e) => this.Close();          // Back -> return to Login
            btnLogout.Click += (s, e) => Application.Exit();  // Logout -> exit the app completely
        }
    }
}
