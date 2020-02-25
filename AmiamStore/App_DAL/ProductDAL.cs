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
                @"  SELECT        ProductImage, ProductName, ProductPrice, ProductDescription, ProductID, ShipperID
                    FROM            Product
                    WHERE        ProductID = " + id;

            DataTable dt = dbh.GetData(sql);
            return dt;
        }
    }
}