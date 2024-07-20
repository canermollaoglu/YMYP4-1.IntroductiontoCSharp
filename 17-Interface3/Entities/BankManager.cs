using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Interface3.Entities
{
    public class BankManager
    {
        IBankManager _bankManager;
        public BankManager(IBankManager bmr)
        {
            _bankManager = bmr;
        }

        public string Ekle()
        {
           return _bankManager.AddTransaction();
        }

        public string Sil(int id)
        {
            return _bankManager.DeleteTransaction(id);
        }

        public string Guncelle(int id)
        {
            return _bankManager.UpdateTransaction(id);
        }
    }
}
