using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Library_Management_System.Services;

namespace Library_Management_System
{
    public partial class MyBorrowHistoryForm : Form
    {
        private readonly User _currentUser;
        private readonly BorrowService _borrowService = new BorrowService();
        private List<Borrow> _allBorrows;

        public MyBorrowHistoryForm(User currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;

            LoadBorrowHistory();

            btnBack.Click += (s, e) => this.Close();
            btnShowAll.Click += (s, e) => ShowAllBorrows();
            btnShowReturned.Click += (s, e) => ShowReturnedBorrows();
            btnShowCurrent.Click += (s, e) => ShowCurrentBorrows();
            btnPrintSummary.Click += BtnPrintSummary_Click;
        }

        private void LoadBorrowHistory()
        {
            try
            {
                _allBorrows = _borrowService.GetBorrowHistory(_currentUser.UserId);
                ShowAllBorrows();
                UpdateSummary();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading history: {ex.Message}");
            }
        }

        private void ShowAllBorrows()
        {
            BindBorrowsGrid(_allBorrows);
            lblFilterStatus.Text = "Showing: All Borrows";
        }

        private void ShowReturnedBorrows()
        {
            var returned = _allBorrows.FindAll(b => b.IsReturned);
            BindBorrowsGrid(returned);
            lblFilterStatus.Text = "Showing: Returned Books";
        }

        private void ShowCurrentBorrows()
        {
            var current = _allBorrows.FindAll(b => !b.IsReturned);
            BindBorrowsGrid(current);
            lblFilterStatus.Text = "Showing: Current Borrows";
        }

        private void BindBorrowsGrid(List<Borrow> borrows)
        {
            var displayList = new List<object>();

            foreach (var borrow in borrows)
            {
                displayList.Add(new
                {
                    borrow.BorrowId,
                    borrow.BookId,
                    BookTitle = GetBookTitle(borrow.BookId),
                    BorrowDate = borrow.BorrowDate.ToString("yyyy-MM-dd"),
                    ReturnDate = borrow.IsReturned ? borrow.ReturnDate?.ToString("yyyy-MM-dd") : "Not Returned",
                    Status = borrow.IsReturned ? "Returned" : "Borrowed",
                    TotalFee = borrow.TotalFee.HasValue ? $"{borrow.TotalFee.Value} EGP" : "N/A"
                });
            }

            gridHistory.DataSource = displayList;
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

        private void UpdateSummary()
        {
            int totalBorrows = _allBorrows.Count;
            int returnedCount = _allBorrows.FindAll(b => b.IsReturned).Count;
            int currentCount = totalBorrows - returnedCount;

            decimal totalFees = 0;
            foreach (var borrow in _allBorrows)
            {
                if (borrow.TotalFee.HasValue)
                    totalFees += borrow.TotalFee.Value;
            }

            lblTotalBorrows.Text = totalBorrows.ToString();
            lblReturnedCount.Text = returnedCount.ToString();
            lblCurrentCount.Text = currentCount.ToString();
            lblTotalFees.Text = $"{totalFees} EGP";
        }

        private void BtnPrintSummary_Click(object sender, EventArgs e)
        {
            string summary = $"Borrow History Summary for {_currentUser.FullName}\n" +
                           $"==========================================\n" +
                           $"Total Borrows: {lblTotalBorrows.Text}\n" +
                           $"Returned: {lblReturnedCount.Text}\n" +
                           $"Current: {lblCurrentCount.Text}\n" +
                           $"Total Fees Paid: {lblTotalFees.Text}\n" +
                           $"==========================================\n" +
                           $"Generated on: {DateTime.Now:yyyy-MM-dd HH:mm}";

            MessageBox.Show(summary, "Borrow History Summary", MessageBoxButtons.OK);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}