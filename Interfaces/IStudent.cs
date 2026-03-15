using Student_Management_API.Entities;

namespace Student_Management_API.Interfaces
{
    public interface IStudent
    {
        Task<IEnumerable<Student>> GetAllAsync();
        Task<Student?> GetByIdAsync(int id);
        Task AddAsync(Student student);
        Task UpdateAsync(Student student);
        Task<Student> DeleteAsync(int id);
    }
}
