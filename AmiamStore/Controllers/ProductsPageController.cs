using AmiamStore.App_BLL;
using AmiamStore.App_DAL;
using AmiamStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AmiamStore.Controllers
{
    public class ProductsPageController : Controller
    {
        private ProductsPageBLL _productsService = new ProductsPageBLL();
        // GET: SpacifitProduct
        public ActionResult ProductsPage(int id)
        {
            var products = _productsService.GetProductsByCata(id);
            ProductsPageModel model = GetModel(products.Products);
            return View(model);
        }

        private ProductsPageModel GetModel(List<ProductModel> products)
        {
            ProductsPageModel model = new ProductsPageModel();
            string CDescrip = "";
            model.Products = new List<ProductModel>();
            foreach (var product in products)
            {
                CDescrip = product.CatagoryDescription;
                model.Products.Add(new ProductModel() { ProductID = product.ProductID, ProductName = product.ProductName, ProductImage = product.ProductImage, ProductPrice = product.ProductPrice , CatagoryDescription = product.CatagoryDescription});
            }
            model.CatagoryDescription = CDescrip;
            return model;
        }

        //Option 2
        //private ProductsPageModel GetModel(List<Product> products)
        //{
        //    ProductsPageModel model = new ProductsPageModel();
        //    model.Products = products.Select(p => new ProductModel() { ProductName = p.ProductName, ProductImage = p.ProductImage, ProductPrice = p.ProductPrice }).ToList();
        //    return model;

        //}
    }
}