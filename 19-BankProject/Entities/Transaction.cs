using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_BankProject.Entities
{
    //Ctrl + . (nokta) Use Primary Constructor
    public class Transaction(decimal amount, DateTime date, string note)
    {
        public decimal Amount { get; set; } = amount;
        public DateTime Date { get; set; } = date;
        public string Note { get; set; } = note;
    }
}
