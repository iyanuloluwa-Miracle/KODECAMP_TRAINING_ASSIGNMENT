using SchoolManagement.Models;

namespace KODECAMP_TASK7.Services
{
    public class AuthService
    {
        private readonly SchoolManagement.Data.SchoolDbContext _context;

        public AuthService(SchoolManagement.Data.SchoolDbContext context)
        {
            _context = context;
        }

        public bool ValidateUser(string username, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.Username == username);
            if (user == null) return false;
            var passwordHash = HashPassword(password);
            return user.PasswordHash == passwordHash;
        }

        private string HashPassword(string password)
        {
            using var sha256 = System.Security.Cryptography.SHA256.Create();
            var bytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            return System.Convert.ToBase64String(bytes);
        }
    }
}
