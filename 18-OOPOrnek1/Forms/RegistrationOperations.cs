using _18_OOPOrnek1.Entities;
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
    public partial class RegistrationOperations : Form
    {
        public RegistrationOperations()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        CourseRepository cRep = new CourseRepository();
        CourseManager cMan;
        StudentRepository stRep = new StudentRepository();
        StudentManager stMan;
        RegistrationRepository regRep = new RegistrationRepository();
        RegistrationManager regMan;

        private void RegistrationOperations_Load(object sender, EventArgs e)
        {
            stMan = new StudentManager(stRep);
            cMan = new CourseManager(cRep);
            regMan = new RegistrationManager(regRep);

            Doldur();
            ListViewInitialize();
        }

        private void ListViewInitialize()
        {
            lstListe.View = View.Details;
            lstListe.FullRowSelect = true;
            lstListe.Columns.Add("Ad Soyad", 200);
            lstListe.Columns.Add("Kurs Adı", 250);
            lstListe.Columns.Add("Kurs Fiyatı", 150);
        }

        private void Doldur()
        {
            cMan.GetAll().ForEach(x => cmbKurslar.Items.Add(x));
            stMan.GetAll().ForEach(x => cmbOgrenciler.Items.Add(x));
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbOgrenciler.SelectedIndex != -1 && cmbKurslar.SelectedIndex != -1 && !string.IsNullOrEmpty(txtKursFiyati.Text))
                {
                    Registration reg = new Registration()
                    {
                        Price = Convert.ToDecimal(txtKursFiyati.Text),
                        Course = secilenKurs,
                        Student = secilenOgrenci
                    };
                    regMan.Add(reg);
                    KayitlariGetir();
                    MessageBox.Show("Kayıt Başarılı");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void KayitlariGetir()
        {
            foreach (var item in regMan.GetAll())
            {
                var listviewItem = new ListViewItem(item.Student.NameSurname);
                listviewItem.SubItems.Add(item.Course.CourseName);
                listviewItem.SubItems.Add(item.Price.ToString());

                lstListe.Items.Add(listviewItem);
            }
        }

        Course secilenKurs;
        Student secilenOgrenci;
        private void cmbKurslar_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenKurs = (Course)cmbKurslar.SelectedItem;
        }

        private void cmbOgrenciler_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenOgrenci = cmbOgrenciler.SelectedItem as Student;
        }
    }
}
