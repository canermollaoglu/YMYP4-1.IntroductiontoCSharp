using _14_OOP_TemelPrensipler2.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_OOP_TemelPrensipler2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //kdv %20
            CepTelefonu c = new CepTelefonu();
            c.UnitPrice = 1000;
            //MessageBox.Show($"Cep Telefonu KDV: {c.KdvHesapla().ToString()}");


            //kdv %25
            Gomlek g = new Gomlek();
            c.UnitPrice = 2000;
            //MessageBox.Show($"Gömlek KDV: {c.KdvHesapla().ToString()}");


            ComboyuDoldur();
        }

        private void ComboyuDoldur()
        {
            cmbUrunKategori.Items.AddRange(new string[] { "Gömlek", "Cep Telefonu" });
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //Generic List
            List<string> liste = new List<string>();
            liste.Add("Ahmet");
            liste.Add("Merve");
            liste.RemoveAt(0);
            liste.Remove("Merve");

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(1);
            sayiListesi.Add(2);
            sayiListesi.Add(3);
            sayiListesi.Add(4);

            List<Gomlek> gomlekler = new List<Gomlek>();

            Gomlek g1 = new Gomlek()
            {
                ProductName = "Lacoste Slim Fit Gömlek",
                UnitPrice = 3500
            };

            Gomlek g2 = new Gomlek()
            {
                ProductName = "Lacoste XL Fit Gömlek",
                UnitPrice = 3200
            };

            Gomlek g3 = new Gomlek()
            {
                ProductName = "Tommy Slim Gömlek",
                UnitPrice = 4500
            };

            gomlekler.Add(g1);
            gomlekler.Add(g2);
            gomlekler.Add(g3);

            //Cep Telefonu nesnesi Urunden türediği için aynı zamanda bir ürün nesnesidir diyebiliriz.
            //Urun u1 = new CepTelefonu();
            //CepTelefonu c1 = new Urun();
        }

        Sepet s = new Sepet();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Gomlek g = new Gomlek()
            {
                UnitPrice = 4560,
                ProductName = "Tommy Gömlek"
            };

            CepTelefonu c = new CepTelefonu()
            {
                UnitPrice = 4560,
                ProductName = "Nokia 3310"
            };

            s.UrunEkle(g);
            s.UrunEkle(c);

            ListeyiGuncelle();
        }

        private void ListeyiGuncelle()
        {
            lstListe.Items.Clear();

            List<Urun> gelenListe = s.TumUrunleriGetir();

            foreach (var item in gelenListe)
            {
                //lstListe.Items.Add($"{item.ProductName}-{item.UnitPrice}");
                lstListe.Items.Add(item);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (secilen == 0)
            {
                //Gomlek
                Gomlek g = new Gomlek()
                {
                    Beden = "XL",
                    Description = "Güzel",
                    KumasTuru = "Pamuklu",
                    ProductName = txtUrunAdi.Text,
                    Quantity = Convert.ToInt32(nmrAdet.Value),
                    UnitPrice = 3500
                };

                s.UrunEkle(g);
            }
            else
            {
                //Cep Telefonu
                CepTelefonu c = new CepTelefonu()
                {
                    ProductName = txtUrunAdi.Text,
                    Quantity = Convert.ToInt32(nmrAdet.Value),
                    BataryaSuresi = 120,
                    Description = "Çok Güzel",
                    RamKapasitesi = 64,
                    UnitPrice = 98500.87
                };

                s.UrunEkle(c);
            }

            ListeyiGuncelle();
        }

        int secilen;
        private void cmbUrunKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilen = cmbUrunKategori.SelectedIndex;
        }
    }
}
