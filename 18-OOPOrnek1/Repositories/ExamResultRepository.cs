using _18_OOPOrnek1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOPOrnek1.Repositories
{
    public class ExamResultRepository : IRepository<ExamResult>
    {
        private List<ExamResult> ExamResultList { get; set; } = new();

        public void Add(ExamResult entity)
        {
            ExamResultList.Add(entity);
        }

        public void Delete(string id)
        {
            var s = ExamResultList.FirstOrDefault(x => x.ID == id);
            if (s != null)
            {
                ExamResultList.Remove(s);
            }
        }

        public List<ExamResult> GetAll()
        {
            return ExamResultList;
        }

        public ExamResult GetByID(string id)
        {
            var s = ExamResultList.FirstOrDefault(x => x.ID == id);
            return s;
        }

        public void Update(ExamResult entity)
        {
            var s = ExamResultList.FirstOrDefault(x => x.ID == entity.ID);
            s.Grade= entity.Grade;
            s.Student= entity.Student;
            s.Exam= entity.Exam;
        }
    }
}
