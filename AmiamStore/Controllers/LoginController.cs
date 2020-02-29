using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmiamStore.Models;
using AmiamStore.App_BLL;
using AmiamStore.App_DAL;
using AmiamStore.Controllers.BaseControllers;

namespace AmiamStore.Controllers
{
    public class LoginController : BaseController
    {
        public LoginController() : base(false) { }

        [HttpGet]
        public ActionResult LoginPage()
        {
            return View();

        }

        // GET: LoginPage
        [HttpPost]
        public ActionResult LoginPage(User acc)
        {
            LoginBLL model = new LoginBLL();
            try
            {
                var user = model.GetSingleUser(acc.UserName, acc.Password);
                AuthenticationManager.SaveUser(user.UserName, user.UserType);
                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View(model);
            }



        }
    }
}