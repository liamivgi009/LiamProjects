using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using AmiamStore.App_DAL;
using AmiamStore.App_DAL.Entities;

namespace AmiamStore.App_BLL
{
    public class ProductsPageBLL
    {
        public List<Product> GetProductsByCata(int catagoryID)
        {
            ProductsPageDAL dal = new ProductsPageDAL();
            DataTable dt = dal.getProductByCatagorie(catagoryID);

            // converting from a DataTable to a Product Object!

            List<Product> products = new List<Product>();
            foreach (DataRow dr in dt.Rows)
            {
                Product product = new Product();
                product.ProductID = (int)dr["ProductID"];
                product.ProductName = dr["ProductName"].ToString();
                product.ProductImage = dr["ProductImage"].ToString();
                product.ProductPrice = dr["ProductPrice"].ToString();
                product.ShipperID = dr["ShipperID"].ToString();
                product.ProductDescription = dr["ProductDescription"].ToString();
                products.Add(product);
            }
            return products;
        }

        //public IEnumerable<Product> getProductsByCata(int catagoryID)
        //{
        //    ProductsPageDAL dal = new ProductsPageDAL();
        //    DataTable dt = dal.getProductByCatagorie(catagoryID);

        //    converting from a DataTable to a Product Object!

        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        Product product = new Product();
        //        product.ProductID = (int)dr["ProductID"];
        //        product.ProductName = dr["ProductName"].ToString();
        //        product.ProductImage = dr["ProductImage"].ToString();
        //        product.ProductPrice = dr["ProductPrice"].ToString();
        //        product.ShipperID = dr["ShipperID"].ToString();
        //        product.ProductDescription = dr["ProductDescription"].ToString();
        //        yield return product;
        //    }
        //}
    }
}