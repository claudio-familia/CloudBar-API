using CloudBar.DataAccess.Repositories.Contracts;
using CloudBar.Domain.Warehouse;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudBar.BusinessLogic.Services.Warehouse
{
    public class ItemService : BaseService<Item>
    {
        private readonly IDataRepositoryFactory _dataRepositoryFactory;
        public ItemService(IDataRepositoryFactory dataRepositoryFactory, IDataRepository<Item> baseRepository) : base(baseRepository)
        {
            _dataRepositoryFactory = dataRepositoryFactory;
        }
    }
}
