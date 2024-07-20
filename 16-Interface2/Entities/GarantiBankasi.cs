using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Interface2.Entities
{
    public class GarantiBankasi : Banka, IGuvenlikKontrolu
    {
        public int OgiReferansID { get; set; }
        public int KontrolID { get; set; }
        public string ReferansID { get; set; }

        public string KontrolEt(int kID, string RefID)
        {
            KontrolID = kID;
            ReferansID = RefID;

            return $"{KontrolID}-{ReferansID}";

            
        }
    }
}
