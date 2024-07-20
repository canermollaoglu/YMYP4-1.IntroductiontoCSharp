using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _19_BankProject.Entities
{
    public class GiftCardAccount : BankAccount, IMonthEndPerform
    {
        //GiftCardAccount (Hediye Kartı Hesabı)
        //Her ay sonu istenirse bir biktar para yatırma işlemi yapılabilir.

        private decimal _montlyDeposit;

        public GiftCardAccount(string nameSurname, decimal initialBalance, decimal monthlyPay=0) : base(nameSurname, initialBalance)
        {
            _montlyDeposit = monthlyPay;
        }

        public void PerformMonthEndTransaction()
        {
            if (_montlyDeposit!=0)
            {
                MakeDeposit(_montlyDeposit, DateTime.Now, "Aylık extra yatırma yapıldı.");
            }
        }
    }
}
