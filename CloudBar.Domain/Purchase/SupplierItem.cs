using CloudBar.Domain.Warehouse;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudBar.Domain.Purchase
{
    public class SupplierItem : BaseEntity
    {
        public Guid SupplierId { get; set; }
        public Guid ItemId { get; set; }
        public decimal Price { get; set; }

        public Supplier Supplir { get; set; }
        public Item Item { get; set; }
    }
}
