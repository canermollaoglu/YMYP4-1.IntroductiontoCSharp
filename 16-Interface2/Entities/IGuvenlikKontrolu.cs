using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Interface2.Entities
{
    public interface IGuvenlikKontrolu
    {
        int KontrolID { get; set; }
        string ReferansID { get; set; }
        string KontrolEt(int kID,string RefID);
    }
}
