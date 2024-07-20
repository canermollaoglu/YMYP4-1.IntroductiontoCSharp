using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_OOP_TemelPrensipler2.Entities
{
    public class Sepet
    {
        public Sepet()
        {
            UrunListesi = new List<Urun>();
        }
        private List<Urun> UrunListesi { get; set; }

        public void UrunEkle(Urun yeniUrun)
        {
            //urun var mı bak,
            //varsa adedini güncelle,
            //yoksa ekle

            //aranan değeri bulursa değerin kendisini,
            //bulamazsa NULL döner.
            var bulunan = UrunListesi.FirstOrDefault(x => x.ProductName == yeniUrun.ProductName);


            if (bulunan != null)
            {
                //adet güncelle
                bulunan.Quantity += yeniUrun.Quantity;
            }
            else
            {
                //urun yok demektir, ekle
                UrunListesi.Add(yeniUrun);
            }
        }

        public List<Urun> TumUrunleriGetir()
        {
            return UrunListesi;
        }
    }
}
