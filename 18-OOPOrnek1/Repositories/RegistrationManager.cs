using _18_OOPOrnek1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_OOPOrnek1.Repositories
{
    public class RegistrationManager : IRepository<Registration>
    {
        private RegistrationRepository _rRepository;
        public RegistrationManager(RegistrationRepository rRepo)
        {
            _rRepository = rRepo;
        }
        public void Add(Registration entity)
        {
            if (entity.Student == null || entity.Course == null)
            {
                throw new Exception("Kayıt için mutlaka en az bir öğrenci ve kurs bilgisi olmalıdır.");
            }

            _rRepository.Add(entity);
        }

        public void Delete(string id)
        {
            _rRepository.Delete(id);
        }

        public List<Registration> GetAll()
        {
            return _rRepository.GetAll();
        }

        public Registration GetByID(string id)
        {
            return _rRepository.GetByID(id);
        }

        public void Update(Registration entity)
        {
            _rRepository.Update(entity);
        }
    }
}
