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
        [Column("cityOrDistrict")]
        public string District { get; set; }
        [Column("stateOrProvince")]
        public string Province { get; set; }
        [Column("country")]
        public string Nationality { get; set; }
        public string Phone { get; set; }
        public int? PlaceId { get; set; }

        public Place Place { get; set; }
    }
}
