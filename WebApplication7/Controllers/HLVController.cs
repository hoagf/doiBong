using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Dynamic;
using System.Web.Mvc;
using WebApplication7.Models;
using WebApplication7.DAL;

namespace WebApplication7.Controllers
{
    public class HLVController : Controller
    {
        // GET: HLV
        private DALBanHuanLuyen dAL = new DALBanHuanLuyen();
        private DADoiBong db = new DADoiBong();
        string idClbb;

        public ActionResult Index(string errorId) //
        {
            if(errorId ==null)
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
            BanHuanLuyen bhl = dAL.getMotBHL(id);
            DoiBong doiBong = db.getMotDoiBong(bhl.IdClb);
            ViewBag.HLV = bhl;
            ViewBag.CLB = doiBong;
            return View();
        }
        public ActionResult Edit(string id)
        {
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
            dAL.deleteBHL(id);
           return RedirectToAction("Index", new { @errorId = idClbb});
        }
        
        public ActionResult getHLVCLB(string id)
        {
            dAL.deleteBHL(id);
           return RedirectToAction("Index");
        }
      
    }
}