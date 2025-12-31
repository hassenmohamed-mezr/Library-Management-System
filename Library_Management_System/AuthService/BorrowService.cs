using System;
using System.Collections.Generic;
using System.Linq;

namespace Library_Management_System.Services
{
    public class BorrowService
    {
        private readonly LibraryDBEntities _context;

        public BorrowService()
        {
            _context = new LibraryDBEntities();
        }

        // Borrow a book
        public bool BorrowBook(int userId, int bookId)
        {
            var book = _context.Books.FirstOrDefault(b => b.BookId == bookId);
            if (book == null || book.AvailableCopies <= 0)
                return false;

            var borrow = new Borrow
            {
                UserId = userId,
                BookId = bookId,
                BorrowDate = DateTime.Now,
                IsReturned = false
            };

            book.AvailableCopies -= 1;

            _context.Borrows.Add(borrow);
            _context.SaveChanges();

            return true;
        }

        // Return a book
        public bool ReturnBook(int borrowId)
        {
            var borrow = _context.Borrows.FirstOrDefault(b => b.BorrowId == borrowId);
            if (borrow == null || borrow.IsReturned)
                return false;

            borrow.IsReturned = true;
            borrow.ReturnDate = DateTime.Now;

            var book = _context.Books.FirstOrDefault(b => b.BookId == borrow.BookId);
            if (book != null)
            {
                book.AvailableCopies += 1;
            }

            _context.SaveChanges();
            return true;
        }

        // Get current borrows (not returned)
        public List<Borrow> GetCurrentBorrows()
        {
            return _context.Borrows
                .Where(b => b.IsReturned == false)
                .ToList();
        }

        // Get borrow history for a user
        public List<Borrow> GetBorrowHistory(int userId)
        {
            return _context.Borrows
                .Where(b => b.UserId == userId)
                .ToList();
        }
    }
}
