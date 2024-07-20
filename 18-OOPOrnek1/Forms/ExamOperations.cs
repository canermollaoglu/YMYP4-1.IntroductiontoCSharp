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
    public partial class ExamOperations : Form
    {
        public ExamOperations()
        {
            InitializeComponent();
        }

        ExamRepository exRepo = new ExamRepository();
        ExamManager exManager;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                exManager = new ExamManager(exRepo);

                if (Tools.BilgileriKotrolEt(grpSinavBilgileri))
                {
                    throw new Exception("Lütfen tüm alanları doldurunuz.");
                }

                if (lstList.SelectedIndex == -1)
                {
                    Exam ex = new Exam()
                    {
                        Name = txtSinavAdi.Text,
                        Date = dtSinavTarihi.Value.Date
                    };


                    exManager.Add(ex);
                    TumSinavlariGetir();
                }
                else
                {
                    secilen.Name=txtSinavAdi.Text;
                    secilen.Date = dtSinavTarihi.Value.Date;

                    exManager.Update(secilen);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TumSinavlariGetir()
        {
            lstList.Items.Clear();

            foreach (var item in exManager.GetAll())
            {
                lstList.Items.Add(item);
            }
        }

        Exam secilen;
        private void lstList_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilen= (Exam)lstList.SelectedItem;

            txtSinavAdi.Text=secilen.Name;
            dtSinavTarihi.Value=secilen.Date;
        }
    }
}
