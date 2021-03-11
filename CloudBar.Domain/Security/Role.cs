using System.ComponentModel.DataAnnotations.Schema;

namespace CloudBar.Domain.Security
{
    [Table("Roles")]
    public class Role : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
