using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7.DAL;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class CauThuController : Controller
    {
        string idClbb;
        // GET: CauThu
        DALCauThu ct = new DALCauThu();
        DADoiBong db = new DADoiBong();
        //public ActionResult Index()
        public ActionResult Index(string errorId)
        {
            if(errorId == null)
            {
                List<CauThu> list = ct.getAllCauThu();
                return View(list);
            }
            else
            {
                {
                    List<CauThu> list = ct.getCauThuClb(errorId);
                    return View(list);
                }
            }
  
        }

        public ActionResult Details(string id)
        {
            CauThu cauthu = ct.getMotCauThu(id);
            DoiBong doiBong = db.getMotDoiBong(cauthu.IdClb);
            ViewBag.CT = cauthu;
            ViewBag.CLB = doiBong;
            return View();
        }       
    }
}