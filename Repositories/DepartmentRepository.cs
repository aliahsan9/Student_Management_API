using Microsoft.EntityFrameworkCore;
using Student_Management_API.Data;
using Student_Management_API.Entities;
using Student_Management_API.Interfaces;

namespace Student_Management_API.Repositories
{
    public class DepartmentRepository(AppDbContext context) : IDepartment
    {
        private readonly AppDbContext _context = context;

        public async Task<IEnumerable<Department>> GetAll()
        {
            return await _context.Departments.ToListAsync();
        }
        public async Task<Department?> GetByIdAsync(int id)
        {
            return await _context.Departments.FindAsync(id);
        }
        public async Task AddAsync(Department department)
        {
            _context.Departments.Add(department);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Department department)
        {
            _context.Departments.Update(department);
            await _context.SaveChangesAsync();
        }
        public async Task<Department> DeleteAsync(int id)
        {
            var department = await _context.Departments.FindAsync(id);
            if (department == null)
                return null!;
            _context.Departments.Remove(department);
            await _context.SaveChangesAsync();
            return department;
        }
    }
}

