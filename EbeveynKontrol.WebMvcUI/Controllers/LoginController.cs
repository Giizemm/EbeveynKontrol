using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using EbeveynKontrol.Bll.Concrete;
using EbeveynKontrol.Dal.Concrete.AdoNet;

namespace EbeveynKontrol.WebMvcUI.Controllers
{
    public class LoginController : Controller
    {
        private UserManager _userManager;

        public LoginController()
        {
            _userManager = new UserManager(new AdoUserDal());
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string userName, string userPassword)
        {
            var user = _userManager.GetAll().First();
            if (userName == user.Name && userPassword == user.Password)
            {
                FormsAuthentication.SetAuthCookie(userName, false);
            }
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}