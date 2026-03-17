using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Student_Management_API.Entities;
using Student_Management_API.Repositories;

namespace Student_Management_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentController(DepartmentRepository repository) : ControllerBase
    {
        private readonly DepartmentRepository _repository = repository;
   
    [HttpGet]
    public async Task<IActionResult> GetAll()
        {
            await _repository.GetAll();
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            await _repository.GetByIdAsync(id);
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> AddAsync([FromBody] Department department)
        {
            await _repository.AddAsync(department);
            return Ok();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id, [FromBody] Department department)
        {
            if (id != department.Id)
                return BadRequest(department);
            await _repository.UpdateAsync(department);
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id, [FromBody] Department department)
        {
            if (id != department.Id)
                return BadRequest(department);
            await _repository.DeleteAsync(department);
            return Ok();
        }


   }
}
