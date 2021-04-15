using CloudBar.Domain.Sale;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudBar.BusinessLogic.Services.Contracts
{
    public interface ISaleOrderService : IBaseService<Order>
    {
        public string GenerateSaleOrderNumber();
        public string GenerateInvoiceNumber();
        public OrderLine CreateLine(OrderLine line);
        public OrderLine UpdateLine(OrderLine line);
        public Invoice CreateInvoice(Invoice invoice);
    }
}
