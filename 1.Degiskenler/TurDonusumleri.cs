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
    public partial class TurDonusumleri : Form
    {
        public TurDonusumleri()
        {
            InitializeComponent();
        }

        private void TurDonusumleri_Load(object sender, EventArgs e)
        {
            //Tür Dönüşümleri
            //string to int 

            //int to string
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //ctrl + K D ile kodları hizalayabiliriz.
            // txtStokMiktari.Text = "156";

            string gelenStok = txtStokMiktari.Text;
            int yeniStok = Convert.ToInt32(gelenStok);


            //Convert Sınıfı ile Tür Dönüşümü
            //string to int 
            int stokMiktari = Convert.ToInt32(txtStokMiktari.Text);
            int guncelStok = stokMiktari + 45;

            //int to string
            //MessageBox.Show(guncelStok.ToString());

            //label'a istediğimiz metinsel ifadeyi oluşturup yazalım:

            //lblMesaj.Text = "Yeni stok miktarı: "+guncelStok;
            lblMesaj.Text = $"Yeni stok miktarı: {guncelStok}";
        }
    }
}
