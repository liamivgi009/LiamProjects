using AmiamStore.Controllers.BaseControllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AmiamStore.Controllers
{
    public class ContactUsController : BaseController
    {
        // GET: ContactUs
        public ContactUsController() : base(false) { }
        public ActionResult ContactUsPage()
        {
            return View();
        }
    }
}