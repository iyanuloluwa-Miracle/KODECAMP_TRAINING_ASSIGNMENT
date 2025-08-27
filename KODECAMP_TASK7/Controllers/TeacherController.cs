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
            var teachers = _teacherService.GetAll();
            return Ok(teachers);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var teacher = _teacherService.GetById(id);
            if (teacher == null) return NotFound();
            return Ok(teacher);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Teacher teacher)
        {
            var created = _teacherService.Create(teacher);
            return CreatedAtAction(nameof(Get), new { id = created.Id }, created);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Teacher teacher)
        {
            var updated = _teacherService.Update(id, teacher);
            if (!updated) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var deleted = _teacherService.Delete(id);
            if (!deleted) return NotFound();
            return NoContent();
        }
    }
}
