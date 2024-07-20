using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_BankProject.Entities
{
    public class LineOfCreditAccount : BankAccount,IMonthEndPerform
    {
        //Eksi bakiyeye düşebilir. Ancak eksi bakiye söz konusu ise her ay sonu %7 faiz gideri uygulanacaktır.
        public LineOfCreditAccount(string nameSurname, decimal initialBalance) : base(nameSurname, initialBalance)
        {

        }

        public override void MakeWithDrawal(decimal amt, DateTime dt, string nt)
        {
            if (amt <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amt), "Çekilen tutar 0'dan büyük olmalıdır.");
            }

            var withdrawal = new Transaction(-amt, dt, nt);
            allTransactions.Add(withdrawal);
        }

        public void PerformMonthEndTransaction()
        {
            if (Balance<0)
            {
                decimal interest = Balance * 0.07m;
                MakeWithDrawal(interest, DateTime.Now, "Hesaptan aylık faiz gideri alındı.");
            }
        }
    }
}
