﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_EFOnlineCourseDB.Repositories
{
    public interface IManager<T>
    {
        void Create(T entity);
        void Update(T entity);
        void DeleteByID(Guid id);
        List<T> GetAll();
        T GetByID(Guid id);
    }
}
