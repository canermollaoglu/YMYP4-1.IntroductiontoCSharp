using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_UrunSiparisFormu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //3 satır 2 sutunluk 2 boyutlu bir dizi oluşturuldu.
        string[,] urunListesi = new string[3, 2];

        private void Form1_Load(object sender, EventArgs e)
        {
            UrunleriHazirlar();

            //Combobox'a ekleme yapar:
            //cmbKategori.Items.Add("deneme");

            //ComboboxaKategorileriGetirGetNames();
            ComboboxaKategorileriGetirGetValues();

        }

        private void UrunleriHazirlar()
        {
            urunListesi[0, 0] = "1";
            urunListesi[0, 1] = "VGA";
            urunListesi[1, 0] = "1";
            urunListesi[1, 1] = "RAM";
            urunListesi[2, 0] = "2";
            urunListesi[2, 1] = "KOLTUK";
        }

        private void ComboboxaKategorileriGetirGetValues()
        {
            //byte[] dizi = (byte[])Enum.GetValues(typeof(Kategoriler));
            Array dizi = Enum.GetValues(typeof(Kategoriler));

            foreach (var item in dizi)
            {
                cmbKategori.Items.Add(item);
            }
        }

        private void ComboboxaKategorileriGetirGetNames()
        {
            string[] tumKategoriler = Enum.GetNames(typeof(Kategoriler));

            foreach (var item in tumKategoriler)
            {
                cmbKategori.Items.Add(item);
            }
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            byte secilen = (byte)cmbKategori.SelectedItem;

            //Dizi içerisinden 1 numaralı kategorisi olan ürünleri getir:

            UrunleriListeyeDoldur(secilen);
        }

        private void UrunleriListeyeDoldur(byte secilen)
        {
            lstListe.Items.Clear();
            int satirBoyutu = urunListesi.GetLength(0); //3 satır
            int sutunBoyutu = urunListesi.GetLength(1); //2 sutun

            for (int i = 0; i < urunListesi.GetLength(0); i++)
            {
                if (urunListesi[i, 0] == secilen.ToString())
                {
                    lstListe.Items.Add(urunListesi[i, 1]);
                }
            }
        }

        decimal sonuc = 0;
        private void txtBirimFiyat_KeyDown(object sender, KeyEventArgs e)
        {
            //listboxtan bir ürün secilmeli
            //numeric updown 0 dan farklı olmalı
            //txtbirimfiyat içerisinde bir değer olmalıdır.
            if (lstListe.SelectedIndex != -1 && nmrAdet.Value != 0 && !string.IsNullOrEmpty(txtBirimFiyat.Text))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    sonuc = nmrAdet.Value * decimal.Parse(txtBirimFiyat.Text);
                    txtToplamTutar.Text = sonuc.ToString();
                }
            }
        }

        decimal kdvliTutar;
        int tutarIndex = 0;
        decimal[] tutarDizisi = new decimal[1];
        private void btnAktar_Click(object sender, EventArgs e)
        {
            if (RadioButtonlardanEnAzBirTanesiSeciliMi())
            {
                //tutar hesaplanırken eğer ;
                //Kurumsal fatura secili ile %20 kdvli tutar hesaplansın
                //Bireysel fatura secili ile %18 kdvli tutar hesaplansın

                //ürün adı, adet, birim fiyatı , tutar olarak sepete eklenecek
                //ekleme islemi yapıldığında aynı zamanda arka planda bir dizide toplam tutarları tutalım.

                //RadioButtonlardan hangisi seçili bulalım:

                //TERNARY IF 
                int deger = 100;
                string mesaj = deger == 100 ? "evet 100" : "hayır değil";

                bool hangiFatura = rdKurumsal.Checked ? true : false;

                //Hesaplamayı Yapalım:

                if (hangiFatura)
                {
                    //kurumsal
                    kdvliTutar = nmrAdet.Value * decimal.Parse(txtBirimFiyat.Text) * 1.20m;
                }
                else
                {
                    //bireysel
                    kdvliTutar = nmrAdet.Value * decimal.Parse(txtBirimFiyat.Text) * 1.18m;
                }

                //ListBox'a ekleme yapalım:
                lstSepet.Items.Add($"{lstListe.SelectedItem.ToString()}-{nmrAdet.Value.ToString()}-{txtBirimFiyat.Text}-{kdvliTutar}");
                tutarDizisi[tutarIndex] = kdvliTutar;
                tutarIndex++;

                lblSepetToplam.Text = ToplamGuncelle().ToString();

                Array.Resize(ref tutarDizisi, tutarDizisi.Length + 1);
            }
            else
            {
                MessageBox.Show("Lütfen fatura tipini seçiniz.");
            }
        }

        private decimal ToplamGuncelle()
        {
            decimal toplam = 0;

            foreach (var item in tutarDizisi)
            {
                toplam += item;
            }

            return toplam;
        }

        private bool RadioButtonlardanEnAzBirTanesiSeciliMi()
        {
            bool durum = false;

            foreach (var item in grpFaturaTipleri.Controls)
            {
                if (item is RadioButton)
                {
                    RadioButton radio = item as RadioButton;
                    //radio.Checked==true
                    if (radio.Checked)
                        durum = true;
                }
                //if (item is TextBox)
                //{
                //    TextBox t = item as TextBox;
                //    t.Text = "";
                //}             
            }

            return durum;
        }
    }
}
