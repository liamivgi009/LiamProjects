using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AmiamStore.Controllers
{
    public class ContactUsController : Controller
    {
        string s = "1";
        // GET: ContactUs
        public ActionResult ContactUsPage()
        {
            return View();
        }
    }
}