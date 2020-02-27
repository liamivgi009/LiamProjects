using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
namespace AmiamStore.App_DAL
{
    public class ProductsPageDAL
    {
        public DataTable getProductByCatagorie(int catagoryID)
        {
            DBHelper dbh = new DBHelper();
            String sql =
               @"  SELECT        p.ProductName, p.ProductImage, p.ProductPrice, p.ProductDescription, p.ShipperID, p.ProductID ,h.CatagoryDescription
                     FROM            ((ProductCatagories pc INNER JOIN
                     Product p ON p.ProductID = pc.ProductID)
                     INNER JOIN  Catagories h
                      on pc.CatagoryID = h.CatagoryID)
                     WHERE        pc.CatagoryID =" + catagoryID;
            DataTable dt = dbh.GetData(sql);
            return dt;
        }
    }
}