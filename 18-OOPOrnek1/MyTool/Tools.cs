using _18_OOPOrnek1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_OOPOrnek1.MyTool
{
    public static class Tools
    {
        /*
         * STATİC: 
         * Belirli bir türün veya üyenin örnek (instance) yerine türün (sınıfın) kendisine ait olduğunu belirtir.
         * 
         Static sınıfların örneği oluşturulmaz.
        Static bir sınıfın öğeleri (property, metodlar) static olmalıdır.
        Static bir sınıftan miras alınamaz.

         */

        public static int deger = 100;

        public static bool BilgileriKotrolEt(GroupBox grp)
        {
            bool sonuc = false;

            foreach (var item in grp.Controls)
            {
                if (item is TextBox)
                {
                    TextBox t = item as TextBox;
                    if (string.IsNullOrEmpty(t.Text))
                    {
                        sonuc = true;
                        break;
                    }
                }

                if (item is DateTimePicker)
                {
                    DateTimePicker dt = item as DateTimePicker;
                    if (dt.Value.Date < DateTime.Now.Date)
                    {
                        sonuc = true;
                        break;
                    }
                }
            }
            return sonuc;
        }

        public static List<Student> OgrenciListesi { get; set; } = new();

        public static List<Student> TumOgrenciListesi()
        {
            OgrenciListesi.Add(new Student() { Name = "Ahmet", Surname = "Uzun" });
            OgrenciListesi.Add(new Student() { Name = "Ayşe", Surname = "Kısa" });

            return OgrenciListesi;
        }
    }
}
