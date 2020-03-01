using AmiamStore.Controllers.BaseControllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AmiamStore.Controllers
{
    public class ShareController : BaseController
    {
        public ShareController() : base(false) { }
        // GET: Share
        public ActionResult MasterPage()
        {
            return View();
        }
       
    }
}