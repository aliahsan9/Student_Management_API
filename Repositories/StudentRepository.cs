using Microsoft.EntityFrameworkCore;
using Student_Management_API.Data;
using Student_Management_API.Entities;
using Student_Management_API.Interfaces;

namespace Student_Management_API.Repositories
{
    public class StudentRepository(AppDbContext context) : IStudent
    {
        private readonly AppDbContext _context = context;

        public async Task<IEnumerable<Student>> GetAllAsync()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task<Student?> GetByIdAsync(int id)
        {
            return await _context.Students.FindAsync(id);
        }

        public async Task AddAsync(Student student)
        {
            await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Student student)
        {
            _context.Students.Update(student);
            await _context.SaveChangesAsync();
        }

        public async Task<Student> DeleteAsync(int id)  
        {
            var student = await _context.Students.FindAsync(id);

            if (student == null)
                return null!;

            _context.Students.Remove(student);
            await _context.SaveChangesAsync();

            return student;
        }
    }
}