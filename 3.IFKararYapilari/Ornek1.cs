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
    public partial class Ornek1 : Form
    {
        public Ornek1()
        {
            InitializeComponent();
        }

        private void Ornek1_Load(object sender, EventArgs e)
        {
            //bir stok takip programında yapılan satışlara göre müşterilere indirim kuponları tanımlayacağımızı düşünelim. Şöyle bir algoritmamız olsun:

            /*
             * 500 TL nin altında ise indirim uygulanmayacaktır
             500 TL ile 1000 TL arasında alışveriş yapan müşterilere %20,           
            1000 TL ile 2500 TL arasında alışveriş yapan müşterilere %25,
            2500 TL ile 5000 TL arasında alışveriş yapan müşterilere %35 
            5000 TL den fazla ise %45 indirim uygulanacaktır.
             */
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            bool indirimVarMi = true;
            double satisTutari = double.Parse(txtTutar.Text);
            //satistutari : 600 TL

            if (satisTutari>=500 && satisTutari<=1000)
            {
                //%20
                //satisTutari = satisTutari - (satisTutari * 0.20);
                satisTutari -= satisTutari * 0.20;               
            }
            else if (satisTutari>1000 && satisTutari<=2500)
            {
                //%25
                satisTutari -= satisTutari * 0.25;
            }
            else if (satisTutari>2500 && satisTutari<=5000)
            {
                //%35
                satisTutari -= satisTutari * 0.35;
            }
            else if (satisTutari>5000)
            {
                //%45
                satisTutari -= satisTutari * 0.45;
            }
            else
            {
                indirimVarMi = false;
            }

            //indirimVarMi==true    indirimVarMi
            //indirimVarMi==false   !indirimVarMi

            if (indirimVarMi)
            {
                lblMesaj.Text = satisTutari.ToString();
            }
            else
            {
                lblMesaj.Text = "İndirim Uygulanmamıştır.";
            }
        }
    }
}
