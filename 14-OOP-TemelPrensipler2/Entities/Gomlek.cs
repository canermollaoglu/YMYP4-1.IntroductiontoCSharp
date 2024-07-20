using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_OOP_TemelPrensipler2.Entities
{
    //Gomlek sınıfı Urun sınıfından inherit olmuştur. 
    //inheritance (Kalıtım) yani Urun sınıfının tüm özellik ve metodlarına sahiptir. 
    public class Gomlek:Urun
    {
        public string Beden { get; set; }
        public string KumasTuru { get; set; }

        //override : ezmek
        public override double KdvHesapla()
        {
            return UnitPrice * 1.25;
        }
    }
}
