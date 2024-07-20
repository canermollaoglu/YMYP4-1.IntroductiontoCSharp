using _18_OOPOrnek1.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOPOrnek1.Repositories
{
    public class LessonRepository : IRepository<Lesson>
    {
        private List<Lesson> LessonList { get; set; } = new();

        public void Add(Lesson entity)
        {
            LessonList.Add(entity);
        }

        public void Delete(string id)
        {
            var lesson = LessonList.FirstOrDefault(x => x.ID == id);
            if (lesson != null) {
                LessonList.Remove(lesson);
            }
        }

        public List<Lesson> GetAll()
        {
            return LessonList;
        }

        public Lesson GetByID(string id)
        {
            var lesson = LessonList.FirstOrDefault(x => x.ID == id);
            return lesson;
        }

        public void Update(Lesson entity)
        {
            var lesson = LessonList.FirstOrDefault(x => x.ID == entity.ID);
            lesson.Title= entity.Title;
            lesson.Content= entity.Content;
            lesson.Date=entity.Date;
            lesson.Duration=entity.Duration;
            lesson.Course=entity.Course;
        }
    }
}
