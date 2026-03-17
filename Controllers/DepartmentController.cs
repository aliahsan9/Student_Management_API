using Microsoft.AspNetCore.Mvc;
using Student_Management_API.Entities;
using Student_Management_API.Interfaces;

namespace Student_Management_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentController(IDepartment repository) : ControllerBase
    {
        private readonly IDepartment _repository = repository;
   
    [HttpGet]
    public async Task<IActionResult> GetAll()
        {
            var departments = await _repository.GetAllAsync(); 
            return Ok(departments);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var department = await _repository.GetByIdAsync(id);
            if (department == null)
                return NotFound();
            return Ok(department);
        }
        [HttpPost]
        public async Task<IActionResult> AddAsync([FromBody] Department department)
        {
            await _repository.AddAsync(department);
            return Ok(department);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id, [FromBody] Department department)
        {
            if (id != department.Id)
                return BadRequest(department);
            await _repository.UpdateAsync(department);
            return Ok(department);
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
