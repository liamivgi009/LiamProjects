using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace AmiamStore.App_DAL
{
    public class ProductDAL
    {
        public DataTable getProduct(int id)
        {
            DBHelper dbh = new DBHelper();
            String sql =
          @"SELECT     Product.ProductID, Product.ProductDescription, Product.ProductName, Product.ProductImage, Product.ProductPrice, Catagories.CatagoryName, ProductCatagories.CatagoryID
            FROM       Product INNER JOIN (Catagories INNER JOIN ProductCatagories ON Catagories.CatagoryID = ProductCatagories.CatagoryID) ON Product.ProductID = ProductCatagories.ProductID
            WHERE     (((Product.[ProductID])=" + id + "));"; 
           
            DataTable dt = dbh.GetData(sql);
            return dt;
        }
    }
}