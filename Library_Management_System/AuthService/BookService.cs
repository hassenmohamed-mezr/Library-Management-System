using System.Collections.Generic;
using System.Linq;

namespace Library_Management_System.Services
{
    public class BookService
    {
        private readonly LibraryDBEntities _context;

        public BookService()
        {
            _context = new LibraryDBEntities();
        }

        // Get all books
        public List<Book> GetAllBooks()
        {
            return _context.Books.ToList();
        }

        // Add new book
        public bool AddBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
            return true;
        }

        // Update existing book
        public bool UpdateBook(Book updatedBook)
        {
            var book = _context.Books.FirstOrDefault(b => b.BookId == updatedBook.BookId);
            if (book == null)
                return false;

            book.Title = updatedBook.Title;
            book.Author = updatedBook.Author;
            book.Category = updatedBook.Category;
            book.TotalCopies = updatedBook.TotalCopies;
            book.AvailableCopies = updatedBook.AvailableCopies;

            _context.SaveChanges();
            return true;
        }

        // Delete book
        public bool DeleteBook(int bookId)
        {
            var book = _context.Books.FirstOrDefault(b => b.BookId == bookId);
            if (book == null)
                return false;

            _context.Books.Remove(book);
            _context.SaveChanges();
            return true;
        }
        public List<Book> GetBooksByIds(List<int> bookIds)
        {
            return _context.Books
                .Where(b => bookIds.Contains(b.BookId))
                .ToList();
        }


        // Search books

        public List<Book> SearchByTitle(string title)
        {
            return _context.Books
                .Where(b => b.Title.Contains(title))
                .ToList();
        }

        public List<Book> SearchByAuthor(string author)
        {
            return _context.Books
                .Where(b => b.Author.Contains(author))
                .ToList();
        }

        public List<Book> SearchByCategory(string category)
        {
            return _context.Books
                .Where(b => b.Category.Contains(category))
                .ToList();
        }

        public List<Book> SearchAny(string keyword)
        {
            return _context.Books
                .Where(b =>
                    b.Title.Contains(keyword) ||
                    b.Author.Contains(keyword) ||
                    b.Category.Contains(keyword))
                .ToList();
        }
    }
}

