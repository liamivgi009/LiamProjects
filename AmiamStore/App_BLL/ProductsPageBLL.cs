using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using AmiamStore.Models;
using AmiamStore.App_DAL;
namespace AmiamStore.App_BLL
{
    public class ProductsPageBLL
    {
        public ProductsPage getProduct(String CatagoryID)
        {
            ProductsPageDAL dal = new ProductsPageDAL();
            DataTable dt = dal.getProductByCatagorie("1");

            // converting from a DataTable to a Product Object!
            ProductsPage prodByCatagory = new ProductsPage();
            foreach (DataRow dr in dt.Rows)
            {
                prodByCatagory.ProductName = dr["ProductName"].ToString();
                prodByCatagory.ProductImage = dr["ProductImage"].ToString();
                prodByCatagory.ProductPrice = dr["ProductPrice"].ToString();
            }
            return prodByCatagory;
        }
    }
}