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
    
    public class PatientController : Controller
    {
        // GET: Patient
        AdminListManager alm = new AdminListManager(new AdminListDal());
        PatientManager pm = new PatientManager(new PatientDal());
       
        public ActionResult Index(string UserName)
        {
            using (var context=new Context())
            {
                var result = from p in context.Patients
                             join a in context.AdminLists on p.PatientId equals a.Id
                             select new PatientDTO()
                             {
                                 Id=a.Id,
                                 Amount=a.AmountOfMaterial.Amount,
                                 CancerName=a.TypesOfCancer.CancerName,
                                 UserName=p.UserName,
                                 Going=a.Going,
                                 Kota=a.Kota,
                                 MaterialName=a.TypeOfMaterial.MaterialName,
                                 phaseName=a.Phase.phaseName,
                                 ProName=a.ProjectName.ProName,
                                 ProStatus=a.ProjectStatus.ProStatus,
                                 ProType=a.ProjectType.ProType,
                                 Remainder=a.Remainder,
                                 SpecialityName=a.PatientSpeciality.SpecialityName,
                                 SponsorName=a.Sponsor.SponsorName,
                                 
                                 TubeName=a.TypeOfTube.TubeName,
                                 İncoming=a.İncoming
                             };
                ViewBag.ListOfPatient = result.Where(x=>x.UserName==UserName).ToList();
            }
            return View();
        }
        [HttpGet]
        public ActionResult AddPatient()
        {
            return View();
        }
    
        [HttpPost]
        public ActionResult AddPatient(Patient patient)
        {
            pm.PatientAdd(patient);
            return RedirectToAction("Index","AdminList");
        }
    }
}