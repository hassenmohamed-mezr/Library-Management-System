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


        //GetBooksByIds
        public List<Book> GetBooksByIds(List<int> bookIds)
        {
            return _context.Books
                .Where(b => bookIds.Contains(b.BookId))
                .ToList();
        }


        // Search books by title
        public List<Book> SearchByTitle(string title)
        {
            string titleLower = title.ToLower();
            return _context.Books
                .Where(b => b.Title.ToLower().Contains(titleLower))
                .ToList();
        }



        // Search books by author
        public List<Book> SearchByAuthor(string author)
        {
            string authorLower = author.ToLower();
            return _context.Books
                .Where(b => b.Author.ToLower().Contains(authorLower))
                .ToList();
        }



        // Search books by category
        public List<Book> SearchByCategory(string category)
        {
            string categoryLower = category.ToLower();
            return _context.Books
                .Where(b => b.Category.ToLower().Contains(categoryLower))
                .ToList();
        }


        // Search books by any field
        public List<Book> SearchAny(string keyword)
        {
            string keywordLower = keyword.ToLower();
            return _context.Books
                .Where(b =>
                    b.Title.ToLower().Contains(keywordLower) ||
                    b.Author.ToLower().Contains(keywordLower) ||
                    b.Category.ToLower().Contains(keywordLower))
                .ToList();
        }

        public Book GetBookById(int bookId)
        {
            return _context.Books.FirstOrDefault(b => b.BookId == bookId);
        }

        public bool HasActiveBorrows(int bookId)
        {
            var borrowService = new BorrowService();
            var currentBorrows = borrowService.GetCurrentBorrows();
            return currentBorrows.Any(b => b.BookId == bookId);
        }

        public Dictionary<string, int> GetBooksCountByCategory()
        {
            return _context.Books
                .GroupBy(b => b.Category)
                .Select(g => new { Category = g.Key, Count = g.Count() })
                .ToDictionary(x => x.Category, x => x.Count);
        }
    }
}

