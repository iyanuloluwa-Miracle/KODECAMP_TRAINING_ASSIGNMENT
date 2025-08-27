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

        public IEnumerable<Teacher> GetAll()
        {
            return _context.Teachers.ToList();
        }

        public Teacher? GetById(int id)
        {
            return _context.Teachers.Find(id);
        }

        public Teacher Create(Teacher teacher)
        {
            _context.Teachers.Add(teacher);
            _context.SaveChanges();
            return teacher;
        }

        public bool Update(int id, Teacher teacher)
        {
            var existing = _context.Teachers.Find(id);
            if (existing == null) return false;
            existing.FullName = teacher.FullName;
            existing.Email = teacher.Email;
            existing.PhoneNumber = teacher.PhoneNumber;
            _context.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            var teacher = _context.Teachers.Find(id);
            if (teacher == null) return false;
            _context.Teachers.Remove(teacher);
            _context.SaveChanges();
            return true;
        }
    }
}
