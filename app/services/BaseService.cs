using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        public List<T> Where(string propertyName, object value)
        {
            var parameter = Expression.Parameter(typeof(T), "x");

            var property = Expression.Property(parameter, propertyName);

            var propertyType = property.Type;

            var constant = Expression.Constant(Convert.ChangeType(value, propertyType), propertyType);

            var equality = Expression.Equal(property, constant);

            var lambda = Expression.Lambda<Func<T, bool>>(equality, parameter);

            return _context.Set<T>().Where(lambda).ToList();
        }
    }
}