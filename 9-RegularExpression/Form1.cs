using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_RegularExpression
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
             Regular Expression (Düzenli İfadeler)
            Düzenli ifadeler metinler içerisinde belirli kalıpları bulmak ve değiştirmek için kullanılan dizelerdir. Bir metin içerindeki örüntüleri tanımlamak için kullanılan özel karakterler ve sembollerin kombinasyonudur.
            https://en.wikipedia.org/wiki/Regular_expression

            [0-9] rakamsal değerler girilsin
            [^0-9] rakam girilmesin
            [a-z] sadece küçük harf alfabetik karakterler
            [A-Z] sadece küçük harf alfabetik karakterler
            [A-Za-z0-9] alfabetik + sayısal
            [^A-Za-z0-9] alfabetik + sayısal olamaz

             */
        private void button1_Click(object sender, EventArgs e)
        {
            //Sadece 0-9 aralığında değerler girebiliyoruz.
            //textbox'a 0-9 aralığı dışında bir giriş yapıldı mı
            if (Regex.IsMatch(txtNum.Text,"[^0-9]"))
            {
                MessageBox.Show("Uygun Değil");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtNum.Text,"[A-Za-zöşğiüÖÜŞĞ]"))
            {
                MessageBox.Show("Lütfen alfabetik bir değer giriniz.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //textbox'a A-Za-z aralığı dışında bir giriş yapıldı mı
            if (Regex.IsMatch(txtNum.Text, "[^A-Za-z]"))
            {
                MessageBox.Show("Lütfen türkçe karakter kullanmayınız");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*
             E-posta deseni: @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$"
                Telefon numarası deseni: "0\([0-9]{3}\)-[0-9]{3}-[0-9]{2}-[0-9]{2}"
                Tarih deseni: "^\d{1,2}\/\d{1,2}\/\d{4}$"   
             */

            //10:50 de devam ediyoruz.

            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            string pattern2 = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.(com|org|net|edu|gov|biz|info|io|name{2,})$";

            if (Regex.IsMatch(txtDeger.Text, pattern2))
            {
                MessageBox.Show("Geçerli email adresi");
            }
            else
            {
                MessageBox.Show("Geçersiz email adresi");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
