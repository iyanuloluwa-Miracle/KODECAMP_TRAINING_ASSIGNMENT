using SchoolManagement.Models;
using SchoolManagement.Data;

namespace KODECAMP_TASK7.Services
{
    public class StudentService
    {
        private readonly SchoolDbContext _context;
        public StudentService(SchoolDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Student> GetAll()
        {
            return _context.Students.ToList();
        }

        public Student? GetById(int id)
        {
            return _context.Students.Find(id);
        }

        public Student Create(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return student;
        }

        public bool Update(int id, Student student)
        {
            var existing = _context.Students.Find(id);
            if (existing == null) return false;
            existing.FullName = student.FullName;
            existing.Email = student.Email;
            existing.PhoneNumber = student.PhoneNumber;
            existing.Gender = student.Gender;
            existing.DateOfBirth = student.DateOfBirth;
            _context.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            var student = _context.Students.Find(id);
            if (student == null) return false;
            _context.Students.Remove(student);
            _context.SaveChanges();
            return true;
        }
    }
}
