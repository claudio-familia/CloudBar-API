using CloudBar.Domain.Warehouse;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudBar.Domain.Purchase
{
    public class SupplierItem : BaseEntity
    {
        public int SupplierId { get; set; }
        public int ItemId { get; set; }
        public decimal Price { get; set; }

        public Supplier Supplier { get; set; }
        public Item Item { get; set; }
    }
}
