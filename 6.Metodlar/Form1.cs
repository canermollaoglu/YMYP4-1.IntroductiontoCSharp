using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6.Metodlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             Metodlar
            Program içerisinde aynı işi yapan satırları belirli bir düzende bir araya getirdiğimiz yapılardır. Gerektiğinde çağırarak tekrak tekrar kullanabiliriz. Metodlar sayeside kod tekrarları yapmadan daha anlaşılır bir şekilde kodlama yapılabilir. 

            Direkt olarak çalışmazlar, program içerisinde çağırılarak çalışırlar.

            Metod Türleri

            1-Geriye Değer Dönmeyen Metodlar
                a-Parametresiz Metodlar
                b-Parametreli Metodlar

            2-Geriye Değer Dönen Metodlar 
                a-Parametresiz Metodlar
                b-Parametreli Metodlar
             */

            MesajVer();

        }

        //Geriye Değer Dönmeyen (void)
        //Parametresiz Metod
        private void MesajVer()
        {
            MessageBox.Show("Metodlar ikinci örnek");
        }

        //metod govdesi
        //Geriye Değer Dönmeyen (void)
        //Parametreli Metod
        private void SendMessage(string mesaj)
        {
            MessageBox.Show(mesaj);
        }

        private void SendMessage(string mesaj, string baslik)
        {
            MessageBox.Show(mesaj, baslik);
        }

        private void SendMessage(string mesaj, string baslik, bool cevap)
        {
            if (cevap)
            {
                MessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            }
        }

        private void RenkDegistir()
        {
            //burada this keywordu şuan üzerinde bulunduğumuz formu (Form1) ifade eder. Dolayısı ile bu keyword üzerinden bütün form özelliklerine (property) ulaşabiliriz.
            this.BackColor = Color.Coral;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MesajVer();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //SendMessage("Yeni Bir Mesaj Verdim");

            //SendMessage("Güzel Bir Mesaj Gönderiyorum", "Bilgilendirme");

            SendMessage("İstanbul Eğitim Akademi", "Kurs Bilgileri", true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Parametresiz ve geriye değer dönmeyen metod.
            RenkDegistir();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool[] dizi = new bool[] { true, false, true, true, false, false };

            DiziSifirlama(dizi, false);
        }
        private void DiziSifirlama(bool[] dizim, bool deger)
        {
            for (int i = 0; i < dizim.Length; i++)
            {
                dizim[i] = deger;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string deger = MesajGonder();
            MessageBox.Show(deger);

            string adSoyad = MesajGonder("Caner Mollaoğlu");
            MessageBox.Show(adSoyad);
        }

        //geriye string deger donen
        //parametresiz metod
        private string MesajGonder()
        {
            return "Hoşdeldiniz.";
        }

        /// <summary>
        /// Geriye bir hoşgeldin mesajı döndürür.
        /// </summary>
        /// <param name="adSoyad"></param>
        /// <returns>Ad Soyad bilgileri ile birlikte mesaj döner.</returns>
        private string MesajGonder(string adSoyad)
        {
            return $"Hoşgeldiniz {adSoyad}";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int[] sayilar = new int[] { 123, 2232, 4, 5, 3, 21 };
            int sonuc = ToplamaYap(54, 56);

            int toplamSonuc = ToplamaYap(sayilar);

            int yeniSonuc = ToplamaYap(false,32, 4433, 2, 2, 3, 2, 2, 2, 23, 23, 4, 5, 75, 6, 8, 4);

            lblMesaj.Text = yeniSonuc.ToString();
        }

        private int ToplamaYap(int v1, int v2)
        {
            return v1 + v2;
        }

        private int ToplamaYap(int[] dizim)
        {
            int toplam = 0;
            foreach (var item in dizim)
            {
                toplam += item;
            }

            return toplam;
        }

        private int ToplamaYap(bool durum, params int[] dizim)
        {
            int toplam = 0;
            foreach (var item in dizim)
            {
                toplam += item;
            }

            return toplam;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            /*
             Ref anahtar kelimesi C# dilinde işaretçilerin yerini tutar, ref anahtar kelimesi ile kullanılan değişkene mutlaka ilkleme işlemi yapılmalıdır yani değişkene bir değer atanmış olmalıdır. 

             Başlangıç değeri olan bir değişkenin değerini değiştireceğiz.
             */

            int sayi = 1;
            DegerDegistir(ref sayi);
            lblMesaj.Text = sayi.ToString();
        }

        private void DegerDegistir(ref int sayi)
        {
            sayi = 100;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string ad = "Ahmet", soyad = "Aksakal", adSoyad;
            CumleBirlestir(ad, ref soyad, out adSoyad);

            lstListe.Items.Add(ad);
            lstListe.Items.Add(soyad);
            lstListe.Items.Add(adSoyad);
            //Ahmet
            //Genç
            //Kuzey Genç
        }

        private void CumleBirlestir(string ad,ref string soyad,out string adSoyad)
        {
            ad = "Kuzey";
            soyad = "Genç";
            adSoyad = ad + " " + soyad;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Recursive Method
            //Bir metodun kendi içerisinde tekrar çağrılması anlamına gelir.

            int sonuc=UstHesapla(2,8);
            lstListe.Items.Add(sonuc);

        }

        private int UstHesapla(int baseNum, int expNum)
        {
            if (expNum == 0)
                return 1;
            else
            return baseNum * UstHesapla(baseNum, expNum - 1);
        }
    }
}
