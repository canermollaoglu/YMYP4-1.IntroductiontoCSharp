using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOPOrnek1.Entities
{
    public class Instructor : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Profession { get; set; }
        public string PhoneNumber { get; set; }
        public List<Course> Courses { get; set; }
    }
}
