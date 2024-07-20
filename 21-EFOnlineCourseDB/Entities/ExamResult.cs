using System.ComponentModel.DataAnnotations;

namespace _21_EFOnlineCourseDB.Entities
{
    public class ExamResult
    {
        public Guid StudentID { get; set; }
        public Guid ExamID { get; set; }

        [Range(0, 100)]
        // [Column("SinavNotu")]
        public byte ExamNote { get; set; }
        public Student? Student { get; set; }
        public Exam? Exam { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

    }
}
