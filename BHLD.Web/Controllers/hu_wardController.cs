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
    public class hu_wardController : Controller
    {
        private BHLDDbContext db = new BHLDDbContext();

        // GET: hu_ward
        public ActionResult Index()
        {
            
            return View();
        }

        // GET: hu_ward/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hu_ward hu_ward = db.hu_Wards.Find(id);
            if (hu_ward == null)
            {
                return HttpNotFound();
            }
            return View(hu_ward);
        }

        // GET: hu_ward/Create
        public ActionResult Create()
        {
            ViewBag.district_id = new SelectList(db.hu_Districts, "id", "code");
            return View();
        }

        // POST: hu_ward/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,code,ward_name,district_id,remark,actfg,created_by,created_date,created_log,modified_date,status")] hu_ward hu_ward)
        {
            if (ModelState.IsValid)
            {
                db.hu_Wards.Add(hu_ward);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.district_id = new SelectList(db.hu_Districts, "id", "code", hu_ward.district_id);
            return View(hu_ward);
        }

        // GET: hu_ward/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hu_ward hu_ward = db.hu_Wards.Find(id);
            if (hu_ward == null)
            {
                return HttpNotFound();
            }
            ViewBag.district_id = new SelectList(db.hu_Districts, "id", "code", hu_ward.district_id);
            return View(hu_ward);
        }

        // POST: hu_ward/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,code,ward_name,district_id,remark,actfg,created_by,created_date,created_log,modified_date,status")] hu_ward hu_ward)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hu_ward).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.district_id = new SelectList(db.hu_Districts, "id", "code", hu_ward.district_id);
            return View(hu_ward);
        }

        // GET: hu_ward/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hu_ward hu_ward = db.hu_Wards.Find(id);
            if (hu_ward == null)
            {
                return HttpNotFound();
            }
            return View(hu_ward);
        }

        // POST: hu_ward/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            hu_ward hu_ward = db.hu_Wards.Find(id);
            db.hu_Wards.Remove(hu_ward);
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
