using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CloudBar.Domain.General
{
    [Table("Employees")]
    public class Employee : BaseEntity
    {
        public decimal Salary { get; set; }
        public int? PersonId { get; set; }
        public int? PlaceId { get; set; }

        public Person Person { get; set; }
    }
}
