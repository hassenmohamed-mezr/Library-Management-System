using System;
using System.Collections.Generic;
using System.Configuration;
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

        public bool BorrowBook(int userId, int bookId, string bookName, bool acceptedTerms)
        {
            var userExists = _context.Users.Any(u => u.UserId == userId);
            if (!userExists)
                return false;

            var book = _context.Books.FirstOrDefault(b => b.BookId == bookId && b.Title.Equals(bookName, StringComparison.OrdinalIgnoreCase));
            if (book == null || book.AvailableCopies <= 0)
                return false;

            var fees = LoadDefaultFees();
            var borrow = new Borrow
            {
                UserId = userId,
                BookId = bookId,
                BorrowDate = DateTime.Now,
                IsReturned = false,
                BaseDailyFee = fees.baseDailyFee,
                ExtraDailyFee = fees.extraDailyFee,
                AcceptedTerms = acceptedTerms
            };

            book.AvailableCopies -= 1;

            _context.Borrows.Add(borrow);
            _context.SaveChanges();

            return true;
        }

        public bool ReturnBook(int borrowId)
        {
            var borrow = _context.Borrows.FirstOrDefault(b => b.BorrowId == borrowId);
            if (borrow == null || borrow.IsReturned)
                return false;

            borrow.IsReturned = true;
            borrow.ReturnDate = DateTime.Now;

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

        public List<Borrow> GetCurrentBorrows()
        {
            return _context.Borrows
                .Where(b => b.IsReturned == false)
                .ToList();
        }

        public List<Borrow> GetBorrowHistory(int userId)
        {
            return _context.Borrows
                .Where(b => b.UserId == userId)
                .ToList();
        }

        public bool ValidateBook(int bookId, string bookName)
        {
            var book = _context.Books
                .FirstOrDefault(b => b.BookId == bookId &&
                b.Title.Equals(bookName, StringComparison.OrdinalIgnoreCase));

            return book != null && book.AvailableCopies > 0;
        }

        public List<Borrow> GetAllBorrows()
        {
            return _context.Borrows.ToList();
        }

        public List<Borrow> GetBorrowsInPeriod(DateTime startDate, DateTime endDate)
        {
            return _context.Borrows
                .Where(b => b.BorrowDate >= startDate && b.BorrowDate <= endDate)
                .ToList();
        }

        public decimal GetTotalFeesInPeriod(DateTime startDate, DateTime endDate)
        {
            return _context.Borrows
                .Where(b => b.BorrowDate >= startDate && b.BorrowDate <= endDate && b.TotalFee.HasValue)
                .Sum(b => b.TotalFee.Value);
        }

        private (int baseDailyFee, int extraDailyFee) LoadDefaultFees()
        {
            int baseFee = ParseIntOrDefault(ConfigurationManager.AppSettings["DefaultBaseDailyFee"], 20);
            int extraFee = ParseIntOrDefault(ConfigurationManager.AppSettings["DefaultExtraDailyFee"], 40);
            return (baseFee, extraFee);
        }

        private int ParseIntOrDefault(string value, int defaultValue)
        {
            return int.TryParse(value, out int parsed) ? parsed : defaultValue;
        }
    }
}
