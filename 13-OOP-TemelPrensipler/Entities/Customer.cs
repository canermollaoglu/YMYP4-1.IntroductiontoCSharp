using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_OOP_TemelPrensipler.Entities
{
    public class Customer
    {
        public string CustomerID { get; } = Guid.NewGuid().ToString();
        public string CustomerName { get; set; }
        public string EmailAddress { get; set; }
        public string Country { get; set; } = "Türkiye";
        public bool IsActive { get; set; } = true;
    }
}
