using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7.Models;
using WebApplication7.DAL;

namespace WebApplication7.Areas.Admin.Controllers
{
    public class HLVController : Controller
    {
        // GET: HLV
        private DALBanHuanLuyen dAL = new DALBanHuanLuyen();
        string idClbb;

        public ActionResult Index(string errorId) //
        {
            idClbb = errorId;
            if (Session["AdSession"] == null)
            {
                return Redirect("/Home/Index");
            }
            else if (errorId ==null)
            {
                return View(dAL.getAllBHL());
            }
            else
            {
                return View(dAL.getBHLCuaCLB(errorId));
            }
            //return View(dAL.getAllBHL());
        }
        
        public ActionResult Create(){
            if (Session["AdSession"] == null)
            {
                return Redirect("/Home/Index");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Create(BanHuanLuyen hlv)
        {

            idClbb = hlv.IdClb;
            dAL.addBHL(hlv);
            return RedirectToAction("Index", new { @errorId = idClbb });
        }
        public ActionResult Details(string id)
        {
            if (Session["AdSession"] == null)
            {
                return Redirect("/Home/Index");
            }
            return View(dAL.getMotBHL(id));
        }
        public ActionResult Edit(string id)
        {
            if (Session["AdSession"] == null)
            {
                return Redirect("/Home/Index");
            }
            return View(dAL.getMotBHL(id));
        }

        [HttpPost]
        public ActionResult Edit(BanHuanLuyen bhl)
        {
            dAL.editBHL(bhl);
            idClbb = bhl.IdClb;
            return RedirectToAction("Index", new { @errorId = idClbb });
        }
        public ActionResult Delete(string id)
        {
            if (Session["AdSession"] == null)
            {
                return Redirect("/Home/Index");
            }
            BanHuanLuyen h = dAL.getMotBHL(id);
            dAL.deleteBHL(id);
            
           return RedirectToAction("Index", new { @errorId = h.IdClb});
        }
        
        public ActionResult getHLVCLB(string id)
        {
            if (Session["AdSession"] == null)
            {
                return Redirect("/Home/Index");
            }
            dAL.deleteBHL(id);
           return RedirectToAction("Index");
        }
        public ActionResult TroLai(string id) //
        {
            return RedirectToAction("Details", "DoiBong", new { @id = id });
        }
    }
}