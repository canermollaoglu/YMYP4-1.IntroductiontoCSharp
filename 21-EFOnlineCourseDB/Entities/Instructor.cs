using System.ComponentModel.DataAnnotations;

namespace _21_EFOnlineCourseDB.Entities
{
    public class Instructor : BaseEntity
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? FullName
        {
            get
            {
                return $"{Name} {Surname}";
            }
        }

        [EmailAddress]
        public string? Email { get; set; }

        [Phone]
        public string? PhoneNumber { get; set; }
        public string? Profession { get; set; }
        public ICollection<Course>? Courses { get; set; }
    }
}
