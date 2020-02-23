using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmiamStore.Models
{
    public class Product
    {
        public string ProductImage { get; set; }
        public string ProductName { get; set; }
        public string ProductPrice{ get; set; }
        public string ProductDescription { get; set; }
        public string ProductID { get; set; }
        public string ShipperID { get; set; }
    }
}