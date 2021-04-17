using CloudBar.Domain.Security;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudBar.Domain
{
    public class BaseEntity : IAuditableEntity
    {
        [Key]
        public int Id { get; set; }
        public bool? Active { get; set; }

        [ForeignKey(nameof(Creator))]
        public int? CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public int? UpdatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }

        [ForeignKey(nameof(CreatedBy))]
        public User Creator { get; set; }
    }
}
