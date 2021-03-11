using CloudBar.Domain.Warehouse;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudBar.Domain.Sale
{
    [Table("OrderLines")]
    public class OrderLine : BaseEntity
    {
        public Guid OrderId { get; set; }
        public Guid ItemId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Order Order { get; set; }
        public Item Item { get; set; }
    }
}
