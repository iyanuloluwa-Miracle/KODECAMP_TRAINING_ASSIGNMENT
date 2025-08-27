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
            var courses = _courseService.GetAll();
            return Ok(courses);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var course = _courseService.GetById(id);
            if (course == null) return NotFound();
            return Ok(course);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Course course)
        {
            var created = _courseService.Create(course);
            return CreatedAtAction(nameof(Get), new { id = created.Id }, created);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Course course)
        {
            var updated = _courseService.Update(id, course);
            if (!updated) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var deleted = _courseService.Delete(id);
            if (!deleted) return NotFound();
            return NoContent();
        }
    }
}
