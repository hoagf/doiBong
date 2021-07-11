using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7.DAL;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class DoiBongController : Controller
    {
        // GET: DoiBong
        DADoiBong db = new DADoiBong();
        DALBanHuanLuyen bhl = new DALBanHuanLuyen();
        DALCauThu ct = new DALCauThu();
        public ActionResult ListDoiBong()
        {
            List<DoiBong> list = db.getAllDoiBong();
            return View(list);

        }
        //xem chi tiet doi bong
        public ActionResult Details(string id)
        {
            List<BanHuanLuyen> bhlList = bhl.getBHLCuaCLB(id);
            List<CauThu> ctList = ct.getCauThuClb(id);
            ViewBag.HLV = bhlList;
            ViewBag.CT = ctList;
            return View(db.getMotDoiBong(id));
        }
        //sua thong tin  doi bong
        public ActionResult QuanLyHLV(string id)
        {
            ViewBag.HLV = new List<BanHuanLuyen>();
            return RedirectToAction("Index", "HLV", new { @errorId = id });
        }
        public ActionResult CauThuCLB(string id)
        {

            return RedirectToAction("Index", "CauThu", new { @errorId = id });
        }
    }
}