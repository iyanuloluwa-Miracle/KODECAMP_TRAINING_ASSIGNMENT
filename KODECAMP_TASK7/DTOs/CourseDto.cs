using System.ComponentModel.DataAnnotations;

namespace KODECAMP_TASK7.DTOs
{
    public class CourseDto
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int? TeacherId { get; set; }
    }
}
