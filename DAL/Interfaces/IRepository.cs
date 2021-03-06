using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity GetById(int id);
        IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filtter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includePrioperties = "");
        void Update(TEntity entityToUpdate);
        void Insert(TEntity entity);
        void Delete(TEntity entityToDelete);
        void Delete(int id);
    }
}
