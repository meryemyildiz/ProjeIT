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
    public class TypeOfMaterialController : Controller
    {
        // GET: TypeOfMaterial
        TypeOfMaterialManager tbm = new TypeOfMaterialManager(new TypeOfMaterialDal());
        [Authorize]
        public ActionResult Index()
        {
            var x = tbm.GetList().Where(a => a.MaterialStatus == true).ToList();
            return View(x);
        }

        [HttpGet]
        public ActionResult AddTypeOfMaterial()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddTypeOfMaterial(TypeOfMaterial t)
        {
            t.MaterialStatus = true;
            tbm.TypeOfMaterialAdd(t);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateTypeOfMaterial(int id)
        {
            var x = tbm.GetById(id);
            return View(x);
        }

        [HttpPost]
        public ActionResult UpdateTypeOfMaterial(TypeOfMaterial t)
        {
            tbm.TypeOfMaterialUpdate(t);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteTypeOfMaterial(int id)
        {
            var x = tbm.GetById(id);
            x.MaterialStatus = false;
            tbm.TypeOfMaterialrDelete(x);
            return RedirectToAction("Index");
        }
    }
}