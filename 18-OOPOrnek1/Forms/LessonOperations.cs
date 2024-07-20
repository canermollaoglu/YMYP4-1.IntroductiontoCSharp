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
    public partial class LessonOperations : Form
    {
        public LessonOperations()
        {
            InitializeComponent();
        }

        CourseRepository cRepo = new CourseRepository();
        CourseManager cManager;
        LessonRepository lRepo = new LessonRepository();
        LessonManager lManager;
        private void LessonOperations_Load(object sender, EventArgs e)
        {
            try
            {
                cManager = new CourseManager(cRepo);
                lManager = new LessonManager(lRepo);
                //tüm kursları combobox'a yüklememiz gerekiyor:
                KurslariGetir();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void KurslariGetir()
        {
            cManager.GetAll().ForEach(c => cmbCourses.Items.Add(c));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Lesson s = new Lesson()
                {
                    Title = txtTitle.Text,
                    Content = txtContent.Text,
                    Duration = Convert.ToByte(nmrDuration.Value),
                    Date = dtDate.Value.Date,
                    Course = secilenKurs
                };

                lManager.Add(s);
                secilenKurs.Lessons.Add(s);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        Course secilenKurs;
        private void cmbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenKurs = (Course)cmbCourses.SelectedItem;
        }
    }
}
