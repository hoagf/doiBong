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
        public ActionResult ListDoiBong()
        {
            List<DoiBong> list = db.getAllDoiBong();
            //DoiBong a = db.getMotDoiBong("HAGL");
            //Debug.WriteLine(a.TenClb);
            // DoiBong b = new DoiBong("HP", "Hai Phong", "Viet Nam", "huhuh", 1955);
            //db.addDoiBong(b);
            // db.editDoiBong(b);
            // db.deleteDoiBong("HP");
            return View(list);
            return View();
        }
        public ActionResult CreateDoiBong()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateDoiBong(DoiBong doibong)
        {
            if (ModelState.IsValid)
            {
                db.addDoiBong(doibong);
                return RedirectToAction("ListDoiBong");
            }
            return View();
        }
        //xem chi tiet doi bong
        public ActionResult Details(string id)
        {
            return RedirectToAction("Index", "HLV", new { @id = id });
        }
        //sua thong tin  doi bong
        public ActionResult Edit(string id)
        {
            return View(db.getMotDoiBong(id));
        }
        [HttpPost]
        public ActionResult Edit(DoiBong doibong)
        {

            if (ModelState.IsValid)
            {
                db.editDoiBong(doibong);
                return RedirectToAction("ListDoiBong");
            }
            return View();

        }
        public ActionResult Delete(string id)
        {
            db.deleteDoiBong(id);
            return RedirectToAction("ListDoiBong");
        }

    }
}