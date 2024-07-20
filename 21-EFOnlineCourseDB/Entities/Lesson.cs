namespace _21_EFOnlineCourseDB.Entities
{
    public class Lesson : BaseEntity
    {
        public string? Name { get; set; }
        public Course? Course { get; set; } //Navigation Property

    }
}
