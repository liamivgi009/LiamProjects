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
        private readonly DBHelper _dbHelper = new DBHelper();

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
                product.ProductPrice = (int)dr["ProductPrice"];
                product.ShipperID = dr["ShipperID"].ToString();
                product.ProductDescription = dr["ProductDescription"].ToString();
                product.CategoryId = catagoryID;
                products.Add(product);
                product.CatagoryDescription = dr["CatagoryDescription"].ToString();
                CDescription = product.CatagoryDescription;

            }
            d.Products = products;
            d.CatagoryDescription = CDescription;
            return d;
        }
        public ProductsPageModel GetProductsList()
        {
            ProductsPageDAL dal = new ProductsPageDAL();
            DataTable dt = dal.getProducts();

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
                product.ProductPrice = (int)dr["ProductPrice"];
                product.ShipperID = dr["ShipperID"].ToString();
                product.ProductDescription = dr["ProductDescription"].ToString();
                products.Add(product);
            }
            d.Products = products;
            return d;
        }
        public int[] GetPopularProducts()
        {
            string sql =
             @" SELECT ProductID
                   FROM  Orders";
            DataTable dt = _dbHelper.GetData(sql);
            int[] MostPopular = new int[3];
            int i = 0;
           foreach(DataRow dr in dt.Rows)
            {
                   
            }

            return MostPopular;
        }
    }
}