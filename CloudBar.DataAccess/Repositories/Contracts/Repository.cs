namespace CloudBar.DataAccess.Repositories.Contracts
{
    public class Repository<TEntity> : RepositoryBase<TEntity, CloudBarDBContext> where TEntity : class, new()
    {
        public Repository(CloudBarDBContext context) : base(context) { }
    }
}
