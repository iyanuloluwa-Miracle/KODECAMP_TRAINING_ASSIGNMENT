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
            var enrollments = _enrollmentService.GetAll();
            return Ok(enrollments);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var enrollment = _enrollmentService.GetById(id);
            if (enrollment == null) return NotFound();
            return Ok(enrollment);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Enrollment enrollment)
        {
            var created = _enrollmentService.Create(enrollment);
            return CreatedAtAction(nameof(Get), new { id = created.Id }, created);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Enrollment enrollment)
        {
            var updated = _enrollmentService.Update(id, enrollment);
            if (!updated) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var deleted = _enrollmentService.Delete(id);
            if (!deleted) return NotFound();
            return NoContent();
        }
    }
}
