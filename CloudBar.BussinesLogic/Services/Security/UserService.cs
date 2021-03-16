using CloudBar.DataAccess.Repositories.Contracts;
using CloudBar.Domain.Security;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudBar.BusinessLogic.Services.Security
{
    public class UserService : BaseService<User>
    {
        private readonly IDataRepositoryFactory _dataRepositoryFactory;
        public UserService(IDataRepositoryFactory dataRepositoryFactory, IDataRepository<User> baseRepository) : base(baseRepository)
        {
            _dataRepositoryFactory = dataRepositoryFactory;
        }
    }
}
