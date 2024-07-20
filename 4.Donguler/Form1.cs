using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.Donguler
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
             DÖNGÜLER
            Program yazarken bazı kodları tekrar tekrar yazıyorsanız orada bir hata yapıyorsunuz demektir. Dolayısı ile bu tarz durumlarda döngü kullanmak gerekir. 

            for, while, do while, foreach
             */
            int[] dizim = new int[] { 2, 3, 23, 2, 3 };

            //lstListe.Items.Add(dizim[0]);

            //listbox'a ekleme yapmak için bu kod kullanılır:
            //btnEkle.Text = "Test";

            //lstListe.Items.Add("Ahmet");
            //lstListe.Items.Add(454);
            //lstListe.Items.Add(4500.3422);
            //lstListe.Items.Add(true);
            //lstListe.Items.Add(dizim);

            //lstListe.Items.Add("Caner");
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            //For Döngüsü
            // i            : sayac (counter), baslangıc değeri
            // i<length     : döngü koşulu
            //i ++          : sayac'ın artış değeri

            //0,1,2,3,4,5,6,7,8,9
            for (int i = 0; i < 10; i++)
            {
                lstListe.Items.Add("Mahmut");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                lstListe.Items.Add($"{i}. Ahmet");
            }
        }

        string[] kategoriler = new string[] { "Elektronik", "Teknoloji", "Ev Gereçleri", "Bahçe Mobilyaları" };
        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < kategoriler.Length; i++)
            {
                lstListe.Items.Add(i + 1 + "-" + kategoriler[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //While Döngüsü

            int sayac = 0;

            while (sayac <= 10)
            {
                lstListe.Items.Add(sayac);
                sayac++;
                //sayac = sayac + 1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayac = 1;
            foreach (var item in kategoriler)
            {
                lstListe.Items.Add($"{sayac}.{item}");
                sayac++;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //var tipi atama yapılan tipe dönüşebilen bir değişken türüdür. Karşı taraftan gelecek olan veri türü tam olarak bilinmediğinde ya da farklı türler gelebileceği zaman kullanılır.

            foreach (var item in kategoriler)
            {
                lstListe.Items.Add(item);
            }

            //Biz burada kategoriler dizimizin string bir dizi olduğunu bildiğimiz için item'ın tipini aşağıdaki şekilde string olarak da tanımlayabiliriz.

            foreach (string item in kategoriler)
            {
                lstListe.Items.Add(item);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Do While
            //Hiçbir koşula bakılmaksızın yazdığımız kodlar 1 defa mutlaka çalışır.

            int sayac = 0;

            do
            {
                lstListe.Items.Add(sayac);
                sayac++;
            } while (sayac <= 5);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    if (i==5)
            //    {
            //        continue; //döngünün 5. adımını atlamış olacağız.
            //    }

            //    lstListe.Items.Add(i);
            //}

            foreach (var item in kategoriler)
            {
                if (item == "Elektronik")
                {
                    continue;
                }
                lstListe.Items.Add(item);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 15; i++)
            {
                if (i==6)
                {
                    break;
                }

                lstListe.Items.Add(i);
            }
        }
    }
}
