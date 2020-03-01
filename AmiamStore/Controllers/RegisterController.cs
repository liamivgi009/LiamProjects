using AmiamStore.Controllers.BaseControllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AmiamStore.Controllers
{
    public class RegisterController : BaseController
    {
        public RegisterController() : base(false) { }
        // GET: Register
        public ActionResult Register()
        {
            return View();
        }
    }
}