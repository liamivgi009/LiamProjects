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
                @"  SELECT        p.ProductName, p.ProductImage, p.ProductPrice, p.ProductDescription, p.ShipperID, p.ProductID
                     FROM            (ProductCatagories pc INNER JOIN
                     Product p ON p.ProductID = pc.ProductID)
                     WHERE        pc.CatagoryID = " + catagoryID;

            DataTable dt = dbh.GetData(sql);
            return dt;
        }
    }
}