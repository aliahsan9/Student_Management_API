namespace Student_Management_API.Entities
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public Department? Department { get; set; }
        public ICollection<Course>? Courses { get; set; }  
    }
}
