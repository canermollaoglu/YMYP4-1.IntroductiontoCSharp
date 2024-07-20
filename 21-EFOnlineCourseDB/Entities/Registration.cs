namespace _21_EFOnlineCourseDB.Entities
{
    public class Registration
    {
        public DateTime RegisterDate { get; set; } = DateTime.Now;
        public Course? Course { get; set; }
        public Student? Student { get; set; }
        public Guid CourseID { get; set; }
        public Guid StudentID { get; set; }
        public decimal Price { get; set; }
    }
}
