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
    public class AdminListController : Controller
    {
        // GET: AdminList
        AdminListManager alm = new AdminListManager(new AdminListDal());
        ProjectNameManager pnm = new ProjectNameManager(new ProjectNameDal());
        ProjectTypeManager ptm = new ProjectTypeManager(new ProjectTypeDal());
        AmountOfMaterialManager aom = new AmountOfMaterialManager(new AmountOfMaterialDal());
        PatientSpecialityManager psm = new PatientSpecialityManager(new PatientSpecialityDal());
        PhaseManager pm = new PhaseManager(new PhaseDal());
        SponsorManager sm = new SponsorManager(new SponsorDal());
        TypeOfTubeManager ttm = new TypeOfTubeManager(new TypeOfTubeDal());
        TypeOfCancerManager tcm = new TypeOfCancerManager(new TypeOfCancerDal());
        ProjectStatusManager pstm = new ProjectStatusManager(new ProjectStatusDal());
        TypeOfMaterialManager tmm = new TypeOfMaterialManager(new TypeOfMaterialDal());

        public ActionResult Index()
        {
            var x = alm.GetList();
            return View(x);
        }
        [HttpGet]
        public ActionResult AddAdminList()
        {
            List<SelectListItem> valueName = (from x in pnm.GetList()
                                              select new SelectListItem
                                              {
                                                  Text = x.ProName,
                                                  Value = x.NameId.ToString()
                                              }).ToList();

            List<SelectListItem> valuepType = (from x in ptm.GetList().Where(x => x.TypeStatus == true)
                                               select new SelectListItem
                                               {
                                                   Text = x.ProType,
                                                   Value = x.ProjectTypeId.ToString()
                                               }).ToList();

            List<SelectListItem> valueAmount = (from x in aom.GetList()
                                                select new SelectListItem
                                                {
                                                    Text = x.Amount,
                                                    Value = x.AmountId.ToString()
                                                }).ToList();

            List<SelectListItem> valuepSpeciality = (from x in psm.GetList().Where(x => x.SpecialityStatus == true)
                                                     select new SelectListItem
                                                     {
                                                         Text = x.SpecialityName,
                                                         Value = x.PSpecialityId.ToString()
                                                     }).ToList();
            List<SelectListItem> valuePhase = (from x in pm.GetList().Where(x => x.PhaseStatus == true)
                                               select new SelectListItem
                                               {
                                                   Text = x.phaseName,
                                                   Value = x.PhaseId.ToString()
                                               }).ToList();

            List<SelectListItem> valueSponsor = (from x in sm.GetList().Where(x => x.SponsorStatus == true)
                                                 select new SelectListItem
                                                 {
                                                     Text = x.SponsorName,
                                                     Value = x.SponsorId.ToString()
                                                 }).ToList();


            List<SelectListItem> valueTube = (from x in ttm.GetList().Where(x => x.TubeStatus == true)
                                              select new SelectListItem
                                              {
                                                  Text = x.TubeName,
                                                  Value = x.TubeId.ToString()
                                              }).ToList();


            List<SelectListItem> valueCancer = (from x in tcm.GetList().Where(x => x.CancerStatus == true)
                                                select new SelectListItem
                                                {
                                                    Text = x.CancerName,
                                                    Value = x.CancerId.ToString()
                                                }).ToList();
            List<SelectListItem> valueStatus = (from x in pstm.GetList().Where(x => x.ProjeStatus == true)
                                                select new SelectListItem
                                                {
                                                    Text = x.ProStatus,
                                                    Value = x.StatusId.ToString()
                                                }).ToList();

            List<SelectListItem> valueMaterial = (from x in tmm.GetList().Where(x => x.MaterialStatus == true)
                                                  select new SelectListItem
                                                  {
                                                      Text = x.MaterialName,
                                                      Value = x.MaterialId.ToString()
                                                  }).ToList();

            ViewBag.vpn = valueName;
            ViewBag.vpt = valuepType;
            ViewBag.vaom = valueAmount;
            ViewBag.vpsm = valuepSpeciality;
            ViewBag.vpm = valuePhase;
            ViewBag.vsm = valueSponsor;
            ViewBag.vttm = valueTube;
            ViewBag.vtcm = valueCancer;
            ViewBag.vpstm = valueStatus;
            ViewBag.vtmm = valueMaterial;
            return View();
        }
        [HttpPost]
        public ActionResult AddAdminList(AdminList a)
        {
            alm.AdminListAdd(a);
            return RedirectToAction("Index");
        }

    }
}