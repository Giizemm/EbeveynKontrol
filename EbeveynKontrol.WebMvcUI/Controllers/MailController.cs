using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EbeveynKontrol.Bll.Concrete;
using EbeveynKontrol.Dal.Concrete.AdoNet;

namespace EbeveynKontrol.WebMvcUI.Controllers
{
    [Authorize]
    public class MailController : Controller
    {
        private MailManager _mailManager;

        public MailController()
        {
            _mailManager = new MailManager(new AdoMailDal());
        }

        public ActionResult Index()
        {
            return View(_mailManager.FirstMail());
        }

        [HttpPost]
        public ActionResult Index(string mailAdress)
        {
            var updateMail = _mailManager.FirstMail();
            updateMail.Adress = mailAdress;
            _mailManager.Update(updateMail);
            ViewBag.Update = "Success";
            return View("Index", _mailManager.FirstMail());
        }
    }
}