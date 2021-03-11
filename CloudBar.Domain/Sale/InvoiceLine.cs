using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudBar.Domain.Sale
{
    [Table("InvoiceLines")]
    public class InvoiceLine : BaseEntity
    {
        public Guid InvoiceId { get; set; }
        public Guid OrderLineId { get; set; }
        public decimal Taxes { get; set; }

        public Invoice Invoice { get; set; }
        public OrderLine Line { get; set; }

    }
}
