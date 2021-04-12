using CloudBar.BusinessLogic.Services.Contracts;
using CloudBar.DataAccess.Repositories.Contracts;
using CloudBar.Domain.Sale;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloudBar.BusinessLogic.Services.Sale
{
    public class SaleOrderService : BaseService<Order>, ISaleOrderService
    {
        private readonly IDataRepositoryFactory _dataRepositoryFactory;
        private readonly IDataRepository<Order> _baseRepository;
        public SaleOrderService(IDataRepositoryFactory dataRepositoryFactory, 
                                IDataRepository<Order> baseRepository) : base(baseRepository)
        {
            _dataRepositoryFactory = dataRepositoryFactory;
            _baseRepository = baseRepository;
        }

        public string GenerateSaleOrderNumber()
        {
            var lastOrder = _baseRepository.GetAll().OrderByDescending(or => or.Id).FirstOrDefault();

            if (lastOrder == null) return "0000001";

            int countDigit = int.Parse(lastOrder.Number).ToString().Length;

            int lastDigit = int.Parse(lastOrder.Number) + 1;

            return new string('0', 7 - countDigit) + lastDigit.ToString();
        }
    }
}
