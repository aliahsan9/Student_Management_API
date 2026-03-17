using Microsoft.EntityFrameworkCore;
using Student_Management_API.Data;
using Student_Management_API.Entities;
using Student_Management_API.Interfaces;

namespace Student_Management_API.Repositories
{
    public class EnrollmentRepository : IEnrollment
    {
        private readonly AppDbContext _context;
        public EnrollmentRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Enrollment>> GetAllAsync() 
        {
           return await _context.Enrollments.ToListAsync();
        }
        public async Task<Enrollment?> GetByIdAsync(int id)
        {
            return await _context.Enrollments.FindAsync(id);
        }
        public async Task AddAsync(Enrollment enrollment)
        {
             _context.Enrollments.Add(enrollment);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Enrollment enrollment)
        {
             _context.Enrollments.Update(enrollment);
            await _context.SaveChangesAsync();
        }
        public async Task<Enrollment?> DeleteAsync(int id)
        {
            var enrollment = await _context.Enrollments.FindAsync(id);
            if (enrollment == null)
                return null;
             _context.Enrollments.Remove(enrollment);
            await _context.SaveChangesAsync();
            return enrollment;
        }
    }
}
