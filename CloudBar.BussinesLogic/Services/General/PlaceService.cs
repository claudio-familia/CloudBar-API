using CloudBar.DataAccess.Repositories.Contracts;
using CloudBar.Domain.General;

namespace CloudBar.BusinessLogic.Services.General
{
    public class PlaceService : BaseService<Place>
    {
        private readonly IDataRepositoryFactory _dataRepositoryFactory;
        public PlaceService(IDataRepositoryFactory dataRepositoryFactory, IDataRepository<Place> baseRepository) : base(baseRepository)
        {
            _dataRepositoryFactory = dataRepositoryFactory;
        }
    }
}
