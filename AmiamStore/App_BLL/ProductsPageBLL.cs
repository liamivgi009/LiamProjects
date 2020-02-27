using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using AmiamStore.App_DAL;
using AmiamStore.Models;

namespace AmiamStore.App_BLL
{
    public class ProductsPageBLL
    {
        public ProductsPageModel GetProductsByCata(int catagoryID)
        {
            ProductsPageDAL dal = new ProductsPageDAL();
            DataTable dt = dal.getProductByCatagorie(catagoryID);

            // converting from a DataTable to a Product Object!
            ProductsPageModel d = new ProductsPageModel();
            string CDescription = "";
            List<ProductModel> products = new List<ProductModel>();
            foreach (DataRow dr in dt.Rows)
            {
                ProductModel product = new ProductModel();
                product.ProductID = (int)dr["ProductID"];
                product.ProductName = dr["ProductName"].ToString();
                product.ProductImage = dr["ProductImage"].ToString();
                product.ProductPrice = dr["ProductPrice"].ToString();
                product.ShipperID = dr["ShipperID"].ToString();
                product.ProductDescription = dr["ProductDescription"].ToString();
                products.Add(product);
                product.CatagoryDescription = dr["CatagoryDescription"].ToString();
                CDescription = product.CatagoryDescription;
            }
            d.Products = products;
            d.CatagoryDescription = CDescription;
            return d;
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