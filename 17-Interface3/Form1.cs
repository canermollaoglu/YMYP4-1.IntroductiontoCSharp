using _17_Interface3.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17_Interface3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BankManager bmr;
        private void Form1_Load(object sender, EventArgs e)
        {
            //BankManagerOld bmr=new BankManagerOld();
            //bmr.Ekle(1);
            GarantiBankasi g = new GarantiBankasi();
            bmr = new BankManager(g);
            MessageBox.Show(bmr.Ekle());

            ZiraatBankasi z = new ZiraatBankasi();
            bmr = new BankManager(z);
            MessageBox.Show(bmr.Guncelle(5));


        }
    }
}
