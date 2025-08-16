using SchoolManagement.Models;
using System;

namespace SchoolManagement.Services
{
    public static class SchoolInitializer
    {
        public static (Teacher teacher, Student student, Course engineering, Course geometry) Initialize()
        {
            // Create a teacher
            var teacher = new Teacher
            {
                Id = 1,
                FullName = "Mr. Dina Iyanuloluwa",
                Email = "iyanudina@gmail.com",
                PhoneNumber = "08012345678"
            };

            // Create courses
            var engineering = new Course
            {
                Id = 1,
                Title = "Engineering 101",
                Description = "Introduction to Mechanical Engineering",
                Teacher = teacher
            };

            var geometry = new Course
            {
                Id = 2,
                Title = "Geometry Basics",
                Description = "Fundamentals of Geometry",
                Teacher = teacher
            };

            teacher.Courses.Add(engineering);
            teacher.Courses.Add(geometry);

            // Create a student
            var student = new Student
            {
                Id = 1001,
                FullName = "Iyanuoluwa Dina",
                Email = "iyanudina@gmail.com",
                PhoneNumber = "09012345678",
                Gender = "Male",
                DateOfBirth = new DateTime(2007, 5, 12)
            };

            // Enroll student in Engineering and Geometry
            var enrollment1 = new Enrollment
            {
                Id = 1,
                Student = student,
                Course = engineering,
                EnrollDate = DateTime.Now,
                Grade = "A"
            };

            var enrollment2 = new Enrollment
            {
                Id = 2,
                Student = student,
                Course = geometry,
                EnrollDate = DateTime.Now,
                Grade = "B+"
            };

            student.Enrollments.Add(enrollment1);
            student.Enrollments.Add(enrollment2);
            engineering.Enrollments.Add(enrollment1);
            geometry.Enrollments.Add(enrollment2);

            return (teacher, student, engineering, geometry);
        }
    }
}
