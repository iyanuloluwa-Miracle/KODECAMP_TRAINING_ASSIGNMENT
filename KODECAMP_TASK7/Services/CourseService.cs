using SchoolManagement.Models;
using SchoolManagement.Data;

namespace KODECAMP_TASK7.Services
{
    public class CourseService
    {
        private readonly SchoolDbContext _context;
        public CourseService(SchoolDbContext context)
        {
            _context = context;
        }
        // Add methods for course operations here
    }
}
