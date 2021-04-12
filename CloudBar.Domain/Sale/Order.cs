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
        public int? EmployeeId { get; set; }
        public int? ClientId { get; set; }
        public int? StatusId { get; set; }
        public int? PlaceId { get; set; }
        public string Number { get; set; }
        public string Type { get; set; }
        public decimal Total { get; set; }
        public int Rating { get; set; }

        public Employee Employee { get; set; }
        public Client Client { get; set; }
        public OrderStatus Status { get; set; }
        public Place Place { get; set; }
        public ICollection<OrderLine> Lines { get; set; }
    }
}
