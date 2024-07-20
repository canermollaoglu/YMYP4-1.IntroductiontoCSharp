using _18_OOPOrnek1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOPOrnek1.Repositories
{
    //Veritabanına bağlanarak tüm CRUD işlemlerimizi yapacak olan sınıftır.
    //StudentRepository sınıfı IRepository interfaceini Student entitysi için implemente edecektir.
    public class StudentRepository : IRepository<Student>
    {
        private static List<Student> StudentList { get; set; } = new();

        public void Add(Student entity)
        {
            StudentList.Add(entity);
        }
        public void Delete(string id)
        {
            var student = StudentList.FirstOrDefault(s => s.ID == id);
            if (student == null)
                throw new Exception("Öğrenci Bulunamadı.");
            StudentList.Remove(student);
        }

        public List<Student> GetAll()
        {
            return StudentList;
        }

        public Student GetByID(string id)
        {
            return StudentList.FirstOrDefault(x=>x.ID == id);
        }

        public void Update(Student entity)
        {
            //revize edilecek.
            var bulunan=StudentList.FirstOrDefault(x=> x.ID == entity.ID);
        }
    }
}
