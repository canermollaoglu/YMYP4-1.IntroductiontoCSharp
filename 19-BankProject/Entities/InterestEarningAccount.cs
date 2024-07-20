using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_BankProject.Entities
{
    public class InterestEarningAccount : BankAccount, IMonthEndPerform
    {
        //Eğer mevcut bakiye 500 dolardan fazla ise her ay sonu %5 faiz getirisi sağlar.
        public InterestEarningAccount(string nameSurname, decimal initialBalance) : base(nameSurname, initialBalance)
        {

        }

        public void PerformMonthEndTransaction()
        {
            if (Balance>500)
            {
                decimal interest = Balance * 0.05m;
                MakeDeposit(interest, DateTime.Now, "Aylık faiz getirisini hesaba yatırıldı.");
            }
        }
    }
}
