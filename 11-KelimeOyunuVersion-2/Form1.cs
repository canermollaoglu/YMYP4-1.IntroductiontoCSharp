using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_KelimeOyunuVersion_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        char[] harflerim = { 'A', 'B', 'C', 'Ç', 'D', 'E', 'F', 'G', 'Ğ', 'H', 'I', 'İ', 'J', 'K', 'L', 'M', 'N', 'O', 'Ö', 'P', 'R', 'S', 'Ş', 'T', 'U', 'Ü', 'V', 'Y', 'Z' };

        string[] iller = { "Adana", "Adıyaman", "İstanbul", "Ağrı", "Aksaray", "Amasya", "Malatya" };
        string[] secilenIller = new string[1];
        int oyunHakki;
        private void Form1_Load(object sender, EventArgs e)
        {
            AlfabeOlustur();
        }

        private void AlfabeOlustur()
        {
            for (int i = 0; i < harflerim.Length; i++)
            {
                Button btn = new Button();
                btn.Size = new Size(80, 80);
                btn.Text = harflerim[i].ToString();
                btn.Tag = i;
                btn.Click += Btn_Click;
                flwHarfler.Controls.Add(btn);
            }
        }

        int dogruSayisi = 0;
        private void Btn_Click(object sender, EventArgs e)
        {
            if (oyunHakki == 0)
            {
                DialogResult cvp = MessageBox.Show("Yeniden oynamak ister misiniz?", "OYUN BİTTİ", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (cvp == DialogResult.No)
                {
                    return;
                }
                else
                {
                    btnBasla.PerformClick();
                    return;
                }
            }

            OyunuOynat(sender);
        }

        private void OyunuOynat(object sender)
        {
            bool buldunMu = false;
            Button secilenButon = (Button)sender;
            secilenButon.Enabled = false;
            // 1, 4, 7
            //ADANA
            //m
            for (int i = 0; i < secilenKelime.Length; i++)
            {
                if (secilenKelime[i].ToString().ToLower() == secilenButon.Text.ToLower())
                {
                    grpKelime.Controls[i].Text = secilenButon.Text;
                    dogruSayisi++;
                    DogruGuncelle();
                    buldunMu = true;
                }
            }

            if (!buldunMu)
            {
                oyunHakki--;
                lblHak.Text = $"Hak: {oyunHakki}";
            }
        }

        private void DogruGuncelle()
        {
            lblDogru.Text = $"Doğru: {dogruSayisi}";
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            dogruSayisi = 0;
            DogruGuncelle();
            //Tüm butonları aktif et:
            foreach (var item in flwHarfler.Controls)
            {
                Button btn= (Button)item;
                btn.Enabled = true;
            }

            //1-Dizi içerisinden random olarak bir il seçimi yapmamız gerekiyor.
            RandomOlarakBirIlSec();
            //2-Kelimedeki harf sayısı kadar buton ekleyelim
            ButonlarıAyarla();

        }

        private void ButonlarıAyarla()
        {
            grpKelime.Controls.Clear();

            for (int i = 0; i < secilenKelime.Length; i++)
            {
                Button btn = new Button();
                btn.Size = new Size(90, 90);
                btn.Location = new Point(40 + (i * 100), 60);
                btn.Text = "-";
                btn.Tag = i;
                btn.BackColor = Color.White;
                grpKelime.Controls.Add(btn);
            }
        }

        string secilenKelime;
        int sayac = 0;
        private void RandomOlarakBirIlSec()
        {
            do
            {
                if (secilenIller.Length == iller.Length)
                {
                    secilenIller = new string[1];
                    sayac = 0;
                }

                Random rnd = new Random();
                int rastgeleSayi = rnd.Next(0, iller.Length);
                secilenKelime = iller[rastgeleSayi];
                oyunHakki = (secilenKelime.Length / 2) + 1;
                HakGuncelle();

            } while (secilenIller.Contains(secilenKelime));

            secilenIller[sayac] = secilenKelime;
            sayac++;
            Array.Resize(ref secilenIller, secilenIller.Length + 1);
        }

        private void HakGuncelle()
        {
            lblHak.Text = $"Hak: {oyunHakki}";
        }
    }
}
