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
    public class ProjectTypeController : Controller
    {
        // GET: ProjectType
        ProjectTypeManager ptm = new ProjectTypeManager(new ProjectTypeDal());
        [Authorize]
        public ActionResult Index()
        {
            var x = ptm.GetList().Where(a => a.TypeStatus == true).ToList();
            return View(x);
        }
        [HttpGet]
        public ActionResult AddProjectType()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProjectType(ProjectType projectType)
        {
            projectType.TypeStatus = true;
            ptm.ProjectTypeAdd(projectType);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateProjectType(int id)
        {
           var x= ptm.GetById(id);
            return View(x);
        }
        [HttpPost]
        public ActionResult UpdateProjectType(ProjectType projectType)
        {
            ptm.ProjectTypeUpdate(projectType);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteProjectType(int id)
        {
            var x = ptm.GetById(id);
            x.TypeStatus = false;
            ptm.ProjectTypeDelete(x);
            return RedirectToAction("Index");
        }
    }
}