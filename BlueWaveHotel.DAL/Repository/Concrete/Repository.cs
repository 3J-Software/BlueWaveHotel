using BlueWaveHotel.DAL.Repository.Abstract;
using BlueWaveHotel.Entities.DbContexts;
using BlueWaveHotel.Entities.Model.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BlueWaveHotel.DAL.Repository.Concrete
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {


        readonly mySqlContext _mySqlContext;
        readonly DbSet<T> _dbSet;
        public int Delete(T input)
        {
            _dbSet.Remove(input);
            return _mySqlContext.SaveChanges();
        }

        public int DeleteById(T id)
        {
            _dbSet.Remove(id);
            return _mySqlContext.SaveChanges();
        }

        public T? Get(Expression<Func<T, bool>> predicate)
        {

            return _dbSet.Where(predicate).FirstOrDefault();

        }

        public List<T>? GetAll(Expression<Func<T, bool>> predicate = null)
        {
            if (predicate != null)
                return _mySqlContext.Set<T>().Where(predicate).ToList();
            else
                return _mySqlContext.Set<T>().ToList();
        }

        public IQueryable<T> GetAllInclude(Expression<Func<T, bool>>? predicate, params Expression<Func<T, object>>[] include)
        {
            IQueryable<T> query;
            if (predicate != null)
            {
                query = _mySqlContext.Set<T>().Where(predicate);
            }
            else
            {
                query = _mySqlContext.Set<T>();
            }

            return include.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
        }

        public T? GetById(string id)
        {
            return _dbSet.Find(id);
        }

        public int Insert(T input)
        {
            _dbSet.Add(input);
            return _mySqlContext.SaveChanges();
        }

        public int Update(T input)
        {
            _dbSet.Update(input);
            return _mySqlContext.SaveChanges();
        }


    }
}
