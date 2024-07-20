using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_OgrenciTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Dictionary Koleksiyon Yapısı
        //Key (anahtar), Value (deger) olarak çalışır.

        //key   : string 
        //value : double
        Dictionary<string, double> ogrenciListesi = new Dictionary<string, double>();

        private void button1_Click(object sender, EventArgs e)
        {
            //hata yakalama mekanizması (try catch)

            //try       : tüm işlemler bu blokta yapılır
            //catch     : herhangi bir hata oluşursa bu blok çalışır. Burada exception nesnesi üzerinden hata ile ilgili bilgilere ulaşabiliriz.
            //finally   : her iki durumda da bu bölüm her şekilde çalışır.

            try
            {
                //form üzerinden değerleri alalım:

                if (string.IsNullOrEmpty(txtAdSoyad.Text) || string.IsNullOrEmpty(txtFinal.Text) || string.IsNullOrEmpty(txtVize.Text))
                {
                    throw new Exception("Lütfen tüm alanları doldurunuz.");
                }
                else
                {
                    string adSoyad = txtAdSoyad.Text;
                    double vizeNotu = Convert.ToDouble(txtVize.Text);
                    double finalNotu = Convert.ToDouble(txtFinal.Text);

                    //ortalama hesapla
                   double ortalama=OrtalamaPuanHesapla(vizeNotu, finalNotu);

                    //dictionary yapısına ekleyelim
                    ogrenciListesi[adSoyad] = ortalama;

                    //listeye tüm öğrencileri ekleyelim
                    ListeyiGuncelle();

                }

                lblHataMesaji.Text = "";
                lblHataMesaji.BackColor = Control.DefaultBackColor;
            }
            catch (Exception ex)
            {
                lblHataMesaji.Text = ex.Message;
                lblHataMesaji.BackColor = Color.Coral;
            }
            finally
            {

            }
        }

        private void ListeyiGuncelle()
        {
            lstListe.Items.Clear();

           foreach (var item in ogrenciListesi)
            {
                lstListe.Items.Add($"{item.Key}-{item.Value}");
            }
        }

        private double OrtalamaPuanHesapla(double vizeNotu, double finalNotu)
        {
            double ort = (vizeNotu * 0.40) + (finalNotu * 0.60);
            return ort;
        }

        private void lblHataMesaji_Click(object sender, EventArgs e)
        {

        }
    }
}
