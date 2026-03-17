using Microsoft.AspNetCore.Mvc;
using Student_Management_API.Entities;
using Student_Management_API.Interfaces;

namespace Student_Management_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EnrollmentController : ControllerBase
    {
        private readonly IEnrollment _repository;
        public EnrollmentController(IEnrollment repository)
        {
            _repository = repository;
        }
        [HttpGet]        
        public async Task<IActionResult> GetAll()
        {
            var enrollments = await _repository.GetAllAsync(); 
            return Ok(enrollments);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var enrollment = await _repository.GetByIdAsync(id);
            if (enrollment == null)
                return NotFound();
            return Ok(enrollment);
        }
        [HttpPost]
        public async Task<IActionResult> AddAsync([FromBody] Enrollment enrollment)
        {
            await _repository.AddAsync(enrollment);
            return Ok(enrollment);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id, [FromBody] Enrollment enrollment)
        {
            if (id != enrollment.Id)
                return BadRequest();
            await _repository.UpdateAsync(enrollment);
            return Ok(enrollment);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var deleted = await _repository.DeleteAsync(id);
            if (deleted == null)
                return NotFound();
            return Ok(deleted);
        }
    }
}
