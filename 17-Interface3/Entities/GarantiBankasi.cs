using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Interface3.Entities
{
    public class GarantiBankasi : Bank, IBankManager
    {
        public string AddTransaction()
        {
            return "Garanti Bankası Ekleme İşlemi";
        }

        public string DeleteTransaction(int id)
        {
            return "Garanti Bankası Silme İşlemi";
        }

        public string UpdateTransaction(int id)
        {
            return "Garanti Bankası Guncelleme İşlemi";
        }
    }
}
