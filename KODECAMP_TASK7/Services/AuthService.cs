using SchoolManagement.Models;

namespace KODECAMP_TASK7.Services
{
    public class AuthService
    {

        public bool ValidateUser(string username, string password)
        {
            // TODO: Implement actual authentication logic
            return username == "admin" && password == "password";
        }
    }
}
