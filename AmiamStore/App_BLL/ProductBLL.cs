using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using AmiamStore.Models;
using AmiamStore.App_BLL;
using AmiamStore.App_DAL;

namespace AmiamStore.App_BLL
{
    public class ProductBLL
    {
        public Product getProduct(String id)
        {
           ProductDAL dal = new ProductDAL();
           DataTable dt = dal.getProduct(id);

            // converting from a DataTable to a Product Object!
            Product prod = new Product();
            foreach (DataRow dr in dt.Rows)
            {
                prod.ProductID = id;
                prod.ProductName = dr["ProductName"].ToString();
                prod.ProductImage = dr["ProductImage"].ToString();
                prod.ShipperID = dr["ShipperID"].ToString();
                prod.ProductPrice = dr["ProductPrice"].ToString();
                prod.ProductDescription = dr["ProductDescription"].ToString();
            }
            return prod;
        }
    }
}