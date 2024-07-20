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
    public partial class InstructorOperation : Form
    {
        public InstructorOperation()
        {
            InitializeComponent();
        }

        InstructorRepository instRepo = new InstructorRepository();
        CourseRepository courseRepo = new CourseRepository();
        InstructorManager instManager;
        CourseManager courseManager;
        private void InstructorOperation_Load(object sender, EventArgs e)
        {
            instManager = new InstructorManager(instRepo);
            courseManager = new CourseManager(courseRepo);
            TumEgitmenleriGetir();
            TumKurslariGetir();

        }

        private void TumKurslariGetir()
        {
            var courses = courseManager.GetAll();
            foreach (var course in courses)
            {
                lstKurslar.Items.Add(course);
            }
        }

        private void TumEgitmenleriGetir()
        {
            var instructors = instManager.GetAll();
            dgwEgitmenListesi.DataSource = instructors.ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (Tools.BilgileriKotrolEt(grpBilgiler))
                {
                    throw new Exception("Lütfen tüm alanları doldurunuz.");
                }

                Instructor egitmen = new Instructor()
                {
                    Name = txtAd.Text,
                    Surname = txtSoyad.Text,
                    Email = txtEmail.Text,
                    IsActive = true,
                    PhoneNumber = txtTelefon.Text,
                    Profession = txtUzmanlik.Text,
                    Courses = secilenKurslar
                };

                instManager.Add(egitmen);
                SecilenKurslariTemizle();
                lblHata.Text = "İşlem Başarılı.";

                TumEgitmenleriGetir();

                dgwEgitmenListesi.ClearSelection();
                FormuTemizle();
            }
            catch (Exception ex)
            {
                lblHata.Text = ex.Message;
            }
        }

        private void SecilenKurslariTemizle()
        {
            secilenKurslar = new();
            lstAtananKurslar.Items.Clear();
        }

        private void FormuTemizle()
        {
            foreach (var item in grpBilgiler.Controls)
            {
                if (item is TextBox)
                {
                    TextBox t = (TextBox)item;
                    t.Text = string.Empty;
                }
            }
        }


        List<Course> secilenKurslar = new List<Course>();
        private void btnKursAta_Click(object sender, EventArgs e)
        {
            if (lstKurslar.SelectedIndex != -1)
            {
                Course secilen = (Course)lstKurslar.SelectedItem;
                secilenKurslar.Add(secilen);

                SecilenKurslariGoster();

            }
        }

        private void SecilenKurslariGoster()
        {
            lstAtananKurslar.Items.Clear();

            foreach (var item in secilenKurslar)
            {
                lstAtananKurslar.Items.Add(item);
            }
        }

        private void dgwEgitmenListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgwEgitmenListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        string secilenID;
        private void dgwEgitmenListesi_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Datagrid üzerinden secilen satır yakalandı:
            DataGridViewRow selectedRow = ((DataGridView)sender).Rows[e.RowIndex];

            //ilgili alanları giderek sutunlarına göre dolduralım:
            secilenID = selectedRow.Cells["ID"].Value.ToString();
            txtAd.Text = selectedRow.Cells["Name"].Value.ToString();
            txtSoyad.Text = selectedRow.Cells["Surname"].Value.ToString();
            txtEmail.Text = selectedRow.Cells["Email"].Value.ToString();
            txtUzmanlik.Text = selectedRow.Cells["Profession"].Value.ToString();
            txtTelefon.Text = selectedRow.Cells["PhoneNumber"].Value.ToString();

            //secilen eğitmene ait olan kursları listeye yükleyelim:
            Instructor secilenEgitmen = instManager.GetByID(secilenID);

            SecilenKurslariTemizle();

            foreach (var item in secilenEgitmen.Courses)
            {
                lstAtananKurslar.Items.Add(item);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(secilenID))
                {
                    DialogResult result = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Egitmen Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        instManager.Delete(secilenID);
                        TumEgitmenleriGetir();
                        FormuTemizle();
                        SecilenKurslariTemizle();
                    }
                }
            }
            catch (Exception ex)
            {
                lblHata.Text = ex.Message;
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            if (lstAtananKurslar.SelectedIndex != -1)
            {
                Course secilen = (Course)lstAtananKurslar.SelectedItem;
                secilenKurslar.Remove(secilen);
                SecilenKurslariGoster();
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                //id yardımı ile güncellenmek istenen eğitmen bulunur.
                var egitmen = instManager.GetByID(secilenID);

                if (!Tools.BilgileriKotrolEt(grpBilgiler))
                {
                    egitmen.Name = txtAd.Text;
                    egitmen.Surname = txtSoyad.Text;
                    egitmen.Email = txtEmail.Text;
                    egitmen.PhoneNumber = txtTelefon.Text;
                    egitmen.Profession = txtUzmanlik.Text;
                    egitmen.Courses = secilenKurslar;
                }

                instManager.Update(egitmen);
                lblHata.Text = "Güncelleme İşlemi Başarılı.";
                TumEgitmenleriGetir();
            }
            catch (Exception ex)
            {
                lblHata.Text = ex.Message;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tools.OgrenciListesi.Add(new Student()
            {
                Name = "Caner",
                Surname = "Mollaoğlu"
            });

        }
    }
}
