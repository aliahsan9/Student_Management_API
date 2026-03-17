using Student_Management_API.Entities;

namespace Student_Management_API.Interfaces
{
    public interface ICourse
    {
        Task<IEnumerable<Course>> GetAllAsync();
        Task<Course> GetByIdAsync(int id);
        Task AddAsync(Course course);
        Task UpdateAsync(Course course);
        Task<Course> DeleteAsync(int id);

    }
}
