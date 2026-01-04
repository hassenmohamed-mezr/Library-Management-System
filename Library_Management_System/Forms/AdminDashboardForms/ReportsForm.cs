using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Library_Management_System.Services;

namespace Library_Management_System
{
    public partial class ReportsForm : Form
    {
        private readonly BookService _bookService = new BookService();
        private readonly AuthService _authService = new AuthService();
        private readonly BorrowService _borrowService = new BorrowService();

        public ReportsForm()
        {
            InitializeComponent();

            // Link events
            btnBack.Click += (s, e) => this.Close();
            btnGenerateTrend.Click += BtnGenerateTrend_Click;
            btnGenerateFinancial.Click += BtnGenerateFinancial_Click;
            btnPrintReport.Click += BtnPrintReport_Click;
            cmbReportType.SelectedIndexChanged += CmbReportType_SelectedIndexChanged;

            // Init form
            InitializeForm();

            // Keyboard
            this.KeyPreview = true;
            this.KeyDown += ReportsForm_KeyDown;
        }

        private void InitializeForm()
        {
            try
            {
                // Load summary
                LoadSummaryData();

                // Set default dates
                dtpStartDate.Value = DateTime.Now.AddMonths(-1);
                dtpEndDate.Value = DateTime.Now;
                dtpFinancialStart.Value = DateTime.Now.AddMonths(-1);
                dtpFinancialEnd.Value = DateTime.Now;

                // Set default period
                cmbTrendPeriod.SelectedIndex = 2; // Monthly
                cmbReportType.SelectedIndex = 0; // Summary

                // Load initial reports
                LoadPopularBooks();
                LoadUserActivity();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Init error: {ex.Message}", "Error");
            }
        }

        private void LoadSummaryData()
        {
            try
            {
                // Total books
                var allBooks = _bookService.GetAllBooks();
                lblTotalBooksValue.Text = allBooks.Count.ToString();

                // Total users
                var allUsers = _authService.GetAllUsers();
                lblTotalUsersValue.Text = allUsers.Count.ToString();

                // Active borrows
                var activeBorrows = _borrowService.GetCurrentBorrows();
                lblActiveBorrowsValue.Text = activeBorrows.Count.ToString();

                // Total fees
                decimal totalFees = 0;
                var allBorrows = _borrowService.GetAllBorrows();
                foreach (var borrow in allBorrows)
                {
                    if (borrow.TotalFee.HasValue)
                        totalFees += borrow.TotalFee.Value;
                }
                lblTotalFeesValue.Text = $"{totalFees:N0} EGP";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Load error: {ex.Message}", "Error");
            }
        }

        private void BtnGenerateTrend_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime startDate = dtpStartDate.Value;
                DateTime endDate = dtpEndDate.Value;
                string period = cmbTrendPeriod.SelectedItem.ToString();

                if (startDate > endDate)
                {
                    MessageBox.Show("Start date > End date", "Error");
                    return;
                }

                // Get borrows in period
                var allBorrows = _borrowService.GetAllBorrows();
                var periodBorrows = allBorrows
                    .Where(b => b.BorrowDate >= startDate && b.BorrowDate <= endDate)
                    .ToList();

                // Group by period
                List<object> trendData = new List<object>();

                switch (period)
                {
                    case "Daily":
                        trendData = periodBorrows
                            .GroupBy(b => b.BorrowDate.Date)
                            .Select(g => new
                            {
                                Period = g.Key.ToString("yyyy-MM-dd"),
                                Borrows = g.Count(),
                                Returns = g.Count(b => b.IsReturned),
                                Fees = g.Sum(b => b.TotalFee ?? 0)
                            })
                            .Cast<object>()
                            .ToList();
                        break;

                    case "Weekly":
                        trendData = periodBorrows
                            .GroupBy(b => $"{b.BorrowDate.Year}-W{GetWeekOfYear(b.BorrowDate)}")
                            .Select(g => new
                            {
                                Period = g.Key,
                                Borrows = g.Count(),
                                Returns = g.Count(b => b.IsReturned),
                                Fees = g.Sum(b => b.TotalFee ?? 0)
                            })
                            .Cast<object>()
                            .ToList();
                        break;

                    case "Monthly":
                        trendData = periodBorrows
                            .GroupBy(b => b.BorrowDate.ToString("yyyy-MM"))
                            .Select(g => new
                            {
                                Period = g.Key,
                                Borrows = g.Count(),
                                Returns = g.Count(b => b.IsReturned),
                                Fees = g.Sum(b => b.TotalFee ?? 0)
                            })
                            .Cast<object>()
                            .ToList();
                        break;

                    case "Yearly":
                        trendData = periodBorrows
                            .GroupBy(b => b.BorrowDate.Year)
                            .Select(g => new
                            {
                                Period = g.Key.ToString(),
                                Borrows = g.Count(),
                                Returns = g.Count(b => b.IsReturned),
                                Fees = g.Sum(b => b.TotalFee ?? 0)
                            })
                            .Cast<object>()
                            .ToList();
                        break;
                }

                gridBorrowTrends.DataSource = trendData;
                MessageBox.Show($"Generated {trendData.Count} records", "Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Trend error: {ex.Message}", "Error");
            }
        }

        private void LoadPopularBooks()
        {
            try
            {
                var allBorrows = _borrowService.GetAllBorrows();
                var allBooks = _bookService.GetAllBooks();

                var popularBooks = allBooks
                    .Select(b => new
                    {
                        b.BookId,
                        b.Title,
                        b.Author,
                        b.Category,
                        TotalBorrows = allBorrows.Count(br => br.BookId == b.BookId),
                        ActiveBorrows = allBorrows.Count(br => br.BookId == b.BookId && !br.IsReturned),
                        Availability = $"{b.AvailableCopies}/{b.TotalCopies}"
                    })
                    .OrderByDescending(b => b.TotalBorrows)
                    .Take(20)
                    .ToList();

                gridPopularBooks.DataSource = popularBooks;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Popular books error: {ex.Message}", "Error");
            }
        }

        private void LoadUserActivity()
        {
            try
            {
                var allUsers = _authService.GetAllUsers();
                var allBorrows = _borrowService.GetAllBorrows();

                var userActivity = allUsers
                    .Select(u => new
                    {
                        u.UserId,
                        u.FullName,
                        u.Email,
                        TotalBorrows = allBorrows.Count(b => b.UserId == u.UserId),
                        ActiveBorrows = allBorrows.Count(b => b.UserId == u.UserId && !b.IsReturned),
                        TotalFees = allBorrows.Where(b => b.UserId == u.UserId).Sum(b => b.TotalFee ?? 0),
                        LastBorrow = allBorrows.Where(b => b.UserId == u.UserId)
                            .OrderByDescending(b => b.BorrowDate)
                            .FirstOrDefault()?.BorrowDate.ToString("yyyy-MM-dd") ?? "Never"
                    })
                    .OrderByDescending(u => u.TotalBorrows)
                    .ToList();

                gridUserActivity.DataSource = userActivity;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"User activity error: {ex.Message}", "Error");
            }
        }

        private void BtnGenerateFinancial_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime startDate = dtpFinancialStart.Value;
                DateTime endDate = dtpFinancialEnd.Value;

                if (startDate > endDate)
                {
                    MessageBox.Show("Start date > End date", "Error");
                    return;
                }

                var allBorrows = _borrowService.GetAllBorrows();
                var financialData = allBorrows
                    .Where(b => b.BorrowDate >= startDate && b.BorrowDate <= endDate && b.TotalFee.HasValue)
                    .Select(b => new
                    {
                        b.BorrowId,
                        User = GetUserName(b.UserId),
                        Book = GetBookTitle(b.BookId),
                        b.BorrowDate,
                        b.ReturnDate,
                        Days = b.ReturnDate.HasValue ? (b.ReturnDate.Value - b.BorrowDate).Days : 0,
                        Fee = b.TotalFee ?? 0,
                        Status = b.IsReturned ? "Paid" : "Pending"
                    })
                    .OrderByDescending(b => b.Fee)
                    .ToList();

                gridFinancial.DataSource = financialData;

                // Show totals
                decimal totalFees = financialData.Sum(b => b.Fee);
                MessageBox.Show($"Total fees: {totalFees:N0} EGP\nRecords: {financialData.Count}", "Financial Report");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Financial error: {ex.Message}", "Error");
            }
        }

        private void BtnPrintReport_Click(object sender, EventArgs e)
        {
            try
            {
                string reportType = cmbReportType.SelectedItem.ToString();
                string reportContent = GenerateReportContent(reportType);
                txtReportContent.Text = reportContent;

                MessageBox.Show("Report generated. Use Print dialog.", "Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Print error: {ex.Message}", "Error");
            }
        }

        private void CmbReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string reportType = cmbReportType.SelectedItem.ToString();
                string reportContent = GenerateReportContent(reportType);
                txtReportContent.Text = reportContent;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Report error: {ex.Message}", "Error");
            }
        }

        private string GenerateReportContent(string reportType)
        {
            string content = "";
            DateTime now = DateTime.Now;

            switch (reportType)
            {
                case "Summary Report":
                    content = $"LIBRARY MANAGEMENT SYSTEM\n";
                    content += $"SUMMARY REPORT\n";
                    content += $"Generated: {now:yyyy-MM-dd HH:mm}\n";
                    content += $"================================\n";
                    content += $"Total Books: {lblTotalBooksValue.Text}\n";
                    content += $"Total Users: {lblTotalUsersValue.Text}\n";
                    content += $"Active Borrows: {lblActiveBorrowsValue.Text}\n";
                    content += $"Total Fees: {lblTotalFeesValue.Text}\n";
                    content += $"================================\n";
                    break;

                case "Borrow Trends":
                    content = $"BORROW TRENDS REPORT\n";
                    content += $"Period: {dtpStartDate.Value:yyyy-MM-dd} to {dtpEndDate.Value:yyyy-MM-dd}\n";
                    content += $"Generated: {now:yyyy-MM-dd HH:mm}\n";
                    content += $"================================\n";

                    if (gridBorrowTrends.DataSource != null)
                    {
                        var data = (List<object>)gridBorrowTrends.DataSource;
                        foreach (dynamic item in data)
                        {
                            content += $"{item.Period}: {item.Borrows} borrows, {item.Returns} returns, {item.Fees} EGP\n";
                        }
                    }
                    break;

                case "Popular Books":
                    content = $"POPULAR BOOKS REPORT\n";
                    content += $"Generated: {now:yyyy-MM-dd HH:mm}\n";
                    content += $"================================\n";

                    if (gridPopularBooks.DataSource != null)
                    {
                        var data = (List<object>)gridPopularBooks.DataSource;
                        foreach (dynamic item in data.Take(10))
                        {
                            content += $"{item.Title} by {item.Author}: {item.TotalBorrows} borrows\n";
                        }
                    }
                    break;

                case "User Activity":
                    content = $"USER ACTIVITY REPORT\n";
                    content += $"Generated: {now:yyyy-MM-dd HH:mm}\n";
                    content += $"================================\n";

                    if (gridUserActivity.DataSource != null)
                    {
                        var data = (List<object>)gridUserActivity.DataSource;
                        foreach (dynamic item in data.Take(10))
                        {
                            content += $"{item.FullName}: {item.TotalBorrows} borrows, {item.TotalFees} EGP\n";
                        }
                    }
                    break;

                case "Financial Report":
                    content = $"FINANCIAL REPORT\n";
                    content += $"Period: {dtpFinancialStart.Value:yyyy-MM-dd} to {dtpFinancialEnd.Value:yyyy-MM-dd}\n";
                    content += $"Generated: {now:yyyy-MM-dd HH:mm}\n";
                    content += $"================================\n";

                    if (gridFinancial.DataSource != null)
                    {
                        var data = (List<object>)gridFinancial.DataSource;
                        decimal total = 0;
                        foreach (dynamic item in data)
                        {
                            content += $"{item.BorrowDate:yyyy-MM-dd}: {item.User} - {item.Book} = {item.Fee} EGP\n";
                            total += item.Fee;
                        }
                        content += $"================================\n";
                        content += $"TOTAL: {total:N0} EGP\n";
                    }
                    break;
            }

            return content;
        }

        // Helper methods
        private int GetWeekOfYear(DateTime date)
        {
            System.Globalization.CultureInfo ci = System.Globalization.CultureInfo.CurrentCulture;
            return ci.Calendar.GetWeekOfYear(date, System.Globalization.CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }

        private string GetUserName(int userId)
        {
            var user = _authService.GetAllUsers().FirstOrDefault(u => u.UserId == userId);
            return user?.FullName ?? "Unknown";
        }

        private string GetBookTitle(int bookId)
        {
            var book = _bookService.GetAllBooks().FirstOrDefault(b => b.BookId == bookId);
            return book?.Title ?? "Unknown";
        }

        private void ReportsForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();

            // Refresh on F5
            if (e.KeyCode == Keys.F5)
            {
                LoadSummaryData();
                LoadPopularBooks();
                LoadUserActivity();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            // Clean up
        }
    }
}