using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Interface1
{
    //Base Class
    public class Hayvan
    {
        public byte Yas { get; set; }
        public string Renk { get; set; }

        public virtual string HareketEt()
        {
            return "Hareket Ediyorum";
        }
    }

    //Child Class 1
    public class Kopek:Hayvan
    {
        public string Isim { get; set; }

        public override string HareketEt()
        {
            return "Koşarak ve Zıplayarak Hareket Edebilirim";
        }
    }

    //Child Class (Derived) 2

    public class Yarasa : Hayvan,IUcabilir
    {
        public byte GorusAcisi { get; set; }
        public int UcusHizi { get; set; }
        public string UcusYonu { get; set ; }

        public override string HareketEt()
        {
            return "Geceleri Hareket Ederim.";
        }

        public void Uc()
        {
            
        }
    }

    public interface IUcabilir
    {
        void Uc();
        string UcusYonu { get; set; }
    }
}
