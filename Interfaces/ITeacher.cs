using Student_Management_API.Entities;

namespace Student_Management_API.Interfaces
{
    public interface ITeacher
    {
        Task<IEnumerable<Teacher>> GetAllAsync();
        Task<Teacher?> GetByIdAsync(int id);
        Task AddAsync(Teacher teacher);
        Task UpdateAsync(Teacher teacher);
        Task<Teacher> DeleteAsync(int id);


    }
}
