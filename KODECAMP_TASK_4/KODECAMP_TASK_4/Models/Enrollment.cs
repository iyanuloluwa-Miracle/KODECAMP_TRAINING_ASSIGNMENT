using System;
using System.Collections.Generic;

namespace SchoolManagement.Models
{
    public class Enrollment
    {
        public int Id { get; set; }
        public DateTime EnrollDate { get; set; }
        public Student? Student { get; set; }
        public Course? Course { get; set; }
        public string? Grade { get; set; }
    }
}
