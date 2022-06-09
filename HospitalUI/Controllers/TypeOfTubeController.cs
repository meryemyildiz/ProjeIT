using BusinessLayer.Concrete;
using DataAccessLayer;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalUI.Controllers
{
    public class TypeOfTubeController : Controller
    {
        // GET: TypeOfTube
        TypeOfTubeManager tm = new TypeOfTubeManager(new TypeOfTubeDal());
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {

            var x = tm.GetList().Where(a => a.TubeStatus == true).ToList();
            return View(x);
        }
        [HttpGet]
        public ActionResult AddTube()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddTube(TypeOfTube tube)
        {
            tube.TubeStatus = true;
            tm.TypeOfTubeAdd(tube);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteTube(int id)
        {
            var t = tm.GetById(id); //id si verilen ifadenin tüm bilgilerini value ya ata.
            t.TubeStatus = false;
            tm.TypeOfTubeDelete(t);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateTube(int id)
        {
            var t = tm.GetById(id);
            return View(t);
        }
        [HttpPost]
        public ActionResult UpdateTube(TypeOfTube t)
        {
            tm.TypeOfTubeUpdate(t);
            return RedirectToAction("Index");
        }
    }
}