using DataAccessLayer;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace HospitalUI.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin p)
        {
            Context c = new Context();
            var adminUserInfo = c.Admins.FirstOrDefault(x => x.UserName == p.UserName && x.Password == p.Password);
            if (adminUserInfo != null)
            {
                FormsAuthentication.SetAuthCookie(adminUserInfo.UserName, false); //cookie istemiyorum
                Session["UserName"] = adminUserInfo.UserName;
                return RedirectToAction("Index", "AdminList");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        [HttpGet]
        public ActionResult PatientLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult PatientLogin(Patient p)
        {
            Context c = new Context();
            var UserInfo = c.Patients.FirstOrDefault(x => x.UserName == p.UserName && x.Password == p.Password);
            if (UserInfo != null)
            {
                FormsAuthentication.SetAuthCookie(UserInfo.UserName, false); //cookie istemiyorum
                Session["UserName"] = UserInfo.UserName;
                return RedirectToAction("Index", "Patient");
            }
            else
            {
                return RedirectToAction("PatientLogin");
            }
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");
        }
    }
}