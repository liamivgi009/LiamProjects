using AmiamStore.Models;
using System.Web.Mvc;
using AmiamStore.App_BLL;

namespace AmiamStore.Controllers
{
    public class ProductDetailsController : Controller
    {
        // GET: ProductDetails
        public ActionResult ProductDetails()
        {
            ProductBLL bll = new ProductBLL();
            Product prod = bll.getProduct("12");
            ViewBag.Message = prod;
            return View();
        }
    }
}