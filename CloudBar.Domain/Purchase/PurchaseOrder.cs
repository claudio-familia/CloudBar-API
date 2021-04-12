using CloudBar.Domain.General;
using CloudBar.Domain.Security;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudBar.Domain.Purchase
{
    public class PurchaseOrder : BaseEntity
    {        
        public int? PlaceId { get; set; }
        public int? SupplierId { get; set; }
        public string InvoiceNumber { get; set; }
        public string PaymentType { get; set; }
        public decimal Total { get; set; }
        public decimal Pending { get; set; }
        
        public Place Place { get; set; }
        public Supplier Supplier { get; set; }
        public ICollection<PurchaseOrderLine> Lines { get; set; }
    }
}
