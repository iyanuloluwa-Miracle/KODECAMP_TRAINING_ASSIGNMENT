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
    public class StudentController : ControllerBase
    {
        private readonly StudentService _studentService;
        public StudentController(StudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var students = _studentService.GetAll()
                .Select(s => new StudentDto {
                    Id = s.Id,
                    FullName = s.FullName,
                    Email = s.Email,
                    PhoneNumber = s.PhoneNumber,
                    Gender = s.Gender,
                    DateOfBirth = s.DateOfBirth
                });
            return Ok(students);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var student = _studentService.GetById(id);
            if (student == null) return NotFound(new { message = "Student not found" });
            var dto = new StudentDto {
                Id = student.Id,
                FullName = student.FullName,
                Email = student.Email,
                PhoneNumber = student.PhoneNumber,
                Gender = student.Gender,
                DateOfBirth = student.DateOfBirth
            };
            return Ok(dto);
        }

        /// <summary>
        /// Creates a new student.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /api/student
        ///     {
        ///         "fullName": "John Smith",
        ///         "email": "john.smith@example.com",
        ///         "phoneNumber": "08087654321",
        ///         "gender": "Male",
        ///         "dateOfBirth": "2010-05-15T00:00:00.000Z"
        ///     }
        /// </remarks>
        [HttpPost]
        public IActionResult Create([FromBody] Student student)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var created = _studentService.Create(student);
            var dto = new StudentDto {
                Id = created.Id,
                FullName = created.FullName,
                Email = created.Email,
                PhoneNumber = created.PhoneNumber,
                Gender = created.Gender,
                DateOfBirth = created.DateOfBirth
            };
            return CreatedAtAction(nameof(Get), new { id = dto.Id }, dto);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Student student)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var updated = _studentService.Update(id, student);
            if (!updated) return NotFound(new { message = "Student not found" });
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var deleted = _studentService.Delete(id);
            if (!deleted) return NotFound(new { message = "Student not found" });
            return NoContent();
        }
    }
}
