using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_OOP_TemelPrensipler2.Entities
{
    public class CepTelefonu:Urun
    {
        public byte BataryaSuresi { get; set; }
        public byte RamKapasitesi { get; set; }

        public override double KdvHesapla()
        {           
            return UnitPrice * 1.20;
        }
    }
}
