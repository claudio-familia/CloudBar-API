using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudBar.Domain.Sale
{
    [Table("InvoiceLines")]
    public class InvoiceLine : BaseEntity
    {
        public int InvoiceId { get; set; }
        public int OrderLineId { get; set; }
        public decimal Taxes { get; set; }

        public Invoice Invoice { get; set; }
        public OrderLine Line { get; set; }

    }
}
