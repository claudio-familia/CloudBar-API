using CloudBar.DataAccess.Repositories.Contracts;
using CloudBar.Domain.Warehouse;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudBar.BusinessLogic.Services.Warehouse
{
    public class CategoryService : BaseService<Category>
    {
        private readonly IDataRepositoryFactory _dataRepositoryFactory;
        public CategoryService(IDataRepositoryFactory dataRepositoryFactory, IDataRepository<Category> baseRepository) : base(baseRepository)
        {
            _dataRepositoryFactory = dataRepositoryFactory;
        }
    }
}
