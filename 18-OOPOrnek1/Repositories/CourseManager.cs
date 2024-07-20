using _18_OOPOrnek1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOPOrnek1.Repositories
{
    public class CourseManager : IRepository<Course>
    {
        private CourseRepository _courseRepository;
        public CourseManager(CourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public void Add(Course entity)
        {
            //Bir kursun kayıt olabilmesi için kurs nesnesini null olmaması gerekmektedir. 
            //Daha sonra bir kontrol daha yapıyoruz. Burada da kursun mutlaka en az 1 adet dersinin olması (lesson) ve kursun bir eğitmeninin olması (educator) gerekmektedir. 

            if (entity == null)
            {
                throw new Exception("Kurs nesnesi null olmamalıdır.");
            }

            _courseRepository.Add(entity);
        }

        public void Delete(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new Exception("ID değeri boş veya Null olmamalıdır.");
            }
            _courseRepository.Delete(id);
        }
        public List<Course> GetAll()
        {
            return _courseRepository.GetAll();
        }
        public Course GetByID(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new Exception("ID değeri boş veya Null olmamalıdır.");
            }
            return _courseRepository.GetByID(id);
        }
        public void Update(Course entity)
        {
            if (entity != null)
            {
                _courseRepository.Update(entity);
            }
        }
    }
}
