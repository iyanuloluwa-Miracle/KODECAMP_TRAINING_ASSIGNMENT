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

        public IEnumerable<Course> GetAll()
        {
            return _context.Courses.ToList();
        }

        public Course? GetById(int id)
        {
            return _context.Courses.Find(id);
        }

        public Course Create(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
            return course;
        }

        public bool Update(int id, Course course)
        {
            var existing = _context.Courses.Find(id);
            if (existing == null) return false;
            existing.Title = course.Title;
            existing.Description = course.Description;
            existing.Teacher = course.Teacher;
            _context.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            var course = _context.Courses.Find(id);
            if (course == null) return false;
            _context.Courses.Remove(course);
            _context.SaveChanges();
            return true;
        }
    }
}
