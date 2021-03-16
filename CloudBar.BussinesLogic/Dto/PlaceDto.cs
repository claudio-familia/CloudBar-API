using System;
using System.Collections.Generic;
using System.Text;

namespace CloudBar.BusinessLogic.Dto
{
    public class PlaceDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsPercent { get; set; }
        public decimal Value { get; set; }
    }
}
