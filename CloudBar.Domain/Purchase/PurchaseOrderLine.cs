using System;
using System.Collections.Generic;
using System.Text;

namespace CloudBar.Domain.Purchase
{
    public class PurchaseOrderLine : BaseEntity
    {
        public Guid PurchaseOrderId { get; set; }
        public Guid ItemId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public PurchaseOrder PurchaseOrder { get; set; }
    }
}
