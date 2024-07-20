using System;
using System.Windows.Forms;

namespace YMYP4_18042024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Windows form ortamı event-driven bir ortamdır. Yani kodları yazmadan önce ne zaman çalışmasını istediğimizi düşünmemiz gerekir. Örneğin formun load eventi, butonun click eventi gibi.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //bu alana biz SCOPE diyoruz.

            //tekli yorum satırı bu şekilde tanımlanır.

            /*
             Çoklu yorum satırı bu şekilde tanımlanır.
            */

            //20:45 te başlıyoruz.
        
        }
    }
}
