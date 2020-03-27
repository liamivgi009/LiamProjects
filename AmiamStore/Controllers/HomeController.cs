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
        private string strCart = "Cart";

        [HttpGet]
        public ActionResult Index(int? productId)
        {
            if (productId.HasValue)
            {
                AddProductToCart(productId.Value);
                RedirectToAction("CartView", "ShoppingCart");
            }
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

        [HttpPost]
        public ActionResult Index(ProductsPageModel c)
        {
            CustomersRepository p = new CustomersRepository();
            p.InsertPotinoalCustomers(c);
            return RedirectToAction("Index", "Home");
        }
        private void AddProductToCart(int productId)
        {
            ProductBLL bll = new ProductBLL();

            if (Session[strCart] == null)
            {
                List<CartModel> listCart = new List<CartModel>
                {
                    new CartModel(bll.getProduct((int)productId) , 1)
                };
                Session[strCart] = listCart;
            }
            else
            {
                List<CartModel> listCart = (List<CartModel>)Session[strCart];
                int check = IsExistCheck(productId);
                if (check == 0)
                    listCart.Add(new CartModel(bll.getProduct(productId), 1));
                else
                    listCart[check].Quantity++;

                Session[strCart] = listCart;
            }
        }

        private int IsExistCheck(int id)
        {
            List<CartModel> listCart = (List<CartModel>)Session[strCart];
            for (int i = 0; i < listCart.Count; i++)
            {
                if (listCart[i].product.ProductID == id)
                    return i;
            }
            return 0;
        }

    }
}