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
    public partial class SwitchCase : Form
    {
        public SwitchCase()
        {
            InitializeComponent();
        }

        enum Kategoriler
        {
            Ram,
            Vga,
            Hdd
        }


        private void SwitchCase_Load(object sender, EventArgs e)
        {
            /*
             SWITCH CASE
            Belirli bir değişkenin veya ifadenin farklı değerlerine bağla olarak farklı islemlerin yapılmasını sağlayan bir kontrol yapısıdır.
             */

            int sayi = 100;

            switch (sayi)
            {
                case 600:
                    MessageBox.Show("Sayi 600'e eşittir");
                    break;
                case 100:
                    MessageBox.Show("Sayi 600'e eşittir");
                    break;
                case 200:
                    MessageBox.Show("Sayi 600'e eşittir");
                    break;
                default:
                    MessageBox.Show("Sayı bulunamadı.");
                    break;

                    Kategoriler secilen = Kategoriler.Ram;
                    
                    switch (secilen)
                    {
                        case Kategoriler.Ram:
                            MessageBox.Show("Ram Seçildi");
                            break;
                        case Kategoriler.Vga:
                            MessageBox.Show("Vga Seçildi");
                            break;
                        case Kategoriler.Hdd:
                            MessageBox.Show("Hdd Seçildi.");
                            break;
                        default:
                            MessageBox.Show("Hiçbiri seçilmedi.");
                            break;
                    }

                    string deger = "Pazartesi";

                    switch (deger)
                    {
                        case "Pazartesi":
                            MessageBox.Show("Pazartesi Seçildi");
                            break;
                        case "Salı":
                            MessageBox.Show("Salı Seçildi");
                            break;                     
                        default:
                            MessageBox.Show("Hiçbiri seçilmedi.");
                            break;
                    }



            }
        }
    }
}
