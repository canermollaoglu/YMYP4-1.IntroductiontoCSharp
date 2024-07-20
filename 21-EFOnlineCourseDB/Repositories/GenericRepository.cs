using _21_EFOnlineCourseDB.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_EFOnlineCourseDB.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private ApplicationDbContext _context;
        private DbSet<T> _dbSet;
        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public void Create(T entity)
        {
            //_context.Set<T>().Add(entity);
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void DeleteByID(Guid id)
        {
            _dbSet.Remove(GetByID(id));
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetByID(Guid id)
        {
            var find = _dbSet.Find(id);
            if (find != null)
            {
                return find;
            }
            else
            {
                throw new Exception("Bulunamadı.");
            }
        }

        public void Update(T entity)
        {
            _context.SaveChanges();
        }
    }
}
