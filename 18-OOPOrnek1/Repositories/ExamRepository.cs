using _18_OOPOrnek1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOPOrnek1.Repositories
{
    public class ExamRepository : IRepository<Exam>
    {
        private static List<Exam> ExamList { get; set; } = new();
        public void Add(Exam entity)
        {
            ExamList.Add(entity);
        }

        public void Delete(string id)
        {
            ExamList.Remove(ExamList.FirstOrDefault(x => x.ID == id));
        }

        public List<Exam> GetAll()
        {
            return ExamList;
        }

        public Exam GetByID(string id)
        {
            return ExamList.FirstOrDefault(x => x.ID == id);
        }

        public void Update(Exam entity)
        {
            var existingExam = ExamList.FirstOrDefault(x => x.ID == entity.ID);

            if (existingExam != null)
            {
                existingExam.Name = entity.Name;
                existingExam.Date = entity.Date;
            }
        }

        public bool GetByExamNameandDate(Exam entity)
        {
            var exam = ExamList.FirstOrDefault(x => x.Name.ToLower() == entity.Name.ToLower() && x.Date == entity.Date);

            return exam == null ? false : true;
        }
    }
}
