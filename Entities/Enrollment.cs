namespace Student_Management_API.Entities
{
    public class Enrollment
    {
        public int Id { get; set; }
        public Course? Course { get; set; }
        public Student? Student { get; set; }
    }
}
