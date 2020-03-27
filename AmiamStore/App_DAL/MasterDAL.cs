using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace AmiamStore.App_DAL
{
    public class MasterDAL
    {
        private readonly DBHelper _dbHelper = new DBHelper();


        public DataTable GetProductByName(string ProductName)
        {
            string sql =
             @" SELECT      Product.ProductName, Product.ProductID
                FROM        Product
                WHERE       Product.ProductName =" + ProductName;
            DataTable dt = _dbHelper.GetData(sql);
            return dt;
        }
    }
}