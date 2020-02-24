using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AmiamStore.Controllers
{
    public class ProductsPageController : Controller
    {
        // GET: SpacifitProduct
        public ActionResult ProductsPage()
        {
            return View();
        }
    }
}