using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalUI.Controllers
{
    public class PatientSpecialityController : Controller
    {
        // GET: PatientSpeciality
        PatientSpecialityManager psm = new PatientSpecialityManager(new PatientSpecialityDal());
        [Authorize]
        public ActionResult Index()
        {
            var x = psm.GetList().Where(a => a.SpecialityStatus == true).ToList();
            return View(x);
        }
        [HttpGet]
        public ActionResult AddPatientSpeciality()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddPatientSpeciality(PatientSpeciality patientSpeciality)
        {
            patientSpeciality.SpecialityStatus = true;
            psm.PatientSpecialityAdd(patientSpeciality);
            return RedirectToAction("Index");
        }

        public ActionResult DeletePatientSpeciality(int id)
        {
            var t = psm.GetById(id); //id si verilen ifadenin tüm bilgilerini value ya ata.
            t.SpecialityStatus = false;
            psm.PatientSpecialityDelete(t);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdatePatientSpeciality(int id)
        {
            var t = psm.GetById(id);
            return View(t);
        }
        [HttpPost]
        public ActionResult UpdatePatientSpeciality(PatientSpeciality p)
        {
            psm.PatientSpecialityUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
