﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmiamStore.Models
{
    public class ProductModel
    {
        public int ProductID { get; set; }
        public string ProductImage { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice{ get; set; }
        public string ProductDescription { get; set; }
        public string ShipperID { get; set; }
        public string CatagoryDescription { get; set; }
        public int CategoryId { get; set; }
        public string CatagoryName { get; set; }
    }
}