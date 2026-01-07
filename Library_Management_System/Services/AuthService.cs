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
            return _context.Users
                .FirstOrDefault(u => u.Email == email && u.Password == password);
        }
        //*************************************************************


        // GetAllUser 
        public List<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }
        //*************************************************************


        // CreatNewUser
        public bool Register(User user)
        {
            if (_context.Users.Any(u => u.Email == user.Email))
                return false;

            user.IsAdmin = false;
            _context.Users.Add(user);
            _context.SaveChanges();
            return true;
        }
        //*************************************************************


        // UpdateUser
        public bool UpdateUser(User updatedUser)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserId == updatedUser.UserId);
            if (user == null)
                return false;

            user.FullName = updatedUser.FullName;
            user.Email = updatedUser.Email;
            user.Phone = updatedUser.Phone;

            
            if (!string.IsNullOrWhiteSpace(updatedUser.Password))
                user.Password = updatedUser.Password;

            user.IsAdmin = updatedUser.IsAdmin;

            _context.SaveChanges();
            return true;
        }
        //*************************************************************

        //DeleteUser
        public bool DeleteUser(int userId)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserId == userId);
            if (user == null)
                return false;

            
            var activeBorrows = _context.Borrows.Any(b => b.UserId == userId && !b.IsReturned);
            if (activeBorrows)
            {
                return false; 
            }

            _context.Users.Remove(user);
            _context.SaveChanges();
            return true;
        }
    }

}

