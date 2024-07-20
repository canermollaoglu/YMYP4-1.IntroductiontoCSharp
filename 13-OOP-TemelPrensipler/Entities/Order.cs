using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_OOP_TemelPrensipler.Entities
{
    public class Order
    {
        //public Order()
        //{

        //}
        public Order(int empID, int cstID)
        {
            EmployeeID = empID;
            CustomerID = cstID;
            IsActive = true;
        }

        public string OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public int EmployeeID { get; set; }
        public int CustomerID { get; set; }
        public bool IsActive { get; set; }
    }
}
