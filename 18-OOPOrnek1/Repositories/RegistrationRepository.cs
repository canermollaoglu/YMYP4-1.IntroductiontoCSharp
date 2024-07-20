using _18_OOPOrnek1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOPOrnek1.Repositories
{
    public class RegistrationRepository : IRepository<Registration>
    {
        private List<Registration> RegistrationList { get; set; } = new();

        public void Add(Registration entity)
        {
            RegistrationList.Add(entity);
        }

        public void Delete(string id)
        {
            RegistrationList.Remove(RegistrationList.FirstOrDefault(x => x.ID == id));
        }

        public List<Registration> GetAll()
        {
            return RegistrationList;
        }

        public Registration GetByID(string id)
        {
            return RegistrationList.FirstOrDefault(r => r.ID == id);
        }

        public void Update(Registration entity)
        {
            var bulunan = RegistrationList.FirstOrDefault(r => r.ID == entity.ID);
            bulunan.RegistrationDate = entity.RegistrationDate;
            bulunan.Price = entity.Price;
            bulunan.Student = entity.Student;
            bulunan.Course = entity.Course;
        }
    }
}
