using _18_OOPOrnek1.Entities;
using _18_OOPOrnek1.Forms;
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

namespace _18_OOPOrnek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Instructor egitici = new Instructor()
            {
                Name = "Ahmet",
                Surname = "Aksakal",
                Email = "a.aksakal@hotmail.com",
                IsActive = true,
                Profession = ".NET",
            };

            Course c = new Course()
            {
                CourseName = "Yazılım Kursu",
                IsActive = true,
                StartDate = DateTime.Now,
                EndDate = new DateTime(2024, 08, 10),
                Educator = egitici
            };

            InstructorRepository instRepo = new InstructorRepository();
            InstructorManager im = new InstructorManager(instRepo);
        }

        private void eğitmenİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Formun instance'ını alarak, içerisinde bulunan show() metodu çalıştırılarak form açılabilir.
            //instForm.MdiParent = this;
            //instForm.Show();

            //Uygulamada şuan açık olan formları geriye bir koleksiyon olarak döner>> Application.OpenForms

            //Şuan açık olan formları kontrol edelim. instForm açık ise mesaj verelim, açık değil ise açalım.

            InstructorOperation instForm = new InstructorOperation();

            FormKontrol(instForm);

        }

        private void FormKontrol(Form f)
        {
            bool formAcikMi = false;

            foreach (Form item in Application.OpenForms)
            {
                if (item.Name == f.Name)
                {
                    formAcikMi = true;
                    break;
                }
            }

            if (formAcikMi)
            {
                MessageBox.Show("Form Zaten Açık.");
            }
            else
            {
                f.MdiParent = this;
                f.Show();
            }
        }

        private void kursİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseOperations cForm = new CourseOperations();
            FormKontrol(cForm);
        }

        private void dersİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LessonOperations ls = new LessonOperations();
            FormKontrol(ls);
        }

        private void öğrenciİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentOperations sform = new StudentOperations();
            FormKontrol(sform);
        }

        private void sınavİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExamOperations exOp = new ExamOperations();
            FormKontrol(exOp);
        }

        private void kayıtİşlemleriFormuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrationOperations rform = new RegistrationOperations();
            FormKontrol(rform);
        }

        private void sınavSonuçGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExamResultOperations eOp = new ExamResultOperations();
            FormKontrol(eOp);
        }
    }
}
