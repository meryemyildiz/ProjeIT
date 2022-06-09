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
    public class TypeOfCancerController : Controller
    {
        // GET: TypesOfCancer
        TypeOfCancerManager tm = new TypeOfCancerManager(new TypeOfCancerDal());
        [Authorize]
        public ActionResult Index()
        {
            var x = tm.GetList().Where(a => a.CancerStatus == true).ToList();
            return View(x);
        }
        [HttpGet]
        public ActionResult AddTypeOfCancer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddTypeOfCancer(TypesOfCancer t)
        {
            t.CancerStatus = true;
            tm.TypesOfCancerAdd(t);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateTypeOfCancer(int id)
        {
           var x= tm.GetById(id);
            return View(x);
        }
        [HttpPost]
        public ActionResult UpdateTypeOfCancer(TypesOfCancer t)
        {
            tm.TypeOfCancerUpdate(t);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteTypeOfCancer(int id)
        {
            var x = tm.GetById(id);
            x.CancerStatus = false;
            tm.TypeOfCancerDelete(x);
            return RedirectToAction("Index");
        }
    }
}