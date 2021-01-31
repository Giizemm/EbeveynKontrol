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
    [Authorize]
    public class PasswordController : Controller
    {
        private UserManager _userManager;

        public PasswordController()
        {
            _userManager = new UserManager(new AdoUserDal());
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string oldPassword, string newPassword1, string newPassword2)
        {
            var oldUser = _userManager.GetAll().First();
            if (oldUser.Password != oldPassword || newPassword1 != newPassword2)
            {
                ViewBag.Result = "Şifre Değiştirilemedi.";
            }
            else
            {
                oldUser.Password = newPassword1;
                _userManager.Update(oldUser);
                ViewBag.Result = "Şifreniz başarıyla değiştirildi.";
                FormsAuthentication.SignOut();

            }
            return View();
        }
    }
}