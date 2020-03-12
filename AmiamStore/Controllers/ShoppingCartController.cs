using AmiamStore.App_BLL;
using AmiamStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AmiamStore.Controllers
{
    public class ShoppingCartController : Controller
    {
        ProductBLL bll = new ProductBLL();
        private string strCart = "Cart";
        // GET: ShoppingCart
        public ActionResult CartView()
        {
            return View();
        }
        public ActionResult OrderNow(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            if(Session[strCart] == null)
            {
                List<CartModel> listCart = new List<CartModel>
                {
                    new CartModel(bll.getProduct((int)id) , 1)
                };
                Session[strCart] = listCart;
            }
            else
            {
                List<CartModel> listCart = (List<CartModel>)Session[strCart];
                int check = isExistCheck((int)id);
                if (check == 0)
                    listCart.Add(new CartModel(bll.getProduct((int)id), 1));
                else
                    listCart[check].Quantity++;

                Session[strCart] = listCart;
            }
          
            return View("CartView");
        }
        private int isExistCheck(int id)
        {
            List<CartModel> listCart = (List<CartModel>)Session[strCart];
            for(int i = 0;i< listCart.Count;i++)
            {
                if (listCart[i].product.ProductID == id)
                    return i;
            }
            return 0;
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            int check = isExistCheck((int)id);
            List<CartModel> listCart = (List<CartModel>)Session[strCart];
            listCart.RemoveAt(check);
            return View("CartView");

        }
    }
}