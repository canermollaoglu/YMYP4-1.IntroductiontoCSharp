using _20_EntityFrameworkCodeFirst.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_EntityFrameworkCodeFirst.Dal
{
    //DB'deki tablolarımızı belirleyeceğimiz alan.
    // enable-migrations
    // add-migration <isim verilecek>
    // update-database
    public class Context:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SatisDB;Integrated Security=True;");
        }
    }
}
