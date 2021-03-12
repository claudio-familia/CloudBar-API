using System.ComponentModel.DataAnnotations.Schema;

namespace CloudBar.Domain.General
{
    public class Place : BaseEntity
    {
        public string Name { get; set; }

        public string Address { get; set; }

        [Column("cityOrDistrict")]
        public string District { get; set; }

        [Column("stateProvince")]
        public string Province { get; set; }

        public string Country { get; set; }

        public string Latitude { get; set; }

        public string Longitude { get; set; }
    }
}
