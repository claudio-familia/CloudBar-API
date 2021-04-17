using CloudBar.DataAccess.Repositories.Contracts;
using CloudBar.Domain.Sale;

namespace CloudBar.BusinessLogic.Services.Sale
{
    public class ClientService : BaseService<Client>
    {
        private readonly IDataRepositoryFactory _dataRepositoryFactory;
        public ClientService(IDataRepositoryFactory dataRepositoryFactory, IDataRepository<Client> baseRepository) : base(baseRepository)
        {
            _dataRepositoryFactory = dataRepositoryFactory;
        }
    }
}
