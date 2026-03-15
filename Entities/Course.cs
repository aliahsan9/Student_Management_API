namespace Student_Management_API.Entities
{
    public class Course
    {
         public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public int CourseCode { get; set; }
        public Student? Student { get; set; }
        public Teacher? Teacher { get; set; }
    }
}
