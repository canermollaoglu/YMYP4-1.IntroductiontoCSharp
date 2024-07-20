using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Interface3.Entities
{
    public interface IBankManager
    {
        string AddTransaction();
        string UpdateTransaction(int id);
        string DeleteTransaction(int id);
    }
}
