using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_Ado.Net
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Form yüklendiğinde tüm kategorileri combobox'a yükle

            DataTable dt = GetAllData("Select CategoryID,CategoryName from Categories");

            cmbKategori.DisplayMember = "CategoryName";
            cmbKategori.ValueMember = "CategoryID";
            cmbKategori.DataSource = dt;
        }

        private DataTable GetAllData(string query)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand(query, cn);

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Hangi kategori secildi, Id bilgisine Value Member üzerinden ulaşalım:
            //herhangi birşey şeçili değil ise SelectedIndex -1 döner.
            if (cmbKategori.SelectedIndex != -1)
            {
                string secilenID = cmbKategori.SelectedValue.ToString();

                string sorgu = $"Select ProductID,ProductName from Products Where CategoryID={secilenID}";

               DataTable dt= GetAllData(sorgu);


                lstUrunListesi.DisplayMember = "ProductName";
                lstUrunListesi.ValueMember = "ProductID";
                lstUrunListesi.DataSource= dt;
            }
        }

        private void lstUrunListesi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
