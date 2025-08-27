using SchoolManagement.Models;
using SchoolManagement.Data;

namespace KODECAMP_TASK7.Services
{
    public class EnrollmentService
    {
        private readonly SchoolDbContext _context;
        public EnrollmentService(SchoolDbContext context)
        {
            _context = context;
        }
        // Add methods for enrollment operations here
    }
}
