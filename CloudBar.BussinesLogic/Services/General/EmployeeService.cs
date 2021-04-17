using CloudBar.DataAccess.Repositories.Contracts;
using CloudBar.Domain.General;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudBar.BusinessLogic.Services.General
{
    public class EmployeeService : BaseService<Employee>
    {
        private readonly IDataRepositoryFactory _dataRepositoryFactory;
        public EmployeeService(IDataRepositoryFactory dataRepositoryFactory, IDataRepository<Employee> baseRepository) : base(baseRepository)
        {
            _dataRepositoryFactory = dataRepositoryFactory;
        }
    }
}
