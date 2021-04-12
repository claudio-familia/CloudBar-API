using CloudBar.Domain.General;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CloudBar.Domain.Sale
{
    [Table("Clients")]
    public class Client : BaseEntity
    {
        public int? PersonId { get; set; }
        public int? PlaceId { get; set; }

        public Person Person { get; set; }
    }
}
