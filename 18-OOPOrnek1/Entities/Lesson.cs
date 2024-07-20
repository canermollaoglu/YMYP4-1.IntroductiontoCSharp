using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOPOrnek1.Entities
{
    public class Lesson : BaseEntity
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public byte Duration { get; set; }
        public string Content { get; set; }
        public Course Course { get; set; }
    }
}
