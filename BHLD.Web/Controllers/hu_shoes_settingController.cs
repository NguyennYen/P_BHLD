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
    public class hu_shoes_settingController : Controller
    {
        private BHLDDbContext db = new BHLDDbContext();

        // GET: hu_shoes_setting
        public ActionResult Index()
        {
            return View();
        }

        // GET: hu_shoes_setting/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hu_shoes_setting hu_shoes_setting = db.hu_Shoes_Settings.Find(id);
            if (hu_shoes_setting == null)
            {
                return HttpNotFound();
            }
            return View(hu_shoes_setting);
        }

        // GET: hu_shoes_setting/Create
        public ActionResult Create()
        {
            ViewBag.size_id = new SelectList(db.hu_Shoes_Sizes, "id", "code");
            return View();
        }

        // POST: hu_shoes_setting/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,gender,size_from,size_to,size_id,remark,actfg,created_by,created_date,created_log,modified_date,status")] hu_shoes_setting hu_shoes_setting)
        {
            if (ModelState.IsValid)
            {
                db.hu_Shoes_Settings.Add(hu_shoes_setting);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.size_id = new SelectList(db.hu_Shoes_Sizes, "id", "code", hu_shoes_setting.size_id);
            return View(hu_shoes_setting);
        }

        // GET: hu_shoes_setting/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hu_shoes_setting hu_shoes_setting = db.hu_Shoes_Settings.Find(id);
            if (hu_shoes_setting == null)
            {
                return HttpNotFound();
            }
            ViewBag.size_id = new SelectList(db.hu_Shoes_Sizes, "id", "code", hu_shoes_setting.size_id);
            return View(hu_shoes_setting);
        }

        // POST: hu_shoes_setting/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,gender,size_from,size_to,size_id,remark,actfg,created_by,created_date,created_log,modified_date,status")] hu_shoes_setting hu_shoes_setting)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hu_shoes_setting).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.size_id = new SelectList(db.hu_Shoes_Sizes, "id", "code", hu_shoes_setting.size_id);
            return View(hu_shoes_setting);
        }

        // GET: hu_shoes_setting/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hu_shoes_setting hu_shoes_setting = db.hu_Shoes_Settings.Find(id);
            if (hu_shoes_setting == null)
            {
                return HttpNotFound();
            }
            return View(hu_shoes_setting);
        }

        // POST: hu_shoes_setting/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            hu_shoes_setting hu_shoes_setting = db.hu_Shoes_Settings.Find(id);
            db.hu_Shoes_Settings.Remove(hu_shoes_setting);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
