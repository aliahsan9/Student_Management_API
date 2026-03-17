using Student_Management_API.Entities;

namespace Student_Management_API.Interfaces
{
    public interface IEnrollment
    {
        Task<IEnumerable<Enrollment>> GetAllAsync();
        Task<Enrollment?> GetByIdAsync(int id);
        Task AddAsync(Enrollment enrollment);
        Task UpdateAsync(Enrollment enrollment);
        Task<Enrollment?> DeleteAsync(int id);
    }
}
