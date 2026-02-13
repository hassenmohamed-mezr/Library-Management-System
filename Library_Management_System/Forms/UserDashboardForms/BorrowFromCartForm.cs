using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Library_Management_System.Services;

namespace Library_Management_System
{
    public partial class BorrowFromCartForm : Form
    {
        private readonly User _currentUser;
        private readonly HashSet<int> _cartBookIds;
        private readonly BookService _bookService = new BookService();
        private readonly BorrowService _borrowService = new BorrowService();
        private List<Book> _cartBooks;

        public BorrowFromCartForm(User currentUser, HashSet<int> cartBookIds)
        {
            InitializeComponent();
            FormTheme.Apply(this);
            _currentUser = currentUser;
            _cartBookIds = cartBookIds;

            LoadCartBooks();

            // Events
            btnBack.Click += (s, e) => this.Close();
            btnSelectAll.Click += (s, e) => SelectAllBooks();
            btnClearSelection.Click += (s, e) => ClearSelection();
            btnBorrowSelected.Click += BtnBorrowSelected_Click;
            gridCart.SelectionChanged += GridCart_SelectionChanged;
        }

        private void LoadCartBooks()
        {
            try
            {
                _cartBooks = _bookService.GetBooksByIds(_cartBookIds.ToList());

                var displayList = _cartBooks.Select(b => new
                {
                    b.BookId,
                    b.Title,
                    b.Author,
                    b.Category,
                    b.AvailableCopies,
                    Status = b.AvailableCopies > 0 ? "Available ✓" : "Not Available ✗"
                }).ToList();

                gridCart.DataSource = displayList;

                // Select all available books by default
                SelectAllBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
        }

        private void SelectAllBooks()
        {
            for (int i = 0; i < gridCart.Rows.Count; i++)
            {
                var status = gridCart.Rows[i].Cells["Status"].Value.ToString();
                if (status.Contains("✓"))
                {
                    gridCart.Rows[i].Selected = true;
                }
            }
            UpdateSelectionCount();
        }

        private void ClearSelection()
        {
            gridCart.ClearSelection();
            UpdateSelectionCount();
        }

        private void GridCart_SelectionChanged(object sender, EventArgs e)
        {
            UpdateSelectionCount();
        }

        private void UpdateSelectionCount()
        {
            int count = gridCart.SelectedRows.Count;
            lblSelectedCount.Text = $"Selected: {count} book(s)";
        }

        private void BtnBorrowSelected_Click(object sender, EventArgs e)
        {
            if (gridCart.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select books to borrow", "Warning");
                return;
            }

            // Check password
            if (txtPassword.Text != _currentUser.Password)
            {
                MessageBox.Show("Wrong password", "Error");
                return;
            }

            if (!chkAcceptTerms.Checked)
            {
                MessageBox.Show("Accept terms first", "Warning");
                return;
            }

            // Get selected books
            List<int> selectedBookIds = new List<int>();
            foreach (DataGridViewRow row in gridCart.SelectedRows)
            {
                int bookId = Convert.ToInt32(row.Cells["BookId"].Value);
                string status = row.Cells["Status"].Value.ToString();

                if (status.Contains("✓")) // Available
                {
                    selectedBookIds.Add(bookId);
                }
            }

            if (selectedBookIds.Count == 0)
            {
                MessageBox.Show("No available books selected", "Warning");
                return;
            }

            // Confirm
            var result = MessageBox.Show(
                $"Borrow {selectedBookIds.Count} book(s)?",
                "Confirm Borrow",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                int successCount = 0;

                foreach (int bookId in selectedBookIds)
                {
                    var book = _cartBooks.First(b => b.BookId == bookId);

                    bool success = _borrowService.BorrowBook(
                        _currentUser.UserId,
                        bookId,
                        book.Title,
                        true);

                    if (success)
                    {
                        successCount++;
                        // Remove from cart after successful borrow
                        _cartBookIds.Remove(bookId);
                    }
                }

                MessageBox.Show($"Successfully borrowed {successCount} book(s)", "Done");

                // Refresh list
                LoadCartBooks();

                // If cart is empty, close form
                if (_cartBookIds.Count == 0)
                {
                    this.Close();
                }
            }
        }
    }
}