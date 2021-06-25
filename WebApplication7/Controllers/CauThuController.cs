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
        DALBanHuanLuyen bhl = new DALBanHuanLuyen();
        DADoiBong db = new DADoiBong();
        public ActionResult Index()
        {
            List<CauThu> list = new List<CauThu>();
            list = ct.getCauThuClb("HAGL");

            //Debug.WriteLine("Haah");
            CauThu sd = new CauThu(6, "Nguyen Trong Hoang", "VN", "RB", "Nam", 1100, 1988, 177, 77, "SLNA", "vfd");
            //ct.addCauThu(sd);
            // ct.editCauThu(sd);
          //  ct.deleteCauThu("7");
           
            return View(list);
        }
        public ActionResult Index2()
        {
            
            List<BanHuanLuyen> list = new List<BanHuanLuyen>();
            list = bhl.getAllBHL();
            //BanHuanLuyen bh = bhl.getMotBHL("2");
            //Debug.WriteLine(bh.ChucVu);
            //Debug.WriteLine(bh.TenHlv);
            //BanHuanLuyen bo = new BanHuanLuyen(4, "Choi Ju Young", "HQ", 1971, "Nam", "BS", "HAGL", "http://cds");
            //bhl.editBHL(bo);
            //bhl.deleteBHL("5");
            return View(list);
        }
       /* public ActionResult DoiBong()
        {

            List<DoiBong> list = db.getAllDoiBong();
            //DoiBong a = db.getMotDoiBong("HAGL");
            //Debug.WriteLine(a.TenClb);
            // DoiBong b = new DoiBong("HP", "Hai Phong", "Viet Nam", "huhuh", 1955);
            //db.addDoiBong(b);
            // db.editDoiBong(b);
           // db.deleteDoiBong("HP");
            return View(list);
        }*/

    }
}