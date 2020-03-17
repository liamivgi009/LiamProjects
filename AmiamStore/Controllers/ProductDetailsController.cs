using AmiamStore.Models;
using System.Web.Mvc;
using AmiamStore.App_BLL;
using AmiamStore.Controllers.BaseControllers;

namespace AmiamStore.Controllers
{
    public class ProductDetailsController : BaseController
    {
        public ProductDetailsController() : base(UserType.Client) { }
        // GET: ProductDetails
        public ActionResult ProductDetails(int id)
        {
            ProductBLL bll = new ProductBLL();
            ProductModel prod = bll.getProduct(id);
            prod.CategoryId = 2; //TODO: Take it from DB
            ViewBag.Message = prod;
            return View();
        }
    }
}