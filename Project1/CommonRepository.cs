using Interfaces.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Data.Entity;

namespace Respositories.CommonRepository
{
    public class CommonRepository<C,T> : Interfaces.Common.ICommonRespository<T> where T : class where C : DbContext, new()
    {

        internal C _entities = new C();
        internal DbSet<T> dbSet;

        public C Context
        {

            get { return _entities; }
            set { _entities = value; }
        }

        public CommonRepository()
        {

            this.dbSet = Context.Set<T>();
        }
        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            T entityToDelete = dbSet.Find(entity);
            Delete(entityToDelete);
        }

        public void Edit(T entity)
        {
            dbSet.Attach(entity);
            Context.Entry(entity).State = EntityState.Modified;
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = Context.Set<T>().Where(predicate);
            return query;
        }

        public ICollection<T> GetAll()
        {
            return dbSet.ToList();
        }

        public T GetSingle(Expression<Func<T, bool>> predicate)
        {
            return dbSet.FirstOrDefault(predicate);
        }

        public void Save()
        {
            Context.SaveChanges();
        }
    }
}
