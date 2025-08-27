using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolManagement.Data;
using SchoolManagement.Models;
using KODECAMP_TASK7.Services;
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
            // TODO: Use _studentService to get all students
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            // TODO: Use _studentService to get student by id
            return Ok();
        }

        [HttpPost]
        public IActionResult Create([FromBody] Student student)
        {
            // TODO: Use _studentService to create student
            return CreatedAtAction(nameof(Get), new { id = student.Id }, student);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Student student)
        {
            // TODO: Use _studentService to update student
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // TODO: Use _studentService to delete student
            return NoContent();
        }
    }
}
