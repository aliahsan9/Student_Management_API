namespace Student_Management_API.Interfaces
{
    public interface IEnrollment
    {
        public void GetAll();
        public void GetByIdAsync();
        public void AddAsync();
        public void UpdateAsync();
        public void DeleteAsync(); 
    }
}
