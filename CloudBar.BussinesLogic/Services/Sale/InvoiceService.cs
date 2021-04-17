using CloudBar.DataAccess.Repositories.Contracts;
using CloudBar.Domain.Sale;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudBar.BusinessLogic.Services.Sale
{
    public class InvoiceService : BaseService<Invoice>
    {
        private readonly IDataRepositoryFactory _dataRepositoryFactory;
        public InvoiceService(IDataRepositoryFactory dataRepositoryFactory, IDataRepository<Invoice> baseRepository) : base(baseRepository)
        {
            _dataRepositoryFactory = dataRepositoryFactory;
        }
    }
}
