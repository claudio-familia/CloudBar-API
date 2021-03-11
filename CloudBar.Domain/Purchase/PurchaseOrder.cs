using CloudBar.Domain.General;
using CloudBar.Domain.Security;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudBar.Domain.Purchase
{
    public class PurchaseOrder : BaseEntity
    {
        public Guid UserId { get; set; }
        public Guid PlaceId { get; set; }
        public Guid SupplierId { get; set; }
        public string InvoiceNumber { get; set; }
        public string PaymentType { get; set; }
        public decimal Total { get; set; }
        public decimal Pending { get; set; }

        public User User { get; set; }
        public Place Place { get; set; }
        ICollection<PurchaseOrderLine> Lines { get; set; }
    }
}
