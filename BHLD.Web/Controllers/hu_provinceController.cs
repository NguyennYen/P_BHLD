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
    public class hu_provinceController : Controller
    {
        private BHLDDbContext db = new BHLDDbContext();

        // GET: hu_province
        public ActionResult Index()
        {
            //var hu_Provinces = db.hu_Provinces.Include(h => h.hu_nation);
            return View();
        }

        // GET: hu_province/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hu_province hu_province = db.hu_Provinces.Find(id);
            if (hu_province == null)
            {
                return HttpNotFound();
            }
            return View(hu_province);
        }

        // GET: hu_province/Create
        public ActionResult Create()
        {
            ViewBag.nation_id = new SelectList(db.hu_Nations, "id", "code");
            return View();
        }

        // POST: hu_province/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,code,province_name,nation_id,remark,actflg,created_by,created_date,created_log,modified_date,status")] hu_province hu_province)
        {
            if (ModelState.IsValid)
            {
                db.hu_Provinces.Add(hu_province);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.nation_id = new SelectList(db.hu_Nations, "id", "code", hu_province.nation_id);
            return View(hu_province);
        }

        // GET: hu_province/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hu_province hu_province = db.hu_Provinces.Find(id);
            if (hu_province == null)
            {
                return HttpNotFound();
            }
            ViewBag.nation_id = new SelectList(db.hu_Nations, "id", "code", hu_province.nation_id);
            return View(hu_province);
        }

        // POST: hu_province/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,code,province_name,nation_id,remark,actflg,created_by,created_date,created_log,modified_date,status")] hu_province hu_province)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hu_province).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.nation_id = new SelectList(db.hu_Nations, "id", "code", hu_province.nation_id);
            return View(hu_province);
        }

        // GET: hu_province/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hu_province hu_province = db.hu_Provinces.Find(id);
            if (hu_province == null)
            {
                return HttpNotFound();
            }
            return View(hu_province);
        }

        // POST: hu_province/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            hu_province hu_province = db.hu_Provinces.Find(id);
            db.hu_Provinces.Remove(hu_province);
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
