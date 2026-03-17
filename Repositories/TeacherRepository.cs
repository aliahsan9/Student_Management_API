using Microsoft.EntityFrameworkCore;
using Student_Management_API.Data;
using Student_Management_API.Entities;
using Student_Management_API.Interfaces;

namespace Student_Management_API.Repositories
{
    public class TeacherRepository(AppDbContext context) : ITeacher
    {
        private readonly AppDbContext _context = context;

        public async Task<IEnumerable<Teacher>> GetAllAsync()
        {
            return await _context.Teachers.ToListAsync();
        }
        public async Task<Teacher?> GetByIdAsync(int id)
        {
            return await _context.Teachers.FindAsync(id); 
        }
        public async Task AddAsync(Teacher teacher)
        {
            await _context.Teachers.AddAsync(teacher);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Teacher teacher)
        {
            _context.Teachers.Update(teacher);
            await _context.SaveChangesAsync();
        }
        public async Task<Teacher> DeleteAsync(int id)
        {
            var student = await _context.Teachers.FindAsync(id);
            if (student == null)
                return null!;

             _context.Teachers.Remove(student);
            await _context.SaveChangesAsync();
            return student;
        }

      }
}
