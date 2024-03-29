﻿using CloudBar.Domain.General;
using System;

namespace CloudBar.Domain.Warehouse
{
    public class Item : BaseEntity
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public string ImgUrl { get; set; }
        public int? PlaceId { get; set; }

        public Category Category { get; set; }
        public Place Place { get; set; }
    }
}
