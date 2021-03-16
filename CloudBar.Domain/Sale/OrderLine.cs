using CloudBar.Domain.Warehouse;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudBar.Domain.Sale
{
    [Table("OrderLines")]
    public class OrderLine : BaseEntity
    {
        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Order Order { get; set; }
        public Item Item { get; set; }
    }
}
