using CloudBar.BusinessLogic.Services.Contracts;
using CloudBar.DataAccess.Repositories.Contracts;
using CloudBar.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace CloudBar.BusinessLogic.Services
{
    public class BaseService<T> : IBaseService<T> where T : class, IAuditableEntity, new()
    {
        protected readonly IDataRepository<T> repository;

        public BaseService(IDataRepository<T> _repository)
        {
            repository = _repository;
        }

        public virtual T Add(T entity)
        {
            try
            {
                entity.Active = true;

                return repository.Add(entity);
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }
        }

        public virtual bool Exists(int id)
        {
            return repository.Exists(id);
        }

        public virtual bool Exists(Expression<Func<T, bool>> filter = null)
        {
            return repository.Exists(filter);
        }

        public virtual T Get(int id)
        {
            return repository.Get(id);
        }

        public virtual T Get(Guid id)
        {
            return repository.Get(id);
        }

        public virtual TResult Get<TResult>(Func<IQueryable<T>, IQueryable<TResult>> transform, Expression<Func<T, bool>> filter = null, string sortExpression = null)
        {
            return repository.Get(transform, filter, sortExpression);
        }

        public virtual IEnumerable<T> GetAll(string sortExpression = null)
        {
            return repository.GetAll(sortExpression);
        }

        public virtual IEnumerable<T> GetAll(Func<IQueryable<T>, IQueryable<T>> transform, Expression<Func<T, bool>> filter = null, string sortExpression = null)
        {
            return repository.GetAll(transform, filter, sortExpression);
        }

        public virtual T Update(T entity)
        {
            try
            {
                return repository.Update(entity);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
    }
}
