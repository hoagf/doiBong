using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7.DAL;
namespace WebApplication7.Controllers
{
    public class HomeController : Controller
    {
        DADoiBong DoiBong = new DADoiBong();
        DALCauThu CauThu = new DALCauThu();

        // GET: Home
        public ActionResult Index()
        {
            ViewBag.DB = DoiBong.getAllDoiBong();
            ViewBag.CT = CauThu.getAllCauThu();

            return View();
        }
    }
}