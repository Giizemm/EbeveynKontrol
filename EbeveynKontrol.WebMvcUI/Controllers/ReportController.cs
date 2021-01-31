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
    public class ReportController : Controller
    {
        private ReportManager _reportManager;

        public ReportController()
        {
            _reportManager = new ReportManager(new AdoReportDal());
        }

        public ActionResult Index()
        {
            return View(_reportManager.GetAll());
        }

        public ActionResult Delete(int id)
        {
            _reportManager.Delete(id);
            return RedirectToAction("Index");
        }
    }
}