using Microsoft.IdentityModel.Tokens;

namespace Student_Management_API.Interfaces
{
    public interface IDepartment
    {
        public void GetAll();
        public void GetByIdAsync();
        public void AddAsync();
        public void UpdateAsync();
        public void DeleteAsync();
    }
}
