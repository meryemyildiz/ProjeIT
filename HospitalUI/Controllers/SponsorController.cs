using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalUI.Controllers
{
    public class SponsorController : Controller
    {
        // GET: Sponsor
        SponsorManager sm = new SponsorManager(new SponsorDal());
        [Authorize]
        public ActionResult Index()
        {
            var x = sm.GetList().Where(a => a.SponsorStatus == true).ToList();
            return View(x);
        }
        [HttpGet]
        public ActionResult AddSponsor()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSponsor(Sponsor s)
        {
            s.SponsorStatus = true;
            sm.SponsorAdd(s);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateSponsor(int id)
        {
            var x = sm.GetById(id);
            return View(x);
        }
        [HttpPost]
        public ActionResult UpdateSponsor(Sponsor s)
        {
            sm.SponsorUpdate(s);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteSponsor(int id)
        {
            var x = sm.GetById(id);
            x.SponsorStatus = false;
            sm.SponsorDelete(x);
            return RedirectToAction("Index");
        }
    }
}