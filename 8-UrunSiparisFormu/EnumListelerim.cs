using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_UrunSiparisFormu
{
    /*
     Enumeration (enum) bir türdür ve genellikle gruplandırılması veya birbirine bağlı olması gereken durumlar için kullanılır. 

    1-Durumları belirlerken: (beklemede, tamamlandı, iptal edildi)
    2-Seçeneklerde: (kadın, erkek)
    3-Sabitler: (Haftanın günleri)
    4-Kod okunabilirliğini artırır.
     */

    enum Aylar
    {
        Ocak,
        Şubat,
        Mart,
        Nisan
    }

    enum Kategoriler : byte
    {
        Elektronik = 1,
        EvEşyaları = 2
    }
}
