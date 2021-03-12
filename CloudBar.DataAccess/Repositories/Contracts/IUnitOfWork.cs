using Microsoft.EntityFrameworkCore.Storage;

namespace CloudBar.DataAccess.Repositories.Contracts
{
    public interface IUnitOfWork
    {
        IDbContextTransaction CreateTransaction();
        int SaveChanges();
    }
}
