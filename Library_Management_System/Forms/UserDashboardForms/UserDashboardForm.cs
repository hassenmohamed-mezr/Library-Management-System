using System;
using System.Windows.Forms;
using System.Collections.Generic;


namespace Library_Management_System
{
    public partial class UserDashboardForm : Form
    {
        private readonly User _currentUser;
        private readonly HashSet<int> _cartBookIds = new HashSet<int>();
        private void OpenBorrowFromCart()
        {
            if (_cartBookIds.Count == 0)
            {
                MessageBox.Show("Your cart is empty. Add books first.");
                return;
            }

            this.Hide();
            using (var borrowForm = new BorrowFromCartForm(_currentUser, _cartBookIds))
            {
                borrowForm.Owner = this;
                borrowForm.ShowDialog();
            }
            this.Show();
            this.Activate();

        }

        public UserDashboardForm(User currentUser)
        {
            InitializeComponent();
            FormTheme.Apply(this);

            _currentUser = currentUser;

            lblWelcome.Text = _currentUser == null
                ? "Welcome"
                : $"Welcome, {_currentUser.FullName}";
            btnBack.Click += (s, e) => this.Close(); 
            btnLogout.Click += (s, e) => Application.Exit();  // Logout -> exit the app completely

            // Temporary placeholders
            btnSearchBooks.Click += (s, e) =>
            {
                using (var f = new UserSearchBooksForm(_cartBookIds))
                {
                    f.ShowDialog();
                }
            };


            btnBorrowBook.Click += (s, e) => OpenBorrowFromCart();

            btnReturnBook.Click += (s, e) =>
            {
                this.Hide();
                using (var returnForm = new ReturnBookForm(_currentUser))
                {
                    returnForm.Owner = this;
                    returnForm.ShowDialog();
                }
                this.Show();
                this.Activate();
            };


            btnMyHistory.Click += (s, e) =>
            {
                this.Hide();
                using (var historyForm = new MyBorrowHistoryForm(_currentUser))
                {
                    historyForm.Owner = this;
                    historyForm.ShowDialog();
                }
                this.Show();
                this.Activate();

            };


        }
    }
}
