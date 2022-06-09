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
    public class DenemeController : Controller
    {
        // GET: Deneme
        TypeOfTubeManager tm = new TypeOfTubeManager(new TypeOfTubeDal());
        public ActionResult Index()
        {
            var x = tm.GetList();
            return View(x);
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(TypeOfTube tube)
        {
            tm.TypeOfTubeAdd(tube);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var t = tm.GetById(id); //id si verilen ifadenin tüm bilgilerini value ya ata.
            tm.TypeOfTubeDelete(t);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Update(int id)
        {
            var t = tm.GetById(id);
            return View(t);
        }
        [HttpPost]
        public ActionResult Update(TypeOfTube t)
        {
            tm.TypeOfTubeUpdate(t);
            return RedirectToAction("Index");
        }
    }
}