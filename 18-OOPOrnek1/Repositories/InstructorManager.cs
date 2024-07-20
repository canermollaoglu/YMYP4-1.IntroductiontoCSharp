using _18_OOPOrnek1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOPOrnek1.Repositories
{
    //Manager sınıfı Repository içerinde bulunan metodların kontrollü bir şekilde çalıştırılmasını sağlar. Örneğin herhangi bir kurs ataması olmayan eğitmenin kayıt edilmesini istemeyebiliriz. Bu kontrol manager sınıfı içerisinde yapılır ve uygun ise Repository'e erişilerek ilgili ekle metodu çağrılır. 
    public class InstructorManager:IRepository<Instructor>
    {
        private InstructorRepository _instructorRepository;
        public InstructorManager(InstructorRepository instructorRepository)
        {
            _instructorRepository = instructorRepository;
        }

        public void Add(Instructor ins)
        {
            //Eğitmen kaydedilirken mutlaka eğitmenin en az 1 kursu olmalıdır.
            if (ins.Courses.Count == 0)
            {
                throw new Exception("Eğitmenin mutlaka en az 1 kursu olmalıdır.");
            }

            //_instructorRepository.InstructorExists(ins.Name, ins.Surname)==true
            if (_instructorRepository.InstructorExists(ins.Name, ins.Surname))
            {
                throw new Exception("Bu eğitmen daha önce sisteme girilmiştir.");
            }

            _instructorRepository.Add(ins);
        }

        public List<Instructor> GetAll()
        {
            return _instructorRepository.GetAll();
        }

        public void Delete(string id)
        {
            _instructorRepository.Delete(id);
        }

        public void Update(Instructor ins)
        {
            _instructorRepository.Update(ins);
        }

        public Instructor GetByID(string id)
        {
            return _instructorRepository.GetByID(id);
        }
    }
}
