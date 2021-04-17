using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CloudBar.Domain.General
{
    [Table("OrderStatus")]
    public class OrderStatus : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
