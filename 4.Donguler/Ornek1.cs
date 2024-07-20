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
    public partial class Ornek1 : Form
    {
        public Ornek1()
        {
            InitializeComponent();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            //Contains, IndexOf

            char arananHarf = Convert.ToChar(txtAranan.Text.ToLower());
            string aramaCümlesi = txtCumle.Text.ToLower();

            char[] dizim = aramaCümlesi.ToCharArray();

            //1- Tüm char dizisi içerisinde dönerek aradığımız harfi arayacağız.

            int sayac = 0;

            //r
            //ankara

            foreach (var item in dizim)
            {
                if (item == arananHarf)
                {
                    sayac++;
                }
            }

            lblSonuc.Text = sayac.ToString();

            string adSoyad = "ahmet";

            adSoyad.ToUpper();
            adSoyad.ToLower();
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            //metin içerisinde bulunan tüm a harflerini X ile değiştirmek istiyoruz.

            char aranan = Convert.ToChar(txtAranan.Text);
            string metin = txtCumle.Text.ToLower();
            char[] dizi = metin.ToCharArray();

            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] == aranan)
                {
                    dizi[i] = 'X';
                }
            }

            //char dizisi string olarak textbox'a eklenecek:
            txtCumle.Text = new string(dizi);
        }

        private void btnDiziAra_Click(object sender, EventArgs e)
        {
            //Dizi içerisinde bulunan kategorilerden birini bulup değiştirelim:

            string[] categories = new string[] { "RAM", "HDD", "CPU", "VGA", "BOARD" };

            //IndexOf metodu
            //Dizi içerisinde bulunan elamanın index değerini döner. Bulamaz ise -1 döner.

            int index = Array.IndexOf(categories, "aa");
            lblSonuc.Text = index.ToString();

            if (index != -1)
            {
                categories[index] = "SSD";
            }
            else
            {
                MessageBox.Show("Aranan kelime dizide bulunamamıştır");
            }

            foreach (string category in categories)
            {
                lstListe.Items.Add(category);
            }
        }
    }
}
