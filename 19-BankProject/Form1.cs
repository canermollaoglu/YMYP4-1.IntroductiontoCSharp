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
         Hesap A��l�� ��lemi
        Otomatik olarak bir hesap numaras� olu�turulmas�n� istiyoruz.
        Hesap a��l��� yaparken mutlaka hesap sahibinin ad� soyad� ve ilk bakiye girilmelidir.

        Hesaptan Para �ekebilmeyelim:
        Hesapta para yoksa para �ekme i�lemi yap�lamas�n.

        Hesaba Para Yat�rabilmeliyim:
        Para yat�r�rken 0'dan b�y�k bir de�er olmas� sa�lanmal�d�r.

        InterestEarningAccount (Faiz Getiri Hesab�)
        E�er mevcut bakiye 500 dolardan fazla ise her ay sonu %5 faiz getirisi sa�lar.

        LineOfCreditAccount (Kredi Limit Hesab�)
        Eksi bakiyeye d��ebilir. Ancak eksi bakiye s�z konusu ise her ay sonu %7 fazi gideri uygulanacakt�r.

        GiftCardAccount (Hediye Kart� Hesab�)
        Her ay sonu istenirse bir biktar para yat�rma i�lemi yap�labilir.
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
                MessageBox.Show("Hesap ba�ar� ile a��lm��t�r.");
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
            //i�lem t�r�n� bulal�m:

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
            //Olu�turulan hesap tipine g�re ay sonu i�lemlerini yap�n�z.
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
