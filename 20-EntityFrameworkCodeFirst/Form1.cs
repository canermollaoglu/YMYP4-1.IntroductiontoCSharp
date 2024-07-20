using _20_EntityFrameworkCodeFirst.Dal;
using _20_EntityFrameworkCodeFirst.Entities;

namespace _20_EntityFrameworkCodeFirst
{
    public partial class Form1 : Form
    {
        private Context _context;
        public Form1()
        {
            InitializeComponent();

            _context = new Context();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Category cat = new Category()
                {
                    CategoryName = txtKategoriAdi.Text,
                    Description = txtKategoriAciklama.Text
                };

                _context.Categories.Add(cat);
                _context.SaveChanges();
                KategorileriListele();

                MessageBox.Show("Kayýt Baþarýlý");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void KategorileriListele()
        {
            lstListe.DataSource = _context.Categories.ToList();
            lstListe.DisplayMember = "CategoryName";
            lstListe.ValueMember = "CategoryID";
        }

        private void btnUrunKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = new Product()
                {
                    ProductName = txtUrunAdi.Text,
                    UnitPrice = Convert.ToDecimal(txtUrunFiyati.Text),
                    UnitsInStock = Convert.ToInt32(txtStokMiktari.Text),
                    Description = txtUrunAciklama.Text,
                    Category = secilenKategori
                };

                _context.Products.Add(p);
                _context.SaveChanges();
                UrunleriListele();
                MessageBox.Show("Kayýt Baþarýlý.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UrunleriListele()
        {
            dgwUrunListesi.DataSource = _context.Products.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstListe.SelectedIndex = -1;
            KategorileriListele();
            UrunleriListele();
        }

        Category secilenKategori;
        private void lstListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstListe.SelectedItem != null)
            {
                secilenKategori = (Category)lstListe.SelectedItem;
                txtKategoriAdi.Text = secilenKategori.CategoryName;
                txtKategoriAciklama.Text = secilenKategori.Description;
            }
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            if (dgwUrunListesi.SelectedRows.Count > 0)
            {
                int productID = (int)dgwUrunListesi.SelectedRows[0].Cells["ProductID"].Value;

                var silinecekUrun = _context.Products.FirstOrDefault(x => x.ProductID == productID);

                if (silinecekUrun != null)
                {
                    _context.Products.Remove(silinecekUrun);
                    _context.SaveChanges();
                    MessageBox.Show("Silme iþlemi baþarýlý");
                }

                UrunleriListele();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtKategoriAdi.Text = "";
            txtKategoriAciklama.Text = "";
        }

        private void btnKategoriGuncelle_Click(object sender, EventArgs e)
        {
            //ilk olarak güncelleme yapýlacak olan nesne bulunur.
            var guncelenecekKategori = _context.Categories.Find(secilenKategori.CategoryID);

            //sonra deðerlerini güncelleriz.
            if (guncelenecekKategori != null)
            {
                guncelenecekKategori.CategoryName = txtKategoriAdi.Text;
                guncelenecekKategori.Description = txtKategoriAciklama.Text;
            }
            _context.SaveChanges();
            KategorileriListele();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            lstFiltre.Items.Clear();
            //Birim Fiyatý 400 TL ile 1200 TL arasýnda olan ürünlerin ürün adý ve fiyatýný listeleyiniz.

            //LINQ - Lambda Expression
            _context.Products.Where(x => x.UnitPrice >= 400 && x.UnitPrice <= 1200).ToList().ForEach(x => lstFiltre.Items.Add($"{x.ProductName}-{x.UnitPrice}"));
        }
    }
}
