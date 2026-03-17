using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Student_Management_API.Data;
using Student_Management_API.Entities;
using Student_Management_API.Interfaces;

namespace Student_Management_API.Repositories
{
    public class CourseRepository : ICourse   
    {
        private readonly AppDbContext _context;
        public CourseRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Course>> GetAllAsync()
        {
            return await _context.Courses.ToListAsync();
        }
        public async Task<Course?> GetByIdAsync(int id) 
        {
            return await _context.Courses.FindAsync(id);
        }
        public async Task AddAsync(Course course)
        {
             await _context.AddAsync(course);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Course course)
        {
             _context.Courses.Update(course);
            await _context.SaveChangesAsync();
        }
        public async Task<Course> DeleteAsync(int id)
        {
            var course = await _context.Courses.FindAsync(id);
            if (course == null)
                return null!;
             _context.Courses.Remove(course);
            await _context.SaveChangesAsync();
            return course;
        }

    }
}
