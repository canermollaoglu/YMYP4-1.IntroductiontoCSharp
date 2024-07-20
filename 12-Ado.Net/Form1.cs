using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_Ado.Net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UrunleriListele();
        }

        private void UrunleriListele()
        {
            lstListe.Items.Clear();

            SqlConnection cn = null;

            try
            {
                //instance 
                //Kutuphanede bulunan SqlConnection adlı sınıftan bir örnek(nesne) oluşturarak buraya getirdik.

                string connStr = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=NORTHWND;Integrated Security=True";
                cn = new SqlConnection(connStr);
                cn.Open();

                //SqlCommand cmd = new SqlCommand();
                //cmd.Connection = cn;
                //cmd.CommandText = "Select * from Products";

                SqlCommand cmd = new SqlCommand("Select * from Products", cn);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string urunAdi = dr["ProductName"].ToString();
                    int ID = Convert.ToInt32(dr["ProductID"]);
                    lstListe.Items.Add($"{ID}-{urunAdi}");
                }

                //MessageBox.Show("Başarılı");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn = null;
            try
            {
                cn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=NORTHWND;Integrated Security=True");
                //cn.Open();

                SqlCommand cmd = new SqlCommand("Select CategoryID,CategoryName,Description from Categories");
                cmd.Connection = cn;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);

                cmbKategoriler.DataSource = dt;
                cmbKategoriler.DisplayMember = "CategoryName";
                cmbKategoriler.ValueMember = "CategoryID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //cn.Close();
            }


        }

        SqlConnection cn = null;
        string cstr = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=NORTHWND;Integrated Security=True";
        private void button3_Click(object sender, EventArgs e)
        {
            //ÜRÜN EKLEME İŞLEMİ
            try
            {
                cn = new SqlConnection(cstr);
                cn.Open();

                SqlCommand cmdEkle = new SqlCommand("Insert into Products (ProductName,UnitPrice,Discontinued) values(@name,@price,@disc)", cn);

                cmdEkle.Parameters.AddWithValue("@name", "HP Laptop");
                cmdEkle.Parameters.AddWithValue("@price", 25500);
                cmdEkle.Parameters.AddWithValue("@disc", true);

                //ExecuteNonQuery geriye işlemden etkilenen satır sayısını döner.
                int sonuc = cmdEkle.ExecuteNonQuery();

                if (sonuc == 1)
                {
                    UrunleriListele();
                    MessageBox.Show("ekleme islemi başarılı.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //ÜRÜN SİLME İŞLEMİ

            try
            {
                cn = new SqlConnection(cstr);
                cn.Open();

                SqlCommand cmdSil = new SqlCommand("Delete from Products where ProductID=@id", cn);
                cmdSil.Parameters.AddWithValue("@id", txtID.Text);

                int etkilenenSatirSayisi = cmdSil.ExecuteNonQuery();

                string mesaj = etkilenenSatirSayisi == 1 ? "İşlem Başarılı" : "Silme işleminde hata oluştu.";

                UrunleriListele();

                MessageBox.Show(mesaj);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { cn.Close(); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                cn = new SqlConnection(cstr);
                cn.Open();
                SqlCommand cmdGuncelle = new SqlCommand("Update Products Set ProductName=@pname where ProductID=@id", cn);
                cmdGuncelle.Parameters.AddWithValue("@pname", "Iphone 14 Pro Max");
                cmdGuncelle.Parameters.AddWithValue("@id", txtID.Text);

                int islem = cmdGuncelle.ExecuteNonQuery();

                if (islem != 0)
                {
                    UrunleriListele();
                    MessageBox.Show("Güncelleme Başarılı.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.TextLength >= 3)
            {
                string aramaKelimesi = txtSearch.Text;
                AramaBaslat(aramaKelimesi); //like
            }
            else if (txtSearch.TextLength == 0)
            {
                UrunleriListele();
            }
        }

        private void AramaBaslat(string aramaKelimesi)
        {
            try
            {
                lstListe.Items.Clear();

                cn = new SqlConnection(cstr);
                cn.Open();

                SqlCommand cmdSec = new SqlCommand($"Select * from Products where ProductName like '%{aramaKelimesi}%'", cn);

                //SqlCommand cmdSec1 = new SqlCommand("Select * from Products where ProductName like %'"+aramaKelimesi+"%'", cn);

                SqlDataReader dr = cmdSec.ExecuteReader();

                while (dr.Read())
                {
                    lstListe.Items.Add($"{dr["ProductID"]}-{dr["ProductName"]}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
