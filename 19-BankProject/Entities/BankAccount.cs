using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_BankProject.Entities
{
    //abstract: Bu proje içerisinde hiçbir zaman BankAccount sınıfının instance alınarak kullanılmaması gerekiyor. Burada her zaman BankAccount sınıfından türemiş olan sınıflar kullanılacaktır. Dolayısı ile burada BankAccount sınıfı diğer butun sınıflara sablon oluşturacak olan bir soyut sınıftır.
    public abstract class BankAccount
    {
        public BankAccount(string nameSurname, decimal initialBalance)
        {
            Owner = nameSurname;
            MakeDeposit(initialBalance, DateTime.Now, "Hesap açılış bakiyesi yatırıldı.");
        }

        public string Number { get; set; } = Guid.NewGuid().ToString();
        public string? Owner { get; set; }
        public decimal Balance
        {
            get
            {
                decimal b = 0;
                foreach (var item in allTransactions)
                {
                    b += item.Amount;
                }
                return b;
            }
        }

        //Encapsulation (kapsülleme)
        //OOP'nin temel prensiplerinden bir tanesidir. Bu yöntem bir nesnenin iç detaylarına dışarıdan doğrudan erişilmemesini ve sadece belirli yöntemler aracılığı ile erişilmesini sağlar.
        //Ne işe yarar: veri gizliliği, kontrollü erişim, modülerlik
        //public, private, protected, internal, protected internal (access modifier)

        private decimal tip;
        public decimal Tip
        {
            get
            {
                if (tip < 100)
                {
                    throw new Exception("Hata");
                }
                return tip;
            }
            set
            {
                if (value >= 100)
                {
                    tip = value;
                }
            }
        }

        private string? _namesurname;
        public string? NameSurname
        {
            get
            {
                return _namesurname.ToUpper();
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _namesurname = value;
                }
                else
                {
                    throw new Exception("Hata");
                }
            }
        }

        //bütün para çekme ve yatırma islemleri burada yeni bir transaction olarak tutulacaktır.
        protected List<Transaction> allTransactions = new List<Transaction>();

        //Para Yatırma

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            //yatırılan tutar 0'dan büyük olmalıdır.
            if (amount <= 0)
            {
                //hata fırlat:
                throw new ArgumentOutOfRangeException(nameof(amount), "Yatırılan Tutar 0'dan Büyük Olmalıdır.");
            }

            //para yatırma işlemini yapabilirim:
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        //Para Çekme İşlemi:
        public virtual void MakeWithDrawal(decimal amt, DateTime dt, string nt)
        {
            //para çekilirken pozitif bir değer girmeliyiz.
            //hesapta yeterli bakiye olmalıdır.

            if (amt <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amt), "Çekilen tutar 0'dan büyük olmalıdır.");
            }

            //100-500
            if (Balance - amt < 0)
            {
                throw new InvalidOperationException($"Hesap bakiyeniz yetersiz. Çekilebilecek tutar: {Balance}");
            }

            //para çekme islemini yapabiliriz:
            var withdrawal = new Transaction(-amt, dt, nt);
            allTransactions.Add(withdrawal);
        }

        public string GetAccountHistory()
        {
            var report = new StringBuilder();
            int sayac = 1;

            foreach (var item in allTransactions)
            {
                string islemTipi = item.Amount < 0 ? "Para Çekme" : "Para Yatırma";
                report.AppendLine($"{sayac}.işlem: {item.Amount} $ - {islemTipi}");
                sayac++;
            }

            return report.ToString();
        }
    }

}
