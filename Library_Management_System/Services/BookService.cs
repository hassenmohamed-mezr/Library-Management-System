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

        public List<Book> GetAllBooks()
        {
            return _context.Books.ToList();
        }

        public bool AddBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
            return true;
        }

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

        public bool DeleteBook(int bookId)
        {
            var book = _context.Books.FirstOrDefault(b => b.BookId == bookId);
            if (book == null)
                return false;

            bool hasHistory = _context.Borrows.Any(b => b.BookId == bookId);
            if (hasHistory)
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

        public List<Book> SearchByTitle(string title)
        {
            string titleLower = title.ToLower();
            return _context.Books
                .Where(b => b.Title != null && b.Title.ToLower().Contains(titleLower))
                .ToList();
        }

        public List<Book> SearchByAuthor(string author)
        {
            string authorLower = author.ToLower();
            return _context.Books
                .Where(b => b.Author != null && b.Author.ToLower().Contains(authorLower))
                .ToList();
        }

        public List<Book> SearchByCategory(string category)
        {
            string categoryLower = category.ToLower();
            return _context.Books
                .Where(b => b.Category != null && b.Category.ToLower().Contains(categoryLower))
                .ToList();
        }

        public List<Book> SearchAny(string keyword)
        {
            string keywordLower = keyword.ToLower();
            return _context.Books
                .Where(b =>
                    (b.Title != null && b.Title.ToLower().Contains(keywordLower)) ||
                    (b.Author != null && b.Author.ToLower().Contains(keywordLower)) ||
                    (b.Category != null && b.Category.ToLower().Contains(keywordLower)))
                .ToList();
        }

        public Book GetBookById(int bookId)
        {
            return _context.Books.FirstOrDefault(b => b.BookId == bookId);
        }

        public bool HasActiveBorrows(int bookId)
        {
            return _context.Borrows.Any(b => b.BookId == bookId && !b.IsReturned);
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
