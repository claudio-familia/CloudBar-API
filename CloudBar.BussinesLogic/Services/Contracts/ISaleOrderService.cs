using CloudBar.Domain.Sale;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudBar.BusinessLogic.Services.Contracts
{
    public interface ISaleOrderService : IBaseService<Order>
    {
        public string GenerateSaleOrderNumber();
    }
}
