using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOPOrnek1.Entities
{
    public class Course : BaseEntity
    {
        public string CourseName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Instructor Educator { get; set; }
        public List<Lesson> Lessons { get; set; } = new();
        public List<Registration> Registrations { get; set; } = new();
        public override string ToString()
        {
            return $"{CourseName}";
        }
    }
}
