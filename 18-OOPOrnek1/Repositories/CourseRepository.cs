using _18_OOPOrnek1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOPOrnek1.Repositories
{
    public class CourseRepository : IRepository<Course>
    {
        public static List<Course> CourseList { get; set; } = new();

        public CourseRepository()
        {
            //CourseList.Add(new Course()
            //{
            //    CourseName = "Full Stack .NET CORE",
            //    Educator = null,
            //    EndDate = DateTime.Now,
            //    StartDate = DateTime.Now,
            //    IsActive = true
            //});

            //CourseList.Add(new Course()
            //{
            //    CourseName = "Front End Eğitimi",
            //    Educator = null,
            //    EndDate = DateTime.Now,
            //    StartDate = DateTime.Now,
            //    IsActive = true
            //});
        }
        public void Add(Course entity)
        {
            CourseList.Add(entity);
        }

        public void Delete(string id)
        {
            var course = CourseList.FirstOrDefault(x => x.ID == id);
            CourseList.Remove(course);
        }

        public List<Course> GetAll()
        {
            return CourseList;
        }

        public Course GetByID(string id)
        {
            return CourseList.FirstOrDefault(x => x.ID == id);
        }
        public void Update(Course entity)
        {
            var course = CourseList.FirstOrDefault(x => x.ID == entity.ID);
        }
    }
}
