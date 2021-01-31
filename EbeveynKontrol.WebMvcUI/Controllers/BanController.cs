using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EbeveynKontrol.Bll.Concrete;
using EbeveynKontrol.Dal.Concrete.AdoNet;
using EbeveynKontrol.Entity;

namespace EbeveynKontrol.WebMvcUI.Controllers
{
    [Authorize]
    public class BanController : Controller
    {
        private BanManager _banManager;

        public BanController()
        {
            _banManager = new BanManager(new AdoBanDal());
        }

        public ActionResult Index()
        {
            return View(_banManager.GetAll());
        }

        public ActionResult Delete(int id)
        {
            _banManager.Delete(id);
            return RedirectToAction("Index");
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(string banName)
        {
            _banManager.Add(new Ban() { Name = banName });
            return RedirectToAction("Index");
        }
    }
}