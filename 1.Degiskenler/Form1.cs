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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
            /*
             Değişkenler (Variables)
            Bilgisayar belleğinde bazı değerleri tutmaya yarayan yapılardır.
             */

            byte stokMiktari = 255;
            int sayi = 5;
            short deger = 32000;
            long number = 453453453453;

            float ondalik1 = 454.33f;
            double ondalik2 = 5443.43;
            decimal ondalik3 = 43434.3432m;

            string adSoyad = "Ahmet Aksakal";
            char karakter = 'A';

            bool cevap = true;

            //İsimlendirme standartı olarak camelCase kullanıyoruz.

            //C# case sensitive bir dildir. Yani büyük küçük harf duyarlılığı vardır.
            string addressInformation = "Beşiktaş";
            string AddressInformation = "Levent";
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            //Value Type / Reference Type

            //C# ta değişkenler iki gruba ayrılır:

            /*
             Değer Tipli Değişkenler: (Value Type) : Ram'in stack adlı bölümünde tutulurlar: int, long, double, decimal, char, bool, byte, short
            Referans Tipli Değişkenler: (Reference Type) Ram'in heap adlı bölümünde tutulurlar: string, object, class, interface, array, delegate
             */

            //Value Type
            int sayi1 = 45;
            int sayi2 = sayi1;
            sayi1 = 50;

            //Reference Type
            int[] adizisi = { 5, 6, 7, 8, 9 };
            int[] bdizisi = adizisi;
            adizisi[0] = 123;

            string adSoyad = "Ahmet Aksakal";
            string yeniAdSoyad = adSoyad;
            adSoyad = "Caner Mollaoğlu";

        }
    }
}
