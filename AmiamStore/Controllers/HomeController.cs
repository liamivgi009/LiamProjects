using AmiamStore.Controllers.BaseControllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AmiamStore.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController() : base(false) { }

        public ActionResult Index()
        {
            return View();
        }

    }
}