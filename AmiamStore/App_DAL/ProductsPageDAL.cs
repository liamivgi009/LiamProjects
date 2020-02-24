using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
namespace AmiamStore.App_DAL
{
    public class ProductsPageDAL
    {
        public DataTable getProductByCatagorie(int CatagoryID)
        {
            DBHelper dbh = new DBHelper();
            String sql =
                @"  SELECT        ProductID
                    FROM            ProductCatagories
                    WHERE         CatagoryID= " + CatagoryID;

            DataTable dt = dbh.GetData(sql);
            return dt;
        }
    }
}