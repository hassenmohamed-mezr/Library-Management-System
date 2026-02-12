using System.Collections.Generic;
using System.Linq;

namespace Library_Management_System.Services
{
    public class AuthService
    {
        private readonly LibraryDBEntities _context;

        // Building an object from a database
        public AuthService()
        {
            _context = new LibraryDBEntities();
        }

        // Login for activated user
        public User Login(string email, string password)
        {
            return _context.Users
                .FirstOrDefault(u => u.Email == email && u.Password == password && u.IsActive);
        }


        // Get All User if Active 
        public List<User> GetAllUsers()
        {
            return _context.Users.Where(u => u.IsActive).ToList();
        }

        
        // CreatNewUser
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
                    existingUser.Password = user.Password;
                    existingUser.Phone = user.Phone;
                    existingUser.IsAdmin = false;

                    _context.SaveChanges();
                    return true;
                }

                return false; 
            }

            user.IsAdmin = false;
            user.IsActive = true;
            _context.Users.Add(user);
            _context.SaveChanges();
            return true;
        }

        
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
        

        // Soft Delete User
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


            user.IsActive = false;
            _context.SaveChanges();
            return true;
        }


        // Get not active users
        public List<User> GetDeletedUsers()
        {

            return _context.Users.Where(u => !u.IsActive).ToList();

        }

    }

}

