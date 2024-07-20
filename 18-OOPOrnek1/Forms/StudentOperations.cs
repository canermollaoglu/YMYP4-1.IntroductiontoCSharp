using _18_OOPOrnek1.Entities;
using _18_OOPOrnek1.MyTool;
using _18_OOPOrnek1.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_OOPOrnek1.Forms
{
    public partial class StudentOperations : Form
    {
        public StudentOperations()
        {
            InitializeComponent();

        }
        StudentRepository sRepo = new StudentRepository();
        StudentManager sManager;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                sManager = new StudentManager(sRepo);

                if (Tools.BilgileriKotrolEt(grpOgrenciBilgileri))
                {
                    throw new Exception("Lütfen tüm alanları doldurunuz.");
                }

                Student s = new Student()
                {
                    Name = txtAd.Text,
                    Surname = txtSoyad.Text,
                    BirthDate = Convert.ToDateTime(txtDTarihi.Text),
                    TCKimlik = txtTC.Text
                };

                sManager.Add(s);
                OgrecileriGetir();
                MessageBox.Show("Kayıt Başarılı.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OgrecileriGetir()
        {
            lstListe.DataSource = null;
            lstListe.DisplayMember = "NameSurname";
            lstListe.ValueMember = "ID";
            lstListe.DataSource = sManager.GetAll();
        }

        private void StudentOperations_Load(object sender, EventArgs e)
        {
            sManager = new StudentManager(sRepo);

            var liste = Tools.OgrenciListesi;
            OgrecileriGetir();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                //listeden secilen öğrenci nesnesini yakalayarak silelim.
                if (lstListe.SelectedIndex != -1)
                {
                    sManager.Delete(s.ID);
                    OgrecileriGetir();
                }
                MessageBox.Show("Silme işlemi başarılı.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        Student s;
        private void lstListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            s = (Student)lstListe.SelectedItem;
        }
    }
}
