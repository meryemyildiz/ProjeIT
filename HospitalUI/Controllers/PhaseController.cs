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
    public class PhaseController : Controller
    {
        // GET: Phase
        PhaseManager pm = new PhaseManager(new PhaseDal());
        [Authorize]
        public ActionResult Index()
        {
            var x = pm.GetList().Where(a => a.PhaseStatus == true).ToList();
            return View(x);
        }
        [HttpGet]
        public ActionResult AddPhase()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddPhase(Phase phase)
        {
            phase.PhaseStatus = true;
            pm.PhaseAdd(phase);
            return RedirectToAction("Index");
        }

        public ActionResult DeletePhase(int id)
        {
            var t = pm.GetById(id); //id si verilen ifadenin tüm bilgilerini value ya ata.
            t.PhaseStatus = false;
            pm.PhaseDelete(t);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdatePhase(int id)
        {
            var t = pm.GetById(id);
            return View(t);
        }
        [HttpPost]
        public ActionResult UpdatePhase(Phase p)
        {
            pm.PhaseUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
