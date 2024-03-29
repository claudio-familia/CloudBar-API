﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CloudBar.Domain.General
{
    [Table("Parameters")]
    public class Parameter : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsPercent { get; set; }
        public decimal Value { get; set; }
        public int? PlaceId { get; set; }
    }
}
