using _21_EFOnlineCourseDB.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_EFOnlineCourseDB.Validator
{
    public class CourseValidator : AbstractValidator<Course>
    {
        public CourseValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty()
                .WithMessage("Kurs adı alanı boş geçilemez.")
                .Length(10, 100)
                .WithMessage("Kurs adı 10 karakter ile 100 karakter arasında olmalıdır.");

            RuleFor(c => c.StartDate)
                .NotEmpty()
                .WithMessage("Kurs başlangıç tarihi boş geçilemez.");

            RuleFor(c => c.EndDate)
               .NotEmpty()
               .WithMessage("Kurs bitiş tarihi boş geçilemez.")
               .GreaterThan(c => c.StartDate)
               //.GreaterThan(DateOnly.FromDateTime(DateTime.Now).AddMonths(3))
               .WithMessage("Kurs bitiş tarihi başlangıç tarihinden büyük olmalıdır.");

            RuleFor(c => c.Lessons)
                .NotEmpty()
               .WithMessage("Kursun en az 1 dersi olmalıdır");



        }
    }
}
