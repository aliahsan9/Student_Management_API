namespace Student_Management_API.Interfaces
{
    public interface ITeacher
    {
        public void GetAll();
        public void GetByIdAsync();
        public void AddAsync();
        public void UpdateAasync();
        public void DeleteAsync();
    }
}
