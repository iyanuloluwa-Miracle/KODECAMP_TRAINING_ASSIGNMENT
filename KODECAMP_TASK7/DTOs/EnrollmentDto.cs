using System.ComponentModel.DataAnnotations;

namespace KODECAMP_TASK7.DTOs
{
    public class EnrollmentDto
    {
        public int Id { get; set; }
        [Required]
        public int StudentId { get; set; }
        [Required]
        public int CourseId { get; set; }
        public DateTime? EnrollDate { get; set; }
        public string? Grade { get; set; }
    }
}
