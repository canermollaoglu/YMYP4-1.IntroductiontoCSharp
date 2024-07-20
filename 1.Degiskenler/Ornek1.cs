using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1.Degiskenler
{
    public partial class Ornek1 : Form
    {
        public Ornek1()
        {
            InitializeComponent();
        }

        //global değişken:
        //tüm eventler (scopelar) altında erişilebilen değişkendir. Aksi halde tüm değişkenler sadece oluşturuldukları scope içerisinde yaşarlar dolayısı ile farklı scopelardan erişilemezler.
        int sayi = 5;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            sayi = 4;
            //Kaydet butonuna basıldığında kullanıcının girmiş olduğu tüm ürün bilgilerini alarak uygun tiplerdeki değişkenlere atayalım.

            //Urun Adı: string , Urun Adedi: int, Urun Fiyatı: double

            //Mesaj olarak aşağıdaki şekilde bir metin oluşturularak label'a atanacaktır:

            //... adlı ürün için fatura toplam tutarı: 5 * 15000.45 * %20 kdv 

            string productName = txtUrunAdi.Text;

            //parse
            int productQuantity = int.Parse(txtUrunAdedi.Text);

            ////casting
            //int number = 1000;
            //double dNumber = (double)number;

            ////tryparse
            double productPrice;
            bool sonuc = double.TryParse(txtUrunFiyati.Text, out productPrice);

            double totalPrice = productQuantity * productPrice * 1.20;

            //MessageBox.Show("Fatura Toplam Tutarı: "+totalPrice);

            lblMesaj.Text = $"Fatura Toplam Tutarınız: {totalPrice}";

            //lblMesaj.Text = $"{productQuantity} adet aldığınız ürünün toplam tutarı: {totalPrice}";

            txtUrunAdi.Text = "";
            txtUrunAdi.Focus();
        }

        private void Ornek1_Load(object sender, EventArgs e)
        {
            sayi = 54545;

            //Tarih İşlemleri
            DateTime tarih = DateTime.Now;

            int year = tarih.Year;
            int dayOfYear = tarih.DayOfYear;
            int Month = tarih.Month;

            DateTime yeniTarih = tarih.AddDays(54);
            yeniTarih = tarih.AddMonths(74);

            //lblTarih.Text = tarih.ToString();
            lblTarih.Text = DateTime.Now.ToString();
            lblTarih.Text = tarih.ToLongDateString();
            lblTarih.Text = tarih.ToShortDateString();

            //Tarih Format Örnekleri:
            //https://www.c-sharpcorner.com/blogs/date-and-time-format-in-c-sharp-programming1

            lblTarih.Text = tarih.ToString("dddd, dd MMMM yyyy");

            //11:00 de başlıyoruz.
        }
    }
}
