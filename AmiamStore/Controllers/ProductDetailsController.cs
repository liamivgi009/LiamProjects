using AmiamStore.Models;
using System.Web.Mvc;
using AmiamStore.App_BLL;
using AmiamStore.App_DAL.Entities;

namespace AmiamStore.Controllers
{
    public class ProductDetailsController : Controller
    {
        // GET: ProductDetails
        public ActionResult ProductDetails(int id)
        {
            ProductBLL bll = new ProductBLL();
            Product prod = bll.getProduct(id);
            ViewBag.Message = prod;
            return View();
        }
    }
}