using _18_OOPOrnek1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOPOrnek1.Repositories
{
    public class ExamResultManager : IRepository<ExamResult>
    {
        private ExamResultRepository _examResultRep;
        public ExamResultManager(ExamResultRepository exRep)
        {
            _examResultRep = exRep;
        }

        public void Add(ExamResult entity)
        {
            if (entity.Student == null || entity.Exam == null)
            {
                throw new Exception("Sınav sonucu için bir öğrenci ve bir sınav seçmeniz gerekmektedir.");
            }

            _examResultRep.Add(entity);
        }

        public void Delete(string id)
        {
            _examResultRep.Delete(id);
        }

        public List<ExamResult> GetAll()
        {
            return _examResultRep.GetAll();
        }

        public ExamResult GetByID(string id)
        {
           return _examResultRep.GetByID(id);
        }

        public void Update(ExamResult entity)
        {
            _examResultRep.Update(entity);
        }
    }
}
