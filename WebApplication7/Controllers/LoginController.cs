using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7.Models;
namespace WebApplication7.Controllers
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
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginModel model)
        {
            if (model.UserName.Equals("user") && model.Password.Equals("user"))
            {         
                Session.Add("USession", model.UserName);
                return RedirectToAction("Index", "Home");                
            }else if (model.UserName.Equals("admin") && model.Password.Equals("admin"))
            {
                Session.Add("AdSession", model.UserName);
                return Redirect("/Admin/DoiBong/ListDoiBong");
            }
                ModelState.AddModelError("", "Tài khoản hoặc Mật khẩu không đúng.");
            return View(model);
        }
        public ActionResult Logout()
        {
            Session["USession"] = null;
            return RedirectToAction("Index", "Home");
        }
    }
}