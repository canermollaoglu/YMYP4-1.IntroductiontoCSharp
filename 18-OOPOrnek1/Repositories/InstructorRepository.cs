using _18_OOPOrnek1.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOPOrnek1.Repositories
{
    public class InstructorRepository : IRepository<Instructor>
    {
        public List<Instructor> InstructorList { get; set; } = new();
        public void Add(Instructor entity)
        {
            InstructorList.Add(entity);
        }

        public void Delete(string id)
        {
            var instructor = InstructorList.FirstOrDefault(x => x.ID == id);
            if (instructor != null)
            {
                InstructorList.Remove(instructor);
            }
        }
        public List<Instructor> GetAll()
        {
            return InstructorList;
        }

        public Instructor GetByID(string id)
        {
            var instructor = InstructorList.FirstOrDefault(x => x.ID == id);
            return instructor;
        }

        public void Update(Instructor entity)
        {
            var instructor = InstructorList.FirstOrDefault(x => x.ID == entity.ID);
        }

        public bool InstructorExists(string firstName, string lastName)
        {
            //Any Extention Metodu geriye true false döndüğü için tercih ettik.
           return InstructorList.Any(x => x.Name == firstName && x.Surname == lastName);
        }
    }
}
