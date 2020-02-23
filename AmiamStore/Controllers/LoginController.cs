using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmiamStore.Models;
namespace AmiamStore.Controllers
{
    public class LoginController : Controller
    {
        // GET: LoginPage
        [HttpGet]
        public ActionResult LoginPage()
        {
            return View();
        }

    }
}