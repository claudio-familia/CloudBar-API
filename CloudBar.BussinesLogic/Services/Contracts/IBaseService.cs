using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace CloudBar.BusinessLogic.Services.Contracts
{
    public interface IBaseService<T>
    {
        T Add(T entity);
        T Update(T entity);        
        IEnumerable<T> GetAll(string sortExpression = null);
        IEnumerable<T> GetAll(Func<IQueryable<T>, IQueryable<T>> transform, Expression<Func<T, bool>> filter = null, string sortExpression = null);
        T Get(long id);
        T Get(Guid id);
        TResult Get<TResult>(Func<IQueryable<T>, IQueryable<TResult>> transform, Expression<Func<T, bool>> filter = null, string sortExpression = null);
        bool Exists(long id);
        bool Exists(Func<IQueryable<T>, IQueryable<T>> query, Expression<Func<T, bool>> filter = null);
    }
}
