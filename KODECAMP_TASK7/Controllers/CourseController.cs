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
            // TODO: Use _courseService to get all courses
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            // TODO: Use _courseService to get course by id
            return Ok();
        }

        [HttpPost]
        public IActionResult Create([FromBody] Course course)
        {
            // TODO: Use _courseService to create course
            return CreatedAtAction(nameof(Get), new { id = course.Id }, course);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Course course)
        {
            // TODO: Use _courseService to update course
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // TODO: Use _courseService to delete course
            return NoContent();
        }
    }
}
