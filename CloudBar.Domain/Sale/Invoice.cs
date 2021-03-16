using CloudBar.Domain.General;
using CloudBar.Domain.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudBar.Domain.Sale
{
    [Table("Invoices")]
    public class Invoice : BaseEntity
    {
        public int UserId { get; set; }
        public int OrderId { get; set; }
        public decimal LawTip { get; set; }
        public decimal Taxes { get; set; }
        public decimal Total { get; set; }
        public DateTime Date { get; set; }
        public string NCF { get; set; }
        public DateTime? NCFDueDate { get; set; }

        public User User { get; set; }
        public Place Place { get; set; }
        public ICollection<InvoiceLine> Lines { get; set; }
    }
}
