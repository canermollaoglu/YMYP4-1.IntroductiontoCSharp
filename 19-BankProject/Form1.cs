using _19_BankProject.Entities;

namespace _19_BankProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
         Hesap Açýlýþ Ýþlemi
        Otomatik olarak bir hesap numarasý oluþturulmasýný istiyoruz.
        Hesap açýlýþý yaparken mutlaka hesap sahibinin adý soyadý ve ilk bakiye girilmelidir.

        Hesaptan Para Çekebilmeyelim:
        Hesapta para yoksa para çekme iþlemi yapýlamasýn.

        Hesaba Para Yatýrabilmeliyim:
        Para yatýrýrken 0'dan büyük bir deðer olmasý saðlanmalýdýr.

        InterestEarningAccount (Faiz Getiri Hesabý)
        Eðer mevcut bakiye 500 dolardan fazla ise her ay sonu %5 faiz getirisi saðlar.

        LineOfCreditAccount (Kredi Limit Hesabý)
        Eksi bakiyeye düþebilir. Ancak eksi bakiye söz konusu ise her ay sonu %7 fazi gideri uygulanacaktýr.

        GiftCardAccount (Hediye Kartý Hesabý)
        Her ay sonu istenirse bir biktar para yatýrma iþlemi yapýlabilir.
         */
        private void Form1_Load(object sender, EventArgs e)
        {
            //BankAccount hesap = new BankAccount("Ahmet Aksakal", 5000);
            //hesap.NameSurname = "ahmet aksakal";
            //string adSoyad = hesap.NameSurname;
            //hesap.Tip = 5600;

            Doldur();

        }

        private void Doldur()
        {
            var hesapTurleri = Enum.GetValues(typeof(HesapTurleri));
            foreach (var item in hesapTurleri)
            {
                cmbHesapTuru.Items.Add(item);
            }

            cmbIslemTuru.DataSource = Enum.GetValues(typeof(IslemTipleri));
        }
        BankAccount hesap;
        HesapTurleri secilenHesap;
        private void btnHesapAc_Click(object sender, EventArgs e)
        {
            try
            {
                string owner = txtAdSoyad.Text;
                decimal initialBalance = Convert.ToDecimal(txtIlkBakiye.Text);

                secilenHesap = (HesapTurleri)cmbHesapTuru.SelectedItem;

                if (secilenHesap == HesapTurleri.Interest_Earning_Account)
                {
                    hesap = new InterestEarningAccount(owner, initialBalance);
                }
                else if (secilenHesap == HesapTurleri.Gift_Card_Account)
                {
                    hesap = new GiftCardAccount(owner, initialBalance);
                }
                else
                {
                    hesap = new LineOfCreditAccount(owner, initialBalance);

                }

                txtHesapNo.Text = hesap.Number;
                BakiyeGuncelle();
                MessageBox.Show("Hesap baþarý ile açýlmýþtýr.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BakiyeGuncelle()
        {
            lblHesapHareketleri.Text = hesap.GetAccountHistory();
            lblSonBakiye.Text = hesap.Balance.ToString() + " $";
        }

        private void btnIslemYap_Click(object sender, EventArgs e)
        {
            //iþlem türünü bulalým:

            IslemTipleri secilenIslemTipi = (IslemTipleri)cmbIslemTuru.SelectedItem;
            string not = txtIslemNotu.Text;
            decimal amount = Convert.ToDecimal(txtTutar.Text);

            if (secilenIslemTipi == IslemTipleri.Para_Cekme)
            {
                hesap.MakeWithDrawal(amount, DateTime.Now, not);
            }
            else
            {
                hesap.MakeDeposit(amount, DateTime.Now, not);
            }

            BakiyeGuncelle();
        }

        private void btnAySonu_Click(object sender, EventArgs e)
        {
            //Oluþturulan hesap tipine göre ay sonu iþlemlerini yapýnýz.
            switch (secilenHesap)
            {
                case HesapTurleri.Interest_Earning_Account:
                    InterestEarningAccount intAcc = hesap as InterestEarningAccount;
                    intAcc.PerformMonthEndTransaction();
                    break;
                case HesapTurleri.LineOf_Credit_Account:
                    LineOfCreditAccount lineAcc = hesap as LineOfCreditAccount;
                    lineAcc.PerformMonthEndTransaction();
                    break;
                case HesapTurleri.Gift_Card_Account:
                    GiftCardAccount giftAcc = hesap as GiftCardAccount;
                    giftAcc.PerformMonthEndTransaction();
                    break;
                default:
                    break;
            }

        }
    }
}
