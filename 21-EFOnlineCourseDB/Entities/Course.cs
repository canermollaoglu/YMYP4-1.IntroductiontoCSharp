namespace _21_EFOnlineCourseDB.Entities
{
    public class Course : BaseEntity
    {
        public string? Name { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public Instructor? Instructor { get; set; }
        public ICollection<Lesson>? Lessons { get; set; } = new List<Lesson>(); //Navigation Property
        public ICollection<Registration>? Registrations { get; set; }
    }
}
