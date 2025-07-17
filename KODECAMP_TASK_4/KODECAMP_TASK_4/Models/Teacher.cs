using System;
using System.Collections.Generic;

namespace SchoolManagement.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime HireDate { get; set; }

        public List<Course> Courses { get; set; } = new List<Course>();
    }
}
