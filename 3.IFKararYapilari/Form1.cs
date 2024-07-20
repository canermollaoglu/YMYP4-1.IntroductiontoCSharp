using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.IFKararYapilari
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
             IF KARAR YAPILARI

            OPERATÖRLER:

            Karşılaştırma Operatörleri: <, >, <=, >=, ==, !=
            Mantıksal Operatörler: ve (&, &&), veya (|, ||)
            Aritmetik Operatörler: +, -, *, /, %
            Aktarma Operatörleri: =, +=, -=, /=, *=
             */

            int sayi = 100 + 45;
            int sonuc = 1235 % 4;

            int value = 65;
            value += 40; //value=value+40;

            //if (kosul veya kosullar olacak)
            //{
            //    //kosul gerçekleşirse (true ise) burası çalışır
            //}else
            //{
            //    //kosul gerçekleşmezse (false ise) burası çalışır.
            //}

            int price = 400;

            if (price>=500)
            {
                //MessageBox.Show("Evet Büyük");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //&, && Mantıksal Operatörü

            //Ahmet'in sınıfını geçebilmesi için devamsızlık sayısının 10 günün altında ve not ortalamasının 70'e eşitve üzerinde olması gerekmektedir.

            byte devamsizlik = 12;
            byte notOrtalamasi = 90;

            //iki koşulunda aynı anda gerçekleşmesi şartı var: Burada ve &, && operatörü kullanılır.

            if (devamsizlik<10 && notOrtalamasi>=70)
            {

            }
            else
            {

            }

            //&,&& ve operatörü kullanıyorsam:
            /*
             true, true > true
             false, true > false
             true, false > false
             false, false > false
             */

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //|, || veya Mantıksal Operatörü

            //Ahmet'in sınıfını geçebilmesi için devamsızlık sayısının 10 günün altında veya not ortalamasının 70'e eşitve üzerinde olması gerekmektedir.


            byte devamsizlik = 6;
            byte notOrtalamasi = 50;

            if (devamsizlik < 10 || notOrtalamasi >= 70)
            {

            }
            else
            {

            }

            /*
             |,|| veya operatörü

            true, true > true
            false, true > true
            true, false > true
            false, false > false
             */
        }
    }
}
