using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Interface3.Entities
{
    public class ZiraatBankasi : Bank, IBankManager
    {
        public string AddTransaction()
        {
            return "Ziraat Bankası Ekleme İşlemi";
        }

        public string DeleteTransaction(int id)
        {
            return "Ziraat Bankası Silme İşlemi";
        }

        public string UpdateTransaction(int id)
        {
            return "Ziraat Bankası Guncelleme İşlemi";
        }
    }
}
