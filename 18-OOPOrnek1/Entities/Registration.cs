using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOPOrnek1.Entities
{
    public class Registration : BaseEntity
    {
        public DateTime RegistrationDate { get; set; } = DateTime.Now;
        public decimal Price { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
