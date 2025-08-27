using SchoolManagement.Models;
using SchoolManagement.Data;

namespace KODECAMP_TASK7.Services
{
    public class TeacherService
    {
        private readonly SchoolDbContext _context;
        public TeacherService(SchoolDbContext context)
        {
            _context = context;
        }
        // Add methods for teacher operations here
    }
}
