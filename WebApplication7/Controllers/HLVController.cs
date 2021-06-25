using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7.Models;
using WebApplication7.DAL;

namespace WebApplication7.Controllers
{
    public class HLVController : Controller
    {
        // GET: HLV
        private DALBanHuanLuyen dAL = new DALBanHuanLuyen();

        public ActionResult Index()
        {
            return View(dAL.getAllBHL());
        }
        
        public ActionResult Create(){

            return View();
        }

        [HttpPost]
        public ActionResult Create(BanHuanLuyen hlv)
        {
            dAL.addBHL(hlv);
            return RedirectToAction("Index");
        }
        public ActionResult Details(string id)
        {
            return View(dAL.getMotBHL(id));
        }
        public ActionResult Edit(string id)
        {
            return View(dAL.getMotBHL(id));
        }

        [HttpPost]
        public ActionResult Edit(BanHuanLuyen bhl)
        {
            dAL.editBHL(bhl);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(string id)
        {
            dAL.deleteBHL(id);
           return RedirectToAction("Index");
        }
    }
}