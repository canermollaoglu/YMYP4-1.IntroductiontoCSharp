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
    public partial class ExamResultOperations : Form
    {
        public ExamResultOperations()
        {
            InitializeComponent();
        }

        StudentRepository studentRep = new StudentRepository();
        ExamRepository examRep = new ExamRepository();
        ExamResultRepository examResultRep = new ExamResultRepository();

        ExamResultManager examResultMan;
        ExamManager examMan;
        StudentManager studentMan;

        private void ExamResultOperations_Load(object sender, EventArgs e)
        {
            studentMan = new StudentManager(studentRep);
            examMan = new ExamManager(examRep);
            examResultMan = new ExamResultManager(examResultRep);

            Doldur();
        }

        private void Doldur()
        {
            studentMan.GetAll().ForEach(s => cmbOgrenciler.Items.Add(s));
            examMan.GetAll().ForEach(s => cmbSinavlar.Items.Add(s));
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbOgrenciler.SelectedIndex == -1 || cmbSinavlar.SelectedIndex == -1)
                {
                    throw new Exception("Lütfen Öğrenci ve Sınav Seçimi Yapınız.");
                }

                ExamResult eRes = new ExamResult()
                {
                    Exam = secilenExam,
                    Student = secilenStudent,
                    Grade = Convert.ToByte(nmrNot.Value)
                };
                examResultMan.Add(eRes);
                TumSinavSonuclariniGetir();
                MessageBox.Show("Kayıt Başarılı");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TumSinavSonuclariniGetir()
        {
            examResultMan.GetAll().ForEach(x => lstListe.Items.Add(x));
        }

        Student secilenStudent;
        Exam secilenExam;
        private void cmbOgrenciler_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenStudent = (Student)cmbOgrenciler.SelectedItem;
        }

        private void cmbSinavlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenExam = (Exam)cmbSinavlar.SelectedItem;
        }
    }
}
