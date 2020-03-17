using AmiamStore.App_BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmiamStore.Models
{
    public class CartModel
    {
        public ProductModel product { get; set; }
        public int? Quantity { get; set; }

        public CartModel(ProductModel p , int q)
        {
            this.product = p;
            this.Quantity = q;
        }
    }

    public class CartViewModel
    {
        public string CreditCardNumber { get; set; }
        public string Cvv { get; set; }
        public string IdNumber { get; set; }
        public double OrderAmount { get; set; }
        //public int UserID { get; set; }

        public List<CartModel> Products { get; set; }

    }
}