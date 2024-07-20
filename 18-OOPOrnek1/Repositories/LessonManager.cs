using _18_OOPOrnek1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOPOrnek1.Repositories
{
    public class LessonManager : IRepository<Lesson>
    {
        LessonRepository _lessonRepository;
        public LessonManager(LessonRepository lRepo)
        {
            _lessonRepository = lRepo;
        }
        public void Add(Lesson entity)
        {
            if (entity.Course == null)
            {
                throw new Exception("Eklenen dersin en az bir kursu olmalıdır.");
            }

            _lessonRepository.Add(entity);
        }

        public void Delete(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new Exception("ID bilgisi boş olamaz.");
            }

            _lessonRepository.Delete(id);
        }

        public List<Lesson> GetAll()
        {
            return _lessonRepository.GetAll();
        }

        public Lesson GetByID(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new Exception("ID bilgisi boş olamaz.");
            }

            return _lessonRepository.GetByID(id);
        }

        public void Update(Lesson entity)
        {
            _lessonRepository.Update(entity);
        }
    }
}
