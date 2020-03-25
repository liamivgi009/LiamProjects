using AmiamStore.Controllers.BaseControllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmiamStore.Models;
using AmiamStore.App_DAL;
using AmiamStore.App_BLL;

namespace AmiamStore.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController() : base(false) { }
        private ProductsPageBLL _productsService = new ProductsPageBLL();

        public ActionResult Index()
        {
            ProductsPageModel model = new ProductsPageModel();
            List<ProductModel> products = _productsService.GetProductsList().Products;
            int[] arr = _productsService.MostPopularProducts();
            List<ProductModel> productsPopular = new List<ProductModel>();
            for (int i = 0; i < arr.Length;i++)
            {
                ProductModel c = products.Find(product => product.ProductID == arr[i]);
                productsPopular.Add(c);
            }
            model.Products = productsPopular;
            return View(model);
        }

    }
}