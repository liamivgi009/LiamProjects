using AmiamStore.Models;
using System.Web.Mvc;
using AmiamStore.App_BLL;

namespace AmiamStore.Controllers
{
    public class ProductDetailsController : Controller
    {
        // GET: ProductDetails
        public ActionResult ProductDetails(string id)
        {
            ProductBLL bll = new ProductBLL();
            Product prod = bll.getProduct(id);
            ViewBag.Message = prod;
            return View();
        }
    }
}