namespace Student_Management_API.Entities
{
    public class Enrollment
    {
        public int Id { get; set; }
        
        // Foreign keys
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        // Navigation properties
        public Student? Student { get; set; }
        public Course? Course { get; set; }
    }
}
