using AmiamStore.App_BLL;
using AmiamStore.App_DAL;
using AmiamStore.App_DAL.Entities;
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
            var model = GetModel(products);
           
            return View(model);
        }

        private ProductsPageModel GetModel(List<Product> products)
        {
            ProductsPageModel model = new ProductsPageModel();
            model.Products = new List<ProductModel>();
            foreach (var product in products)
            {
                model.Products.Add(new ProductModel() { ProductID = product.ProductID, ProductName = product.ProductName, ProductImage = product.ProductImage, ProductPrice = product.ProductPrice });
            }
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