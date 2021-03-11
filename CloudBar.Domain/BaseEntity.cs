using System;
using System.ComponentModel.DataAnnotations;

namespace CloudBar.Domain
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
