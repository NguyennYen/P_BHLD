using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BHLD.Data;
using BHLD.Model.Models;

namespace BHLD.Web.Controllers
{
    public class hu_districtController : Controller
    {
        private BHLDDbContext db = new BHLDDbContext();

        // GET: hu_district
        public ActionResult Index()
        {
            //var hu_Districts = db.hu_Districts;
            return View();
        }

        public ActionResult Create()
        {
            
            return View(new hu_district());
        }

        public ActionResult Edit( int id)
        {
            var hu_districtModel = db.hu_Districts.Find(id);
            return View(hu_districtModel);
        }

        public ActionResult Delete(int id)
        {
            var model = db.hu_Districts.Find(id);
            db.hu_Districts.Remove(model);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        //Thêm mới
        [HttpPost]
        public ActionResult Create(hu_district modelNew)
        {
            db.hu_Districts.Add(modelNew);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Edit(hu_district model)
        {
            var obj = db.hu_Districts.Find(model.id);

            obj.code = model.code;
            obj.district_name = model.code;
            obj.province_id = model.province_id;
            obj.actfg = model.actfg;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
