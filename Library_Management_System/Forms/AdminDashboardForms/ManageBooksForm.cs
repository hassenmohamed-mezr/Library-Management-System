using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Library_Management_System.Services;

namespace Library_Management_System
{
    public partial class ManageBooksForm : Form
    {
        private readonly BookService _bookService = new BookService();
        private List<Book> _allBooks;
        private int _currentBookId = -1;

        public ManageBooksForm()
        {
            InitializeComponent();
            FormTheme.Apply(this);

            
            btnBack.Click += (s, e) => this.Close();
            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            btnClear.Click += BtnClear_Click;
            btnSearch.Click += BtnSearch_Click;

            
            InitializeForm();

            
            this.KeyPreview = true;
            this.KeyDown += ManageBooksForm_KeyDown;
        }

        private void InitializeForm()
        {
            try
            {
                
                LoadAllBooks();

                
                cmbSearchBy.SelectedIndex = 0;

                
                numTotalCopies.Minimum = 0;
                numTotalCopies.Maximum = 1000;
                numAvailableCopies.Minimum = 0;
                numAvailableCopies.Maximum = 1000;

               
                tabControl.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing form: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAllBooks()
        {
            try
            {
                _allBooks = _bookService.GetAllBooks();
                BindBooksGrid(_allBooks);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading books: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindBooksGrid(List<Book> books)
        {
            var displayList = books.Select(b => new
            {
                b.BookId,
                b.Title,
                b.Author,
                b.Category,
                b.TotalCopies,
                b.AvailableCopies,
                Status = b.AvailableCopies > 0 ? "Available" : "Out of Stock"
            }).ToList();

            gridBooks.DataSource = displayList;
            gridSearchResults.DataSource = displayList;
        }

        private void gridBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = gridBooks.Rows[e.RowIndex];
                _currentBookId = Convert.ToInt32(row.Cells["BookId"].Value);

                
                tabControl.SelectedIndex = 1;

                
                LoadBookDetails(_currentBookId);
            }
        }

        private void LoadBookDetails(int bookId)
        {
            try
            {
                var book = _allBooks.FirstOrDefault(b => b.BookId == bookId);
                if (book != null)
                {
                    txtBookId.Text = book.BookId.ToString();
                    txtTitle.Text = book.Title;
                    txtAuthor.Text = book.Author;
                    txtCategory.Text = book.Category;
                    numTotalCopies.Value = book.TotalCopies;
                    numAvailableCopies.Value = book.AvailableCopies;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading book details: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (!ValidateBookData())
                    return;

                var newBook = new Book
                {
                    Title = txtTitle.Text.Trim(),
                    Author = txtAuthor.Text.Trim(),
                    Category = txtCategory.Text.Trim(),
                    TotalCopies = (int)numTotalCopies.Value,
                    AvailableCopies = (int)numAvailableCopies.Value,
                    CreatedAt = DateTime.Now
                };

                
                if (newBook.AvailableCopies > newBook.TotalCopies)
                {
                    MessageBox.Show("Available copies cannot exceed total copies.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool success = _bookService.AddBook(newBook);

                if (success)
                {
                    MessageBox.Show("Book added successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    LoadAllBooks();
                    BtnClear_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Failed to add book.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding book: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (_currentBookId <= 0)
                {
                    MessageBox.Show("Please select a book to update.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!ValidateBookData())
                    return;

                var updatedBook = new Book
                {
                    BookId = _currentBookId,
                    Title = txtTitle.Text.Trim(),
                    Author = txtAuthor.Text.Trim(),
                    Category = txtCategory.Text.Trim(),
                    TotalCopies = (int)numTotalCopies.Value,
                    AvailableCopies = (int)numAvailableCopies.Value
                };

                
                if (updatedBook.AvailableCopies > updatedBook.TotalCopies)
                {
                    MessageBox.Show("Available copies cannot exceed total copies.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool success = _bookService.UpdateBook(updatedBook);

                if (success)
                {
                    MessageBox.Show("Book updated successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    LoadAllBooks();
                    BtnClear_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Failed to update book. Book may not exist.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating book: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (_currentBookId <= 0)
                {
                    MessageBox.Show("Please select a book to delete.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                var result = MessageBox.Show(
                    $"Are you sure you want to delete this book?\nTitle: {txtTitle.Text}",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    bool success = _bookService.DeleteBook(_currentBookId);

                    if (success)
                    {
                        MessageBox.Show("Book deleted successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        
                        LoadAllBooks();
                        BtnClear_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete book. It may have borrow history.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting book: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
           
            _currentBookId = -1;
            txtBookId.Text = "New Book";
            txtTitle.Clear();
            txtAuthor.Clear();
            txtCategory.Clear();
            numTotalCopies.Value = 0;
            numAvailableCopies.Value = 0;

            
            tabControl.SelectedIndex = 0;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtSearchKeyword.Text.Trim();
                if (string.IsNullOrWhiteSpace(keyword))
                {
                    MessageBox.Show("Please enter a search keyword.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                List<Book> searchResults;
                string searchBy = cmbSearchBy.SelectedItem.ToString();

                switch (searchBy)
                {
                    case "All Fields":
                        searchResults = _bookService.SearchAny(keyword);
                        break;
                    case "Title":
                        searchResults = _bookService.SearchByTitle(keyword);
                        break;
                    case "Author":
                        searchResults = _bookService.SearchByAuthor(keyword);
                        break;
                    case "Category":
                        searchResults = _bookService.SearchByCategory(keyword);
                        break;
                    default:
                        searchResults = _allBooks;
                        break;
                }

                
                var displayResults = searchResults.Select(b => new
                {
                    b.BookId,
                    b.Title,
                    b.Author,
                    b.Category,
                    b.TotalCopies,
                    b.AvailableCopies,
                    Status = b.AvailableCopies > 0 ? "Available" : "Out of Stock"
                }).ToList();

                gridSearchResults.DataSource = displayResults;

                
                MessageBox.Show($"Found {searchResults.Count} book(s) matching '{keyword}'",
                    "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching books: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateBookData()
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Please enter book title.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitle.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAuthor.Text))
            {
                MessageBox.Show("Please enter author name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAuthor.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCategory.Text))
            {
                MessageBox.Show("Please enter category.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCategory.Focus();
                return false;
            }

            if (numTotalCopies.Value < 0)
            {
                MessageBox.Show("Total copies cannot be negative.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numTotalCopies.Focus();
                return false;
            }

            if (numAvailableCopies.Value < 0)
            {
                MessageBox.Show("Available copies cannot be negative.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numAvailableCopies.Focus();
                return false;
            }

            return true;
        }

        private void ManageBooksForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();

            
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.N: 
                        BtnClear_Click(null, null);
                        break;
                    case Keys.S: 
                        if (tabControl.SelectedIndex == 1)
                        {
                            if (_currentBookId <= 0)
                                BtnAdd_Click(null, null);
                            else
                                BtnUpdate_Click(null, null);
                        }
                        break;
                    case Keys.F: 
                        tabControl.SelectedIndex = 2;
                        txtSearchKeyword.Focus();
                        break;
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            
            if (tabControl.SelectedIndex == 1 && _currentBookId > 0 && !string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                var result = MessageBox.Show("You have unsaved changes. Close anyway?",
                    "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                    e.Cancel = true;
            }
        }
    }
}