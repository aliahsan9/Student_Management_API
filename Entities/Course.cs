namespace Student_Management_API.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public int CourseCode { get; set; }
        
        // Foreign key to Teacher (who teaches this course)
        public int TeacherId { get; set; }
        public Teacher? Teacher { get; set; }

        // Navigation to enrollments (students taking this course)
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }
}
