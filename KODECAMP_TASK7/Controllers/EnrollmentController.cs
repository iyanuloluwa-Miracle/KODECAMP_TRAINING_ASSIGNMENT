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
            // TODO: Use _enrollmentService to get all enrollments
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            // TODO: Use _enrollmentService to get enrollment by id
            return Ok();
        }

        [HttpPost]
        public IActionResult Create([FromBody] Enrollment enrollment)
        {
            // TODO: Use _enrollmentService to create enrollment
            return CreatedAtAction(nameof(Get), new { id = enrollment.Id }, enrollment);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Enrollment enrollment)
        {
            // TODO: Use _enrollmentService to update enrollment
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // TODO: Use _enrollmentService to delete enrollment
            return NoContent();
        }
    }
}
