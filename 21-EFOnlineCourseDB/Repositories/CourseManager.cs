using _21_EFOnlineCourseDB.Entities;
using _21_EFOnlineCourseDB.Validator;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_EFOnlineCourseDB.Repositories
{
    public class CourseManager : IManager<Course>
    {
        private CourseRepository _courseRepository;
        public CourseManager(CourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public void Create(Course entity)
        {
            CourseValidator cVal = new();
            ValidationResult result = cVal.Validate(entity);

            if (!result.IsValid)
            {
                throw new Exception(string.Join(",", result.Errors));
            }
            _courseRepository.Create(entity);
        }

        public void DeleteByID(Guid id)
        {
            _courseRepository.DeleteByID(id);
        }

        public List<Course> GetAll()
        {
            return _courseRepository.GetAll();
        }

        public Course GetByID(Guid id)
        {
            return _courseRepository.GetByID(id);
        }

        public void Update(Course entity)
        {
            _courseRepository.Update(entity);
        }
    }
}
