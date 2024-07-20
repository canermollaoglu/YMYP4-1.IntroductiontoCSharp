using _21_EFOnlineCourseDB.Context;
using _21_EFOnlineCourseDB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_EFOnlineCourseDB.Repositories
{
    public class InstructorRepository : GenericRepository<Instructor>
    {
        public InstructorRepository(ApplicationDbContext context) : base(context)
        {

        }


    }
}
