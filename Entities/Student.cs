namespace Student_Management_API.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        
        // Foreign key to Department
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }

        // Navigation to enrollments (each enrollment links to a course)
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }
}
