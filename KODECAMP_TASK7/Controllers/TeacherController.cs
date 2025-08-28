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
    public class TeacherController : ControllerBase
    {
        private readonly TeacherService _teacherService;
        public TeacherController(TeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var teachers = _teacherService.GetAll()
                .Select(t => new TeacherDto {
                    Id = t.Id,
                    FullName = t.FullName,
                    Email = t.Email,
                    PhoneNumber = t.PhoneNumber
                });
            return Ok(teachers);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var teacher = _teacherService.GetById(id);
            if (teacher == null) return NotFound(new { message = "Teacher not found" });
            var dto = new TeacherDto {
                Id = teacher.Id,
                FullName = teacher.FullName,
                Email = teacher.Email,
                PhoneNumber = teacher.PhoneNumber
            };
            return Ok(dto);
        }

        /// <summary>
        /// Creates a new teacher.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /api/teacher
        ///     {
        ///         "fullName": "Jane Doe",
        ///         "email": "jane.doe@example.com",
        ///         "phoneNumber": "08012345678"
        ///     }
        /// </remarks>
        [HttpPost]
        public IActionResult Create([FromBody] Teacher teacher)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var created = _teacherService.Create(teacher);
            var dto = new TeacherDto {
                Id = created.Id,
                FullName = created.FullName,
                Email = created.Email,
                PhoneNumber = created.PhoneNumber
            };
            return CreatedAtAction(nameof(Get), new { id = dto.Id }, dto);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Teacher teacher)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var updated = _teacherService.Update(id, teacher);
            if (!updated) return NotFound(new { message = "Teacher not found" });
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var deleted = _teacherService.Delete(id);
            if (!deleted) return NotFound(new { message = "Teacher not found" });
            return NoContent();
        }
    }
}
