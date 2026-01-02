using System;
using System.Windows.Forms;
using System.Collections.Generic;


namespace Library_Management_System
{
    public partial class UserDashboardForm : Form
    {
        private readonly User _currentUser;
        private readonly HashSet<int> _cartBookIds = new HashSet<int>();


        public UserDashboardForm(User currentUser)
        {
            InitializeComponent();

            _currentUser = currentUser;

            lblWelcome.Text = _currentUser == null
                ? "Welcome"
                : $"Welcome, {_currentUser.FullName}";
            btnBack.Click += (s, e) => this.Hide(); // Hide the Dashboard, do not close it
            btnLogout.Click += (s, e) => Application.Exit();  // Logout -> exit the app completely

            // Temporary placeholders
            btnSearchBooks.Click += (s, e) =>
            {
                using (var f = new UserSearchBooksForm(_cartBookIds))
                {
                    f.ShowDialog();
                }
            };


            btnBorrowBook.Click += (s, e) =>
            {
                this.Hide();  

                using (var borrowForm = new BorrowBookForm(_currentUser))
                {
                    borrowForm.Owner = this;  
                    borrowForm.ShowDialog();  
                }

                this.Show();  
                this.Activate();
            };



            btnReturnBook.Click += (s, e) => MessageBox.Show("Return Book - not implemented yet.");
            btnMyHistory.Click += (s, e) => MessageBox.Show("My Borrow History - not implemented yet.");
        }
    }
}
