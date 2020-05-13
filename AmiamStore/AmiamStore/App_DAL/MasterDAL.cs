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


        public DataTable GetProductByName(string ProductNameSerched)
        {
            var query =string.Format(
             @" SELECT      Product.ProductName, Product.ProductID , Product.ProductImage , Product.ProductPrice , Product.ProductDescription
                FROM        Product
                WHERE       Product.ProductName = '{0}'", ProductNameSerched);
            DataTable dt = _dbHelper.GetData(query);
            return dt;
        }
    }
}