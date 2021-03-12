using Microsoft.EntityFrameworkCore.Storage;
using CloudBar.DataAccess.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudBar.DataAccess.Repositories
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly CloudBarDBContext _DataContext;

        public UnitOfWork(CloudBarDBContext dataContext)
        {
            _DataContext = dataContext;
        }

        public IDbContextTransaction CreateTransaction()
        {
            return this._DataContext.Database.BeginTransaction();
        }

        public int SaveChanges()
        {
            return _DataContext.SaveChanges();
        }

        public void Dispose()
        {
            if (_DataContext != null)
            {
                _DataContext.Dispose();
            }
        }
    }
}
