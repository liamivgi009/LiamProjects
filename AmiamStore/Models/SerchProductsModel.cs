using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmiamStore.Models
{
    public class SerchProductsModel
    {
        public List<ProductModel> ProductsSerched { get; set; }
        public string SerchedProductName { get; set; }

    }
}