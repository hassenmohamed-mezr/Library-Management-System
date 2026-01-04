using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Library_Management_System.Services;

namespace Library_Management_System
{
    public partial class ReturnBookForm : Form
    {
        private readonly User _currentUser;
        private readonly BorrowService _borrowService = new BorrowService();
        private List<Borrow> _currentBorrows;

        public ReturnBookForm(User currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;

            LoadCurrentBorrows();

            btnBack.Click += (s, e) => this.Close();
            btnReturnSelected.Click += BtnReturnSelected_Click;
            gridBorrows.SelectionChanged += GridBorrows_SelectionChanged;
        }

        private void LoadCurrentBorrows()
        {
            try
            {
                // Get current borrows for this user
                _currentBorrows = _borrowService.GetBorrowHistory(_currentUser.UserId)
                    .FindAll(b => b.IsReturned == false);

                BindBorrowsGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading borrows: {ex.Message}");
            }
        }

        private void BindBorrowsGrid()
        {
            var borrowsDisplay = new List<object>();

            foreach (var borrow in _currentBorrows)
            {
                borrowsDisplay.Add(new
                {
                    borrow.BorrowId,
                    borrow.BookId,
                    BookTitle = GetBookTitle(borrow.BookId),
                    BorrowDate = borrow.BorrowDate.ToString("yyyy-MM-dd"),
                    DaysBorrowed = (DateTime.Now - borrow.BorrowDate).Days,
                    EstimatedFee = CalculateEstimatedFee(borrow)
                });
            }

            gridBorrows.DataSource = borrowsDisplay;
            UpdateSelectionInfo();
        }

        private string GetBookTitle(int bookId)
        {
            try
            {
                var bookService = new BookService();
                var book = bookService.GetAllBooks().Find(b => b.BookId == bookId);
                return book?.Title ?? "Unknown";
            }
            catch
            {
                return "Unknown";
            }
        }

        private int CalculateEstimatedFee(Borrow borrow)
        {
            int days = (DateTime.Now - borrow.BorrowDate).Days;
            if (days < 1) days = 1;

            int extraDays = Math.Max(0, days - 1);
            return 20 + (extraDays * 40);
        }

        private void GridBorrows_SelectionChanged(object sender, EventArgs e)
        {
            UpdateSelectionInfo();
        }

        private void UpdateSelectionInfo()
        {
            if (gridBorrows.SelectedRows.Count > 0)
            {
                var row = gridBorrows.SelectedRows[0];
                lblSelectedBookId.Text = row.Cells["BookId"].Value.ToString();
                lblSelectedBorrowId.Text = row.Cells["BorrowId"].Value.ToString();
                lblSelectedTitle.Text = row.Cells["BookTitle"].Value.ToString();
                lblEstimatedFee.Text = $"{row.Cells["EstimatedFee"].Value} EGP";
            }
            else
            {
                lblSelectedBookId.Text = "N/A";
                lblSelectedBorrowId.Text = "N/A";
                lblSelectedTitle.Text = "N/A";
                lblEstimatedFee.Text = "0 EGP";
            }
        }

        private void BtnReturnSelected_Click(object sender, EventArgs e)
        {
            if (gridBorrows.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book to return.");
                return;
            }

            var borrowId = int.Parse(lblSelectedBorrowId.Text);

            // Confirm return
            var result = MessageBox.Show(
                $"Return this book?\nTitle: {lblSelectedTitle.Text}\nEstimated Fee: {lblEstimatedFee.Text}",
                "Confirm Return",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    bool success = _borrowService.ReturnBook(borrowId);

                    if (success)
                    {
                        MessageBox.Show("Book returned successfully!");
                        LoadCurrentBorrows(); // Refresh list
                    }
                    else
                    {
                        MessageBox.Show("Failed to return book. It may already be returned.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}