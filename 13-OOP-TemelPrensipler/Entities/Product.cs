using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_OOP_TemelPrensipler.Entities
{
    //public - private
    //Access Modifier (Erişim Belirleyici)
    public class Product
    {
        //field (alan)
        private string productname;
        private int stok = 100;

        //property (özellik
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int StockQuantity { get; set; }
        public double UnitPrice { get; set; }

        //method (metod)

        public void SellProduct(int id)
        {
            stok--;
        }

        public void UpdatePrice(int id, double newPrice)
        {

        }
    }
}
