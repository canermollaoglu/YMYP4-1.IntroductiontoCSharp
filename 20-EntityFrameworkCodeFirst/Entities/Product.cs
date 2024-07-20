using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_EntityFrameworkCodeFirst.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public string? ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int CategoryID { get; set; }
        public string? Description { get; set; }
        public int UnitsInStock { get; set; }
        public Category? Category { get; set; }
    }
}
