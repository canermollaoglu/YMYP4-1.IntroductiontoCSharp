using _18_OOPOrnek1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOPOrnek1.Repositories
{
    public class StudentManager : IRepository<Student>
    {
        private StudentRepository _studentRepository;
        public StudentManager(StudentRepository sRepo)
        {
            _studentRepository = sRepo;
        }
        public void Add(Student entity)
        {
            if (string.IsNullOrEmpty(entity.Name) && string.IsNullOrEmpty(entity.Surname))
            {
                throw new Exception("Lütfen Ad Soyad Bilgisini Giriniz.");
            }

            _studentRepository.Add(entity);
        }

        public void Delete(string id)
        {

            if (string.IsNullOrEmpty(id))
            {
                throw new Exception("Id Bilgisi Boş Olamaz.");
            }

            _studentRepository.Delete(id);
        }

        public List<Student> GetAll()
        {
            
            return _studentRepository.GetAll();
        }

        public Student GetByID(string id)
        {
            var bulunanOgrenci = _studentRepository.GetByID(id);

            if (bulunanOgrenci == null)
                throw new Exception("Öğrenci bulunamadı.");

            return bulunanOgrenci;

        }

        public void Update(Student entity)
        {
            if (entity != null)
            {
                _studentRepository.Update(entity);
            }
        }
    }
}
