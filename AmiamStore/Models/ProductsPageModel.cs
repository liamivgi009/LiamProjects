using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmiamStore.Models
{
    public class ProductsPageModel
    {
        public List<ProductModel> Products { get; set; }
        public string CatagoryDescription { get; set; }
    }
}