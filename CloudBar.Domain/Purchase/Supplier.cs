using System.ComponentModel.DataAnnotations.Schema;

namespace CloudBar.Domain.Purchase
{
    [Table("Suppliers")]
    public class Supplier : BaseEntity
    {
        public string Identification { get; set; }
        public string Name { get; set; }
        public bool IsJuridic { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int? PlaceId { get; set; }
    }
}
