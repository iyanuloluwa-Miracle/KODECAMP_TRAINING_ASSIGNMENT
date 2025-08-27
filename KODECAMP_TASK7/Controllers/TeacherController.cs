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
            // TODO: Use _teacherService to get all teachers
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            // TODO: Use _teacherService to get teacher by id
            return Ok();
        }

        [HttpPost]
        public IActionResult Create([FromBody] Teacher teacher)
        {
            // TODO: Use _teacherService to create teacher
            return CreatedAtAction(nameof(Get), new { id = teacher.Id }, teacher);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Teacher teacher)
        {
            // TODO: Use _teacherService to update teacher
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // TODO: Use _teacherService to delete teacher
            return NoContent();
        }
    }
}
