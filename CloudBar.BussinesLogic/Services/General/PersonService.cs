using CloudBar.DataAccess.Repositories.Contracts;
using CloudBar.Domain.General;

namespace CloudBar.BusinessLogic.Services.General
{
    public class PersonService : BaseService<Person>
    {
        private readonly IDataRepositoryFactory _dataRepositoryFactory;
        public PersonService(IDataRepositoryFactory dataRepositoryFactory, IDataRepository<Person> baseRepository) : base(baseRepository)
        {
            _dataRepositoryFactory = dataRepositoryFactory;
        }
    }
}
