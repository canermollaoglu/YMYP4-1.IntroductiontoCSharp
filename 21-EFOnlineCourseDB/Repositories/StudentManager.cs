using _21_EFOnlineCourseDB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_EFOnlineCourseDB.Repositories
{
    public class StudentManager : IManager<Student>
    {
        public void Create(Student entity)
        {
            
        }

        public void DeleteByID(Guid id)
        {
            
        }

        public List<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public Student GetByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Student entity)
        {
            throw new NotImplementedException();
        }
    }
}
