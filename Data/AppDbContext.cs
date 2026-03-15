using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Student_Management_API.Entities;

namespace Student_Management_API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options)
            :base(options)
        { }
        public  DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
    }
}
