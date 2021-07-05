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
        // GET: CauThu
        DALCauThu ct = new DALCauThu();
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
            return View(ct.getMotCauThu(id));
        }

        //Them cau thu
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(CauThu cauthu)
        {
            ct.addCauThu(cauthu);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(string id)
        {
            return View(ct.getMotCauThu(id) );
            
        }

        [HttpPost]
        public ActionResult Edit(CauThu ct1)
        {
            ct.editCauThu(ct1);
            
            return RedirectToAction("Index");
        }


        //xoa cau thu--------------------------------------

        
        public ActionResult Delete(String id)
        {
            ct.deleteCauThu(id);
            return RedirectToAction("Index");
        }


     

       
    }
}