using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Student_Management_API.Entities;
using Student_Management_API.Repositories;

namespace Student_Management_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeacherController(TeacherRepository repository) : ControllerBase
    {
        private readonly TeacherRepository _repository = repository;

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
           var teacher = await _repository.GetAllAsync();
            return Ok(teacher);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var teacher = await _repository.GetByIdAsync(id);
            if (teacher == null)
                return NotFound();

            return Ok(teacher);
        }
        [HttpPost]
        public async Task<IActionResult> AddAsync([FromBody] Teacher teacher, int id)
        {
            await _repository.AddAsync(teacher);
            return Ok(teacher);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync([FromBody] Teacher teacher,int id)
        {
            if (id != teacher.Id)
                return BadRequest();
            await _repository.UpdateAsync(teacher);
            return Ok(teacher);
        }
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
            return Ok();
        }
    }
}
