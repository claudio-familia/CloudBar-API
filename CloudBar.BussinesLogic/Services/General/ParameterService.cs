using CloudBar.DataAccess.Repositories.Contracts;
using CloudBar.Domain.General;

namespace CloudBar.BusinessLogic.Services.General
{
    public class ParameterService : BaseService<Parameter>
    {
        private readonly IDataRepositoryFactory _dataRepositoryFactory;
        public ParameterService(IDataRepositoryFactory dataRepositoryFactory, IDataRepository<Parameter> baseRepository) : base(baseRepository)
        {
            _dataRepositoryFactory = dataRepositoryFactory;
        }
    }
}
