﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CloudBar.Domain
{
    public interface IAuditableEntity
    {
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
