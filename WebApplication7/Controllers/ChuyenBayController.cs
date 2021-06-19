//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using WebApplication7.DAL;
//using WebApplication7.Models;

//namespace WebApplication7.Controllers
//{
//    public class ChuyenBayController : Controller
//    {
//        DALChuyenBay cb = new DALChuyenBay();
//        // GET: ChuyenBay
//        public ActionResult Index(string strSearch)
//        {
//            List<ChuyenBay> list = new List<ChuyenBay>();
//            list = cb.getChuyenBay();
//            if (!String.IsNullOrEmpty(strSearch))
//            {
//                list = list.Where(x => x.DiemDen.Contains(strSearch)).ToList();
//            }
//            return View(list);
//        }
//        public ActionResult Create()
//        {
//            return View();
//        }
//        [HttpPost]
//        public ActionResult Create(ChuyenBay cbb)
//        {
//            cb.addChuyenBay(cbb);
//            return RedirectToAction("Index");

//            return View();
//        }

//        [HttpGet]
//        public ActionResult Edit(string id)
//        {
//            ChuyenBay cbb = cb.getMotChuyenBay(id);
//            return View(cbb);
//        }
//        [HttpPost]
//        public ActionResult Edit(ChuyenBay cbb)
//        {
//            cb.editChuyenBay(cbb);
//            return aRedirectToAction("Index");
//        }
//        [HttpGet]
//        public ActionResult Delete(string id)
//        {
//            ChuyenBay cbb = cb.getMotChuyenBay(id);
//            return View(cbb);
//        }

//        [HttpPost, ActionName("Delete")]

//        public ActionResult Deletecf(string id)
//        {

//            cb.deleteChuyenBay(id);
//            return RedirectToAction("Index");
//        }
//    }

//}