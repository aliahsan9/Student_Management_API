using Microsoft.AspNetCore.Mvc;
using Student_Management_API.Entities;
using Student_Management_API.Interfaces;

namespace Student_Management_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CourseController(ICourse repository) : ControllerBase
    {
        private readonly ICourse _repository = repository;

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var courses = await _repository.GetAllAsync();
            return Ok(courses);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var course = await _repository.GetByIdAsync(id);
            if (course == null)
                return NotFound();
            return Ok(course);
        }
        [HttpPost]
        public async Task<IActionResult> AddAsync([FromBody] Course course)
        {
            await _repository.AddAsync(course);
            return Ok(course);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id, [FromBody] Course course)
        {
            if (id != course.Id)
                return BadRequest();
            await _repository.UpdateAsync(course);
            return Ok(course);
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
