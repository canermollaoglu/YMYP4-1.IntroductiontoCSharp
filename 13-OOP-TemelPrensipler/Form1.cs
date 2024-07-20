using _13_OOP_TemelPrensipler.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_OOP_TemelPrensipler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Projemde bulunan Product sınıfımın bir örneğini (instance) oluşturalım:
        //Product adlı sınıftan urun1 isimli bir nesne oluşturduk.
        Product urun1 = new Product();

        private void Form1_Load(object sender, EventArgs e)
        {

            urun1.ProductID = 1;
            urun1.ProductName = "HP Pavilion Laptop";
            urun1.UnitPrice = 45000.43;
            urun1.Description = "Çok ta güzel bir ürün.";
            urun1.StockQuantity = 5600;

            urun1.SellProduct(urun1.ProductID);
            urun1.UpdatePrice(5, 5600.34);



            Product urun2 = new Product();
            urun2.ProductID = 2;
            urun2.ProductName = "HP Pavilion PC";
            urun2.UnitPrice = 14500.53;
            urun2.Description = "Güzel bir ürün.";
            urun2.StockQuantity = 67;


            string desc = urun1.Description;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ProductName Get çalıştı:
            MessageBox.Show(urun1.ProductName);
            urun1.StockQuantity = 5601;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer c = new Customer()
            {
                Country = "USA",
                CustomerName = "Ahmet Aksakal",
                EmailAddress = "a.aksakal@gmail.com",
                IsActive = true
            };

            Customer c1 = new Customer();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Bazen nesne oluşturulurken belirli standartlarda yapılmasını isteyebiliriz.

            //Order o1 = new Order()
            //{
            //    OrderDate = DateTime.Now,
            //    OrderID = "10248",
            //    EmployeeID = 101,
            //    CustomerID = 405
            //};

            Order o2 = new Order(4, 6);
            o2.OrderID = "1";
            o2.OrderDate = DateTime.Now;
        }
    }
}
