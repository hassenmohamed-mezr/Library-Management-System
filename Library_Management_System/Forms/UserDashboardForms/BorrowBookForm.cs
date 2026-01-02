using System;
using System.Windows.Forms;
using Library_Management_System.Services;

namespace Library_Management_System
{
    public partial class BorrowBookForm : Form
    {
        private readonly User _currentUser;
        private readonly BorrowService _borrowService = new BorrowService();

        public BorrowBookForm(User currentUser)
        {
            InitializeComponent();

            _currentUser = currentUser;

            btnBack.Click += (s, e) => this.Close();
            btnBorrow.Click += btnBorrow_Click;
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (_currentUser == null)
            {
                MessageBox.Show("No user session found.");
                return;
            }

            string enteredPassword = txtPassword.Text;
            if (string.IsNullOrWhiteSpace(enteredPassword))
            {
                MessageBox.Show("Please enter your password to confirm.");
                return;
            }

            if (enteredPassword != _currentUser.Password)
            {
                MessageBox.Show("Incorrect password.");
                return;
            }

            if (!chkAccept.Checked)
            {
                MessageBox.Show("You must accept the terms before borrowing.");
                return;
            }

            // Check if both BookId and BookName are provided
            if (string.IsNullOrWhiteSpace(txtBookId.Text) || string.IsNullOrWhiteSpace(txtBookName.Text))
            {
                MessageBox.Show("Please enter both BookId and Book Name.");
                return;
            }

            int bookId;
            if (!int.TryParse(txtBookId.Text, out bookId))
            {
                MessageBox.Show("Please enter a valid BookId.");
                return;
            }

            // Assuming we have a way to validate if the book exists using the bookId or name
            bool bookExists = _borrowService.ValidateBook(bookId, txtBookName.Text);

            if (!bookExists)
            {
                MessageBox.Show("The book with the provided ID and Name doesn't exist.");
                return;
            }

            // Proceed with borrowing the book
            bool success = _borrowService.BorrowBook(_currentUser.UserId, bookId, txtBookName.Text, acceptedTerms: true);


            if (success)
            {
                MessageBox.Show("Borrowing successful.");
            }
            else
            {
                MessageBox.Show("Failed to borrow the book.");
            }
        }
    }
}
