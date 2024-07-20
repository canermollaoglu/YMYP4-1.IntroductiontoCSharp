using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOPOrnek1.Entities
{
    public class Student : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string NameSurname
        {
            get
            {
                return $"{Name} {Surname}";
            }
        }

        
        public string FullName => Name + " " + Surname;

        public DateTime BirthDate { get; set; }
        public string TCKimlik { get; set; }
        public List<Registration> Registrations { get; set; } = new();
        public List<ExamResult> ExamResults { get; set; } = new();

        public override string ToString()
        {
            return NameSurname;
        }
    }
}
