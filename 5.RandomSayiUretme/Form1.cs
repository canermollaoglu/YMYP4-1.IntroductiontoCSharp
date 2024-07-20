using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5.RandomSayiUretme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Random

            Random rnd = new Random();
            int randomSayi = rnd.Next(0, 10); //0,1,2,3,4,5,6,7,8,9
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstKupon.Items.Clear();

            int[] secilenSayilar = new int[6];
            Random rnd = new Random();
            int rSayi;

            //for tek tek dizinin gözlerini dolaşmak için kullanılıyor:
            for (int i = 0; i < 6; i++)  //0,1,2,3,4,5
            {
                do
                {
                    rSayi = rnd.Next(6, 50);
                    //random sayı oluştur
                } while (secilenSayilar.Contains(rSayi));

                secilenSayilar[i] = rSayi;
            }

            foreach (var item in secilenSayilar)
                lstKupon.Items.Add(item);
        }
    }
}
