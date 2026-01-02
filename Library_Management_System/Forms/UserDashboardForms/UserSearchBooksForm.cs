using Library_Management_System.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class UserSearchBooksForm : Form
    {
        private readonly BookService _bookService = new BookService();
        private readonly HashSet<int> _cartBookIds;

        public UserSearchBooksForm(HashSet<int> cartBookIds)
        {
            InitializeComponent();

            _cartBookIds = cartBookIds ?? new HashSet<int>();

            btnBack.Click += (s, e) => this.Close();

            btnSearchTitle.Click += (s, e) => SearchTitle();
            btnSearchAuthor.Click += (s, e) => SearchAuthor();
            btnSearchCategory.Click += (s, e) => SearchCategory();

            // This requires a Button named btnAddToCart in the Designer
            btnAddToCart.Click += btnAddToCart_Click;
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (gridBooks.CurrentRow == null)
            {
                MessageBox.Show("Please select a book first.");
                return;
            }

            var val = gridBooks.CurrentRow.Cells["BookId"]?.Value;
            if (val == null)
            {
                MessageBox.Show("BookId not found.");
                return;
            }

            if (!int.TryParse(val.ToString(), out int bookId) || bookId <= 0)
            {
                MessageBox.Show("Invalid BookId.");
                return;
            }

            bool added = _cartBookIds.Add(bookId);
            MessageBox.Show(added ? "Added to cart." : "Already in cart.");
        }

        private void SearchTitle()
        {
            string title = txtTitle.Text?.Trim();
            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Please enter a title.");
                return;
            }

            try
            {
                var books = _bookService.SearchByTitle(title);
                BindBooks(books);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search failed: " + ex.Message);
            }
        }

        private void SearchAuthor()
        {
            string author = txtAuthor.Text?.Trim();
            if (string.IsNullOrWhiteSpace(author))
            {
                MessageBox.Show("Please enter an author name.");
                return;
            }

            try
            {
                var books = _bookService.SearchByAuthor(author);
                BindBooks(books);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search failed: " + ex.Message);
            }
        }

        private void SearchCategory()
        {
            string category = txtCategory.Text?.Trim();
            if (string.IsNullOrWhiteSpace(category))
            {
                MessageBox.Show("Please enter a category.");
                return;
            }

            try
            {
                var books = _bookService.SearchByCategory(category);
                BindBooks(books);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search failed: " + ex.Message);
            }
        }

        private void BindBooks(List<Book> books)
        {
            gridBooks.DataSource = books.Select(b => new
            {
                b.BookId,
                b.Title,
                b.Author,
                b.Category,
                b.TotalCopies,
                b.AvailableCopies
            }).ToList();
        }
    }
}
