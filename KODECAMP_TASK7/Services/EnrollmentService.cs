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

        public IEnumerable<Enrollment> GetAll()
        {
            return _context.Enrollments.ToList();
        }

        public Enrollment? GetById(int id)
        {
            return _context.Enrollments.Find(id);
        }

        public Enrollment Create(Enrollment enrollment)
        {
            _context.Enrollments.Add(enrollment);
            _context.SaveChanges();
            return enrollment;
        }

        public bool Update(int id, Enrollment enrollment)
        {
            var existing = _context.Enrollments.Find(id);
            if (existing == null) return false;
            existing.EnrollDate = enrollment.EnrollDate;
            existing.Grade = enrollment.Grade;
            existing.Student = enrollment.Student;
            existing.Course = enrollment.Course;
            _context.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            var enrollment = _context.Enrollments.Find(id);
            if (enrollment == null) return false;
            _context.Enrollments.Remove(enrollment);
            _context.SaveChanges();
            return true;
        }
    }
}
