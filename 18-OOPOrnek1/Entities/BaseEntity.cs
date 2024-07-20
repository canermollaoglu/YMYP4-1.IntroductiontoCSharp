using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOPOrnek1.Entities
{
    public class BaseEntity
    {
        public string ID { get; } = Guid.NewGuid().ToString();
        private DateTime CreatedDate { get; } = DateTime.Now;
        public bool IsActive { get; set; } = true;
    }
}
