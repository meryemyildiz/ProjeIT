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
    public class ProjectStatusController : Controller
    {
        // GET: ProjectStatus
        ProjectStatusManager psm = new ProjectStatusManager(new ProjectStatusDal());
        [Authorize]
        public ActionResult Index()
        {
            var x = psm.GetList().Where(a => a.ProjeStatus == true).ToList();
            return View(x);
        }
        [HttpGet]
        public ActionResult AddProjectStatus()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProjectStatus(ProjectStatus procetStatus)
        {
            procetStatus.ProjeStatus = true;
            psm.ProjectStatuseAdd(procetStatus);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateProjectStatus(int id)
        {
            var x = psm.GetById(id);
            return View(x);
        }
        [HttpPost]
        public ActionResult UpdateProjectStatus(ProjectStatus projectStatus)
        {
            psm.ProjectStatusUpdate(projectStatus);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteProjectStatus(int id)
        {
            var x = psm.GetById(id);
            x.ProjeStatus = false;
            psm.ProjectStatuseDelete(x);
            return RedirectToAction("Index");
        }
    }
}