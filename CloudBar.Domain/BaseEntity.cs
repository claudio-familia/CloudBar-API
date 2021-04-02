using System;
using System.ComponentModel.DataAnnotations;

namespace CloudBar.Domain
{
    public class BaseEntity : IAuditableEntity
    {
        [Key]
        public int Id { get; set; }
        public bool? Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
