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
    public class AmountOfMaterialController : Controller
    {
        // GET: AmountOfMaterial
        AmountOfMaterialManager aom = new AmountOfMaterialManager(new AmountOfMaterialDal());
        [Authorize]
        public ActionResult Index()
        {
            var x = aom.GetList();
            return View(x);
        }
        [HttpGet]
        public ActionResult AddAmountOfMaterial()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAmountOfMaterial(AmountOfMaterial amountOfMaterial)
        {
            amountOfMaterial.AmountStatus = true;
            aom.AmountOfMaterialAdd(amountOfMaterial);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteAmountOfMaterial(int id)
        {
            var t = aom.GetById(id); //id si verilen ifadenin tüm bilgilerini value ya ata.
            t.AmountStatus = false;
            aom.AmountOfMaterialDelete(t);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateAmountOfMaterial(int id)
        {
            var t = aom.GetById(id);
            return View(t);
        }
        [HttpPost]
        public ActionResult UpdateAmountOfMaterial(AmountOfMaterial a)
        {
            aom.AmountOfMaterialUpdate(a);
            return RedirectToAction("Index");
        }
    }
}
