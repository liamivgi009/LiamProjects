﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AmiamStore.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult HomePage()
        {
            return View();
        }
    }
}