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
    public partial class CourseOperations : Form
    {
        private readonly CourseManager cManager;
        public CourseOperations()
        {
            InitializeComponent();
            CourseRepository cRepo = new CourseRepository();
            cManager = new CourseManager(cRepo);
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Tools.BilgileriKotrolEt(groupBox1))
                {
                    throw new Exception("Lütfen girilen bilgileri kontrol ediniz.");
                }

                if (dtStartDate.Value.Date == dtEndDate.Value.Date || dtStartDate.Value.Date > dtEndDate.Value.Date)
                {
                    throw new Exception("Başlangıç ve bitiş tarihleri farklı olmalıdır.");
                }

                Course cr = new Course()
                {
                    CourseName = txtCourseName.Text,
                    StartDate = dtStartDate.Value.Date,
                    EndDate = dtEndDate.Value.Date
                };

                cManager.Add(cr);
                KurslariGetir();
                MessageBox.Show("Ekleme işlemi başarılı.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void KurslariGetir()
        {
            lstKursListesi.Items.Clear();

            //foreach (var item in cManager.GetAll())
            //{
            //    lstKursListesi.Items.Add(item);
            //}

            cManager.GetAll().ForEach(x => lstKursListesi.Items.Add(x));
        }
    }
}
