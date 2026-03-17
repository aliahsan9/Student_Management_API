using Student_Management_API.Entities;      

namespace Student_Management_API.Interfaces
{
    public interface IDepartment
    {
        Task<IEnumerable<Department>> GetAllAsync();
        Task<Department?> GetByIdAsync(int id);
        Task AddAsync(Department department);
        Task UpdateAsync(Department department);
        Task<Department?> DeleteAsync(int id);


    }
}
