using Microsoft.AspNetCore.Mvc;
using Student_Management_API.Entities;
using Student_Management_API.Repositories;

namespace Student_Management_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EnrollmentController : ControllerBase
    {
        private readonly EnrollmentRepository _repository;
        public EnrollmentController(EnrollmentRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]        
        public async Task<IActionResult> GetAll()
        {
            await _repository.GetAllAsync(); 
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var enrollment = await _repository.GetByIdAsync(id);
            if (id != enrollment.Id)
                return NotFound(enrollment);
            await _repository.GetByIdAsync(id);
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> AddAsync([FromBody] Enrollment enrollment)
        {
            await _repository.AddAsync(enrollment);
            return Ok();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id, [FromBody] Enrollment enrollment)
        {
            if (id != enrollment.Id)
                return BadRequest();
            await _repository.UpdateAsync(enrollment);
            return Ok();
        }
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
            return Ok();
        }
    }
}
