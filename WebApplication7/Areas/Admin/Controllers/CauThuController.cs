using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7.DAL;
using WebApplication7.Models;

namespace WebApplication7.Areas.Admin.Controllers
{
    public class CauThuController : Controller
    {
        string idClbb;
        // GET: CauThu
        DALCauThu ct = new DALCauThu();
        //public ActionResult Index()
        public ActionResult Index(string errorId)
        {
            idClbb = errorId;
            if (Session["AdSession"] == null)
            {
                return Redirect("/Home/Index");
            }
            else if (errorId == null)
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
            if (Session["AdSession"] == null)
            {
                return Redirect("/Home/Index");
            }
            return View(ct.getMotCauThu(id));
        }

        //Them cau thu
        public ActionResult Create()
        {
            if (Session["AdSession"] == null)
            {
                return Redirect("/Home/Index");
            }
            return View();
        }
        [HttpPost]
        public ActionResult Create(CauThu cauthu)
        {
            idClbb = cauthu.IdClb;
            ct.addCauThu(cauthu);
            return RedirectToAction("Index", new { @errorId = idClbb });
        }

        public ActionResult Edit(string id)
        {
            if (Session["AdSession"] == null)
            {
                return Redirect("/Home/Index");
            }
            return View(ct.getMotCauThu(id) );
            
        }

        [HttpPost]
        public ActionResult Edit(CauThu ct1)
        {
            Request.ContentEncoding = System.Text.Encoding.UTF8;

            idClbb = ct1.IdClb;
            //ct1.IdCauThu = Int32.Parse(idd);
            ct.editCauThu(ct1);
            
            return RedirectToAction("Index", new { @errorId = idClbb });
        }


        //xoa cau thu--------------------------------------

        
        public ActionResult Delete(String id)
        {
            if (Session["AdSession"] == null)
            {
                return Redirect("/Home/Index");
            }
            CauThu gh = ct.getMotCauThu(id);
            ct.deleteCauThu(id);
            return RedirectToAction("Index", new { @errorId = gh.IdClb });
        }
        public ActionResult TroLai(string id) //
        {
            return RedirectToAction("Details", "DoiBong", new { @id = id });
        }
    }
}