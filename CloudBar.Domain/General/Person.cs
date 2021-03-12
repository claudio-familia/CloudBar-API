using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudBar.Domain.General
{
    [Table("People")]
    public class Person : BaseEntity
    {
        public string Identification { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Datebirth { get; set; }
        public string Address { get; set; }
        public string District { get; set; }
        public string Province { get; set; }
        public string Nationality { get; set; }
        public string Phone { get; set; }
        public Guid PlaceId { get; set; }

        public Place Place { get; set; }
    }
}
