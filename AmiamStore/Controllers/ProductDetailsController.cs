using AmiamStore.Models;
using System.Web.Mvc;
using AmiamStore.App_BLL;

namespace AmiamStore.Controllers
{
    public class ProductDetailsController : Controller
    {
        // GET: ProductDetails
        public ActionResult ProductDetails(int id)
        {
            ProductBLL bll = new ProductBLL();
            ProductModel prod = bll.getProduct(id);
            ViewBag.Message = prod;
            return View();
        }
    }
}