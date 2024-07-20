using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Interface2.Entities
{
    public class Banka
    {
        public string BankName { get; set; }
        public int BankID { get; set; }

        public string OdemeYap()
        {
            return "Ödeme Yapıldı.";
        }
    }
}
