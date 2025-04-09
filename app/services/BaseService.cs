using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace metricsflow.app.services
{
    internal class BaseService<T, TContext>
        where T : class
        where TContext : DbContext, new()
    {
        protected readonly TContext _context;

        public BaseService()
        {
            _context = new TContext();
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T? GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _context.Set<T>().Find(id);
            if (entity != null)
            {
                _context.Set<T>().Remove(entity);
                _context.SaveChanges();
            }
        }
    }
}