using _18_OOPOrnek1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOPOrnek1.Repositories
{
    public class ExamManager : IRepository<Exam>
    {
        private ExamRepository _repository;
        public ExamManager(ExamRepository eRepo)
        {
            _repository = eRepo;
        }

        public void Add(Exam entity)
        {
            if (entity.Date.Date < DateTime.Now.Date)
            {
                throw new Exception("Sınav tarihi geçmiş bir tarih olamaz.");
            }

            if (_repository.GetByExamNameandDate(entity))
            {
                throw new Exception("Aynı isim ve tarihli sınav girişi yapılamaz.");
            }

            _repository.Add(entity);
        }

        public void Delete(string id)
        {
            _repository.Delete(id);
        }

        public List<Exam> GetAll()
        {
            return _repository.GetAll();
        }

        public Exam GetByID(string id)
        {
            return _repository.GetByID(id);
        }

        public void Update(Exam entity)
        {
            _repository.Update(entity);
        }
    }
}
