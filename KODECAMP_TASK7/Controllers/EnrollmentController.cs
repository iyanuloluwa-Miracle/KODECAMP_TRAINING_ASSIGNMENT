using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolManagement.Data;
using SchoolManagement.Models;
using KODECAMP_TASK7.Services;
using KODECAMP_TASK7.DTOs;
using Microsoft.AspNetCore.Authorization;

namespace SchoolManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class EnrollmentController : ControllerBase
    {
        private readonly EnrollmentService _enrollmentService;
        public EnrollmentController(EnrollmentService enrollmentService)
        {
            _enrollmentService = enrollmentService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var enrollments = _enrollmentService.GetAll()
                .Select(e => new EnrollmentDto {
                    Id = e.Id,
                    StudentId = e.Student?.Id ?? e.StudentId,
                    CourseId = e.Course?.Id ?? e.CourseId,
                    EnrollDate = e.EnrollDate,
                    Grade = e.Grade
                });
            return Ok(enrollments);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var enrollment = _enrollmentService.GetById(id);
            if (enrollment == null) return NotFound(new { message = "Enrollment not found" });
            var dto = new EnrollmentDto {
                Id = enrollment.Id,
                StudentId = enrollment.Student?.Id ?? enrollment.StudentId,
                CourseId = enrollment.Course?.Id ?? enrollment.CourseId,
                EnrollDate = enrollment.EnrollDate,
                Grade = enrollment.Grade
            };
            return Ok(dto);
        }

        /// <summary>
        /// Creates a new enrollment.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /api/enrollment
        ///     {
        ///         "studentId": 1,
        ///         "courseId": 1,
        ///         "enrollDate": "2025-08-28T06:14:44.324Z",
        ///         "grade": "A"
        ///     }
        /// </remarks>
        [HttpPost]
        public IActionResult Create([FromBody] Enrollment enrollment)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var created = _enrollmentService.Create(enrollment);
            var dto = new EnrollmentDto {
                Id = created.Id,
                StudentId = created.Student?.Id ?? created.StudentId,
                CourseId = created.Course?.Id ?? created.CourseId,
                EnrollDate = created.EnrollDate,
                Grade = created.Grade
            };
            return CreatedAtAction(nameof(Get), new { id = dto.Id }, dto);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Enrollment enrollment)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var updated = _enrollmentService.Update(id, enrollment);
            if (!updated) return NotFound(new { message = "Enrollment not found" });
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var deleted = _enrollmentService.Delete(id);
            if (!deleted) return NotFound(new { message = "Enrollment not found" });
            return NoContent();
        }
    }
}
