using CloudBar.Domain.General;
using CloudBar.Domain.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudBar.Domain.Sale
{
    [Table("Orders")]
    public class Order : BaseEntity
    {
        public Guid UserId { get; set; }
        public Guid PlaceId { get; set; }
        public string Number { get; set; }
        public string Type { get; set; }
        public decimal Total { get; set; }
        public int Rating { get; set; }

        public User User { get; set; }
        public Place Place { get; set; }
        public ICollection<OrderLine> Lines { get; set; }
    }
}
