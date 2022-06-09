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
    public class ProjectNameController : Controller
    {
        // GET: ProjectName
        ProjectNameManager pnm = new ProjectNameManager(new ProjectNameDal());
        [Authorize]
        public ActionResult Index()
        {
            var x = pnm.GetList();
            return View(x);
        }
        [HttpGet]
        public ActionResult AddProjectName()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProjectName(ProjectName projectName)
        {
            pnm.ProjectNameAdd(projectName);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateProjectName(int id)
        {
            var t = pnm.GetById(id);
            return View(t);
        }
        
        [HttpPost]
        public ActionResult UpdateProjectName(ProjectName projectName)
        {

            pnm.ProjectNameUpdate(projectName);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteProjectName(int id)
        {
            var t = pnm.GetById(id);
            pnm.ProjectNameDelete(t);
            return RedirectToAction("Index");
        }

    }
}