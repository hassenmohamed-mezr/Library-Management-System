using System;
using System.Collections.Generic;
using System.Linq;

namespace Library_Management_System.Services
{
    public class BorrowService
    {
        private readonly LibraryDBEntities _context;

        // Constructor
        public BorrowService()
        {
            _context = new LibraryDBEntities();
        }



        // Borrow a book by BookId and BookName (with fees + terms acceptance)
        public bool BorrowBook(int userId, int bookId, string bookName, bool acceptedTerms)
        {
            // Check if the user exists
            var userExists = _context.Users.Any(u => u.UserId == userId);
            if (!userExists)
                return false;

            // Check if the book exists by BookId and BookName
            var book = _context.Books.FirstOrDefault(b => b.BookId == bookId && b.Title.Equals(bookName, StringComparison.OrdinalIgnoreCase));
            if (book == null || book.AvailableCopies <= 0)
                return false;

            // Create a new borrow record
            var borrow = new Borrow
            {
                UserId = userId,
                BookId = bookId,
                BorrowDate = DateTime.Now,
                IsReturned = false,

                // New fields (require DB + EDMX update)
                BaseDailyFee = 20,
                ExtraDailyFee = 40,
                AcceptedTerms = acceptedTerms
            };

            // Decrease the available copies of the book
            book.AvailableCopies -= 1;

            // Add the borrow record to the database
            _context.Borrows.Add(borrow);
            _context.SaveChanges();

            return true;
        }



        // Return a book (calculate total fee)
        public bool ReturnBook(int borrowId)
        {
            var borrow = _context.Borrows.FirstOrDefault(b => b.BorrowId == borrowId);
            if (borrow == null || borrow.IsReturned)
                return false;

            borrow.IsReturned = true;
            borrow.ReturnDate = DateTime.Now;

            // Calculate fee: first day 20, each extra day 40
            // Days are counted by date difference; minimum 1 day
            int days = (borrow.ReturnDate.Value.Date - borrow.BorrowDate.Date).Days;
            if (days < 1) days = 1;

            int extraDays = Math.Max(0, days - 1);
            int totalFee = borrow.BaseDailyFee + (extraDays * borrow.ExtraDailyFee);
            borrow.TotalFee = totalFee;

            var book = _context.Books.FirstOrDefault(b => b.BookId == borrow.BookId);
            if (book != null)
            {
                book.AvailableCopies += 1;
            }

            _context.SaveChanges();
            return true;
        }



        // Get the list of books that are currently borrowed (not returned)
        public List<Borrow> GetCurrentBorrows()
        {
            return _context.Borrows
                .Where(b => b.IsReturned == false)
                .ToList();
        }



        // Get borrow history of a specific user
        public List<Borrow> GetBorrowHistory(int userId)
        {
            return _context.Borrows
                .Where(b => b.UserId == userId)
                .ToList();
        }



        // Validate if a book exists with the given BookId and BookName
        public bool ValidateBook(int bookId, string bookName)
        {
            var book = _context.Books
                .FirstOrDefault(b => b.BookId == bookId &&
                b.Title.Equals(bookName, StringComparison.OrdinalIgnoreCase));

            return book != null && book.AvailableCopies > 0;
        }



        //GetAll Borrows for Admin
        public List<Borrow> GetAllBorrows()
        {
            return _context.Borrows.ToList();
        }



        // GetBorrowsInPeriod for Admin
        public List<Borrow> GetBorrowsInPeriod(DateTime startDate, DateTime endDate)
        {
            return _context.Borrows
                .Where(b => b.BorrowDate >= startDate && b.BorrowDate <= endDate)
                .ToList();
        }



        //Get Total Fees In Period
        public decimal GetTotalFeesInPeriod(DateTime startDate, DateTime endDate)
        {
            return _context.Borrows
                .Where(b => b.BorrowDate >= startDate && b.BorrowDate <= endDate && b.TotalFee.HasValue)
                .Sum(b => b.TotalFee.Value);
        }
    }
}
