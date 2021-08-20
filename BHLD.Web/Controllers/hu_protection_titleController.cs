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
    public class hu_protection_titleController : Controller
    {
        private BHLDDbContext db = new BHLDDbContext();

        // GET: hu_protection_title
        public ActionResult Index()
        {
            return View();
        }

        // GET: hu_protection_title/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hu_protection_title hu_protection_title = db.hu_Protection_Titles.Find(id);
            if (hu_protection_title == null)
            {
                return HttpNotFound();
            }
            return View(hu_protection_title);
        }

        // GET: hu_protection_title/Create
        public ActionResult Create()
        {
            ViewBag.title_id = new SelectList(db.hu_Titles, "id", "code");
            return View();
        }

        // POST: hu_protection_title/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,type_id,title_id,effect_date,expire_date,remark,actfg,created_by,created_date,created_log,modified_date,status")] hu_protection_title hu_protection_title)
        {
            if (ModelState.IsValid)
            {
                db.hu_Protection_Titles.Add(hu_protection_title);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.title_id = new SelectList(db.hu_Titles, "id", "code", hu_protection_title.title_id);
            return View(hu_protection_title);
        }

        // GET: hu_protection_title/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hu_protection_title hu_protection_title = db.hu_Protection_Titles.Find(id);
            if (hu_protection_title == null)
            {
                return HttpNotFound();
            }
            ViewBag.title_id = new SelectList(db.hu_Titles, "id", "code", hu_protection_title.title_id);
            return View(hu_protection_title);
        }

        // POST: hu_protection_title/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,type_id,title_id,effect_date,expire_date,remark,actfg,created_by,created_date,created_log,modified_date,status")] hu_protection_title hu_protection_title)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hu_protection_title).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.title_id = new SelectList(db.hu_Titles, "id", "code", hu_protection_title.title_id);
            return View(hu_protection_title);
        }

        // GET: hu_protection_title/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hu_protection_title hu_protection_title = db.hu_Protection_Titles.Find(id);
            if (hu_protection_title == null)
            {
                return HttpNotFound();
            }
            return View(hu_protection_title);
        }

        // POST: hu_protection_title/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            hu_protection_title hu_protection_title = db.hu_Protection_Titles.Find(id);
            db.hu_Protection_Titles.Remove(hu_protection_title);
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
