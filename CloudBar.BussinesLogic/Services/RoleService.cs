using CloudBar.DataAccess.Repositories.Contracts;
using CloudBar.Domain.Security;

namespace CloudBar.BusinessLogic.Services
{
    public class RoleService : BaseService<Role>
    {
        private readonly IDataRepositoryFactory _dataRepositoryFactory;
        public RoleService(IDataRepositoryFactory dataRepositoryFactory, IDataRepository<Role> baseRepository) : base(baseRepository)
        {
            _dataRepositoryFactory = dataRepositoryFactory;
        }
    }
}
