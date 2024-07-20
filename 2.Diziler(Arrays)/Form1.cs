using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.Diziler_Arrays_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             Diziler (Arrays) Reference Type

            Dizi içerisinde aynı tipte birden çok değeri tutabilen ve indis(index) numaraları üzerinden bu değerlere ulaşabildiğimiz bir veri yapısıdır. Dizi içerisinde bulunan değerlere o dizinin elemanları denir. 
            Dizi oluşturulduğunda eleman sayısı mutlaka tanımlanmalıdır. 

             */

            string adSoyad = "Ahmet Aksakal";
            string adSoyad1 = "Kardelen Tugay";
            string adSoyad2 = "Kuzey Mollaoğlu";

            //Dizi Oluşturma
            string[] studentInfo = new string[3];
            //Eleman Sayısı: 3
            //İndis Degerleri: 0, 1, 2

            int[] ogrenciNotlari = new int[6];

            //Diziyi oluşturduğumuz anda değerlerini atayabiliriz.
            string[] countryInfo = new string[] { "İstanbul", "Ankara", "Malatya" };
            int[] ogrenciNotlari2 = new int[] { 56, 98, 12 };

            //Diziye Değer Atama (set)
            studentInfo[0] = "Caner Mollaoğlu";
            studentInfo[1] = "Mihriban Şimşek";
            studentInfo[2] = "Hasan Uzun";
            //studentInfo[3] = "Mert Gündüz";'Index was outside the bounds of the array.'

            //Diziden Değer Okuma (get)
            string gelecekDeger = studentInfo[2];
            string gelecekSehir = countryInfo[1];

        }

        string[] ogrenciBilgileri = new string[1];
        int sayac = 0;
        private void btnKaydet_Click(object sender, EventArgs e)
        {          
            string adSoyad = $"{txtAd.Text} {txtSoyad.Text}";
            //string nameSurname = txtAd.Text + " " + txtSoyad.Text;

            ogrenciBilgileri[sayac] = adSoyad;

            sayac = sayac + 1;
            //sayac++;

            //Array.Sort(ogrenciBilgileri);
            //Array.Clear(ogrenciBilgileri, 0, 2);

            //Dizinin eleman sayısı:
            int elemanSayisi=ogrenciBilgileri.Length;

            //ogrenciBilgileri dizimizi resize() yapalım. (Yeniden Boyutlandırma)
            Array.Resize(ref ogrenciBilgileri, elemanSayisi+1);
        }
    }
}
