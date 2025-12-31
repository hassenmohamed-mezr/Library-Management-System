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

        public bool Register(User user)
        {
            if (_context.Users.Any(u => u.Email == user.Email))
                return false;

            _context.Users.Add(user);
            _context.SaveChanges();
            return true;
        }
    }
}
