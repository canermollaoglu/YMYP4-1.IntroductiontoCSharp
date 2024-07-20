using _18_OOPOrnek1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOPOrnek1.Repositories
{
    //IRepository<T> where T : class
    //burada T tipinin yalnızca bir sınıf tipinde olması ile ilgili bir kısıtlama getirilmiştir.
  //  IRepository<T> where T : BaseEntity
  //T yerine yalnızca BaseEntity türünde (yani bu sınıftan türetilmiş) bir sınıf yazılabilir.
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(string id);
        T GetByID(string id);
        List<T> GetAll();
    }
}
