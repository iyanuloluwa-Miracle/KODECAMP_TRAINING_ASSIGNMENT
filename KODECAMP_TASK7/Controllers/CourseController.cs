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
    public class CourseController : ControllerBase
    {
        private readonly CourseService _courseService;
        public CourseController(CourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var courses = _courseService.GetAll()
                .Select(c => new CourseDto {
                    Id = c.Id,
                    Title = c.Title,
                    Description = c.Description,
                    TeacherId = c.Teacher?.Id
                });
            return Ok(courses);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var course = _courseService.GetById(id);
            if (course == null) return NotFound(new { message = "Course not found" });
            var dto = new CourseDto {
                Id = course.Id,
                Title = course.Title,
                Description = course.Description,
                TeacherId = course.Teacher?.Id
            };
            return Ok(dto);
        }

    /// <summary>
    /// Creates a new course.
    /// </summary>
    /// <remarks>
    /// Sample request:
    ///
    ///     POST /api/course
    ///     {
    ///         "title": "Mathematics",
    ///         "description": "Basic math course for beginners",
    ///         "teacher": {
    ///             "fullName": "Jane Doe",
    ///             "email": "jane.doe@example.com",
    ///             "phoneNumber": "08012345678"
    ///         }
    ///     }
    /// </remarks>
        [HttpPost]
        public IActionResult Create([FromBody] Course course)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var created = _courseService.Create(course);
            var dto = new CourseDto {
                Id = created.Id,
                Title = created.Title,
                Description = created.Description,
                TeacherId = created.Teacher?.Id
            };
            return CreatedAtAction(nameof(Get), new { id = dto.Id }, dto);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Course course)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var updated = _courseService.Update(id, course);
            if (!updated) return NotFound(new { message = "Course not found" });
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var deleted = _courseService.Delete(id);
            if (!deleted) return NotFound(new { message = "Course not found" });
            return NoContent();
        }
    }
}
