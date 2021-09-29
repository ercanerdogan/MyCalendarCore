using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MyCalendar.Business.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> expression);
        void Add(TEntity entity);
        void Delete(TEntity entity);
            

    }
}
