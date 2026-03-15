namespace Student_Management_API.Entities
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        
        // Foreign key to Department
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }

        // Courses taught by this teacher
        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
