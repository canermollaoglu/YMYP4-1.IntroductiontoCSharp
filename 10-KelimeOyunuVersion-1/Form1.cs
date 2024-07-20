using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_KelimeOyunuVersion_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] kelimeData = new string[1];
        int sayac = 0;
        string gelenKelime;
        private void btnOyna_Click(object sender, EventArgs e)
        {
            //Oyna butonuna bastığımızda textbox'a girilen kelimenin harfleri kadar buton oluşturularak groupbox'a eklenecektir. Aynı zamanda tüm kelimeler string bir dizi içerisinde tutulacaktır.

            //kütüphanede bulunan Button adlı sınıftan bir adet örnek oluşturarak projemize aldık.
            //kutuphanede bulunan Button adlı CLASS(SINIF) tan bir örnek alarak btn isimdi bir NESNE oluşturduk.

            //Button btn = new Button();
            //btn.Size = new Size(90, 90);
            //btn.Location = new Point(60, 60);
            //btn.Text = "--";
            //btn.Name = "btn_1";
            //btn.Click += btn_Click;
            //grpHarfler.Controls.Add(btn);


            //Button yeniButon = new Button();
            //yeniButon.Size = new Size(90, 90);
            //yeniButon.Location = new Point(180, 60);
            //yeniButon.Text = "--";
            //yeniButon.Name = "btn_2";
            //yeniButon.Click += btn_Click;
            //grpHarfler.Controls.Add(yeniButon);


            //Button yepyeniButton = new Button();
            //yepyeniButton.Size = new Size(90, 90);
            //yepyeniButton.Location = new Point(300, 60);
            //yepyeniButton.Text = "--";
            //yepyeniButton.Name = "btn_3";
            //yepyeniButton.Click += btn_Click;
            //grpHarfler.Controls.Add(yepyeniButton);

            //her string aslında bir char dizisidir.
            gelenKelime = txtKelime.Text;

            char deger = gelenKelime[1];

            int kelimeHarfSayisi = gelenKelime.Length;

            grpHarfler.Controls.Clear();

            for (int i = 0; i < kelimeHarfSayisi; i++)
            {
                Button btn = new Button();
                btn.Size = new Size(90, 90);
                btn.Location = new Point(40 + (i * 100), 60);
                btn.Text = "--";
                btn.Name = "btn_" + i;
                btn.Tag = i;
                btn.Click += btn_Click;
                grpHarfler.Controls.Add(btn);
            }

            kelimeData[sayac] = gelenKelime;
            Array.Resize(ref kelimeData, kelimeData.Length + 1);
            sayac++;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            //Hangi butonun tıklandığını yakalayalım.
            Button btn = sender as Button;
            //Button btn1 = (Button)sender;

            //string indexNo = btn.Name.Substring(4, 1);
            int hangiIndex = Convert.ToInt32(btn.Tag);
            btn.Text = gelenKelime[hangiIndex].ToString();
            btn.BackColor = Color.Green;
            btn.ForeColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
