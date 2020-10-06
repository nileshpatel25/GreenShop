﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiGreenShop.Models
{
    public class categorywithproduct
    {
        public string Id { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public string subcategoryid { get; set; }
        public string subsubcategoryid { get; set; }
        public string image { get; set; }
        public bool deleted { get; set; }
        public double orderno { get; set; }

        public ICollection<Product> products { get; set; }
        public ICollection<UnitQuantityFactor> unitQuantityFactors { get; set; }

    }
}