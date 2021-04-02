using CloudBar.Domain;

namespace CloudBar.DataAccess.Repositories.Contracts
{
    public class Repository<TEntity> : RepositoryBase<TEntity, CloudBarDBContext> where TEntity : class, IAuditableEntity, new()
    {
        public Repository(CloudBarDBContext context) : base(context) { }
    }
}
