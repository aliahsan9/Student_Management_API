using Microsoft.AspNetCore.Mvc;
using Student_Management_API.Entities;
using Student_Management_API.Repositories;

namespace Student_Management_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CourseController(CourseRepository repository) : ControllerBase
    {
        private readonly CourseRepository _repository = repository;

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            await _repository.GetAllAsync();
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            await _repository.GetByIdAsync(id);
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult>AddAsync(Course course)
        {
            await _repository.AddAsync(course);
            return Ok();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id, [FromBody] Course course)
        {
            if (id != course.Id)
                return BadRequest();
            await _repository.UpdateAsync(course);
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync([FromBody] Course course, int id)
        {
            await _repository.DeleteAsync(id);
            return Ok();
        }

    }
}
