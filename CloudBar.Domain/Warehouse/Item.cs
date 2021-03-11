using System;

namespace CloudBar.Domain.Warehouse
{
    public class Item : BaseEntity
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }

        public Category Category { get; set; }
    }
}
