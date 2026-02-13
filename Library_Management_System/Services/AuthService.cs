using System.Collections.Generic;
using System.Linq;

namespace Library_Management_System.Services
{
    public class AuthService
    {
        private readonly LibraryDBEntities _context;

        public AuthService()
        {
            _context = new LibraryDBEntities();
        }

        public User Login(string email, string password)
        {
            var user = _context.Users
                .FirstOrDefault(u => u.Email == email && u.IsActive);

            if (user == null)
                return null;

            bool valid = PasswordHasher.Verify(password, user.Password);
            if (!valid)
                return null;

            // Automatic migration from legacy plain-text passwords
            if (!PasswordHasher.IsHashed(user.Password))
            {
                user.Password = PasswordHasher.Hash(password);
                _context.SaveChanges();
            }

            return user;
        }

        public List<User> GetAllUsers()
        {
            return _context.Users.Where(u => u.IsActive).ToList();
        }

        public bool Register(User user)
        {
            var existingUser = _context.Users
                .FirstOrDefault(u => u.Email == user.Email);

            if (existingUser != null)
            {
                if (!existingUser.IsActive)
                {
                    existingUser.IsActive = true;
                    existingUser.FullName = user.FullName;
                    existingUser.Password = PasswordHasher.Hash(user.Password);
                    existingUser.Phone = user.Phone;
                    existingUser.IsAdmin = false;

                    _context.SaveChanges();
                    return true;
                }

                return false;
            }

            user.IsAdmin = false;
            user.IsActive = true;
            user.Password = PasswordHasher.Hash(user.Password);
            _context.Users.Add(user);
            _context.SaveChanges();
            return true;
        }

        public bool UpdateUser(User updatedUser)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserId == updatedUser.UserId);
            if (user == null)
                return false;

            user.FullName = updatedUser.FullName;
            user.Email = updatedUser.Email;
            user.Phone = updatedUser.Phone;

            if (!string.IsNullOrWhiteSpace(updatedUser.Password))
                user.Password = PasswordHasher.Hash(updatedUser.Password);

            user.IsAdmin = updatedUser.IsAdmin;

            _context.SaveChanges();
            return true;
        }

        public bool DeleteUser(int userId)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserId == userId);
            if (user == null)
                return false;

            var activeBorrows = _context.Borrows.Any(b => b.UserId == userId && !b.IsReturned);
            if (activeBorrows)
                return false;

            user.IsActive = false;
            _context.SaveChanges();
            return true;
        }

        public List<User> GetDeletedUsers()
        {
            return _context.Users.Where(u => !u.IsActive).ToList();
        }
    }
}
