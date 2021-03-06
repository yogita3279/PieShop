﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Model
{
    public class Pie
    {

        public int PieId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string LongDescription { get; set; }
        public string ShortDescription { get; set; }
        public string AllergyInformation { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ThumbnailUrl { get; set; }
        public bool IsPieOftheWeek { get; set; }
        public bool InStock { get; set; }
        public Category Category { get; set; }

    }
}
