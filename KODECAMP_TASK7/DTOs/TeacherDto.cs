using System.ComponentModel.DataAnnotations;

namespace KODECAMP_TASK7.DTOs
{
    public class TeacherDto
    {
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
        public string? PhoneNumber { get; set; }
    }
}
