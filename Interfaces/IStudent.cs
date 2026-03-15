namespace Student_Management_API.Interfaces
{
    public interface IStudent
    {
        public void GetAll();
        public void GetByIdAsync();
        public void AddAsync();
        public void UpdateAsync();
        public void DeleteAsync(); 
    }
}
