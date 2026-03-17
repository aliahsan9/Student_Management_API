using Microsoft.AspNetCore.Mvc;
using Student_Management_API.Entities;
using Student_Management_API.Interfaces;
using Student_Management_API.Repositories;

namespace Student_Management_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController(StudentRepository repository) : ControllerBase
    {
        private readonly StudentRepository _repository = repository;

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var students = await _repository.GetAllAsync();
            return Ok(students);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var student = await _repository.GetByIdAsync(id);

            if (student == null)
                return NotFound();

            return Ok(student);
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync([FromBody] Student student)
        {
            await _repository.AddAsync(student);
            return Ok(student);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id, [FromBody] Student student)
        {
            if (id != student.Id)
                return BadRequest();

            await _repository.UpdateAsync(student);
            return Ok(student);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
            return Ok();
        }
    }
}