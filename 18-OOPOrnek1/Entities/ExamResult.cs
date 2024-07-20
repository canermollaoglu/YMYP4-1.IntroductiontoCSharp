using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOPOrnek1.Entities
{
    public class ExamResult : BaseEntity
    {
        public byte Grade { get; set; }
        public Student Student { get; set; }
        public Exam Exam { get; set; }

        public override string ToString()
        {
            return $"{Student.NameSurname}-{Exam.Name}-{Exam.Date.ToShortDateString()}-{Grade}";
        }
    }
}
