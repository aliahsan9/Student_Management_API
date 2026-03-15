namespace Student_Management_API.Interfaces
{
    public interface ICourse
    {
        public void GetAll();
        public void GetByIdAsync();
        public void AddAsync();
        public void UpdateAsync();
        public void DeleteAsync(); 
    }
}
