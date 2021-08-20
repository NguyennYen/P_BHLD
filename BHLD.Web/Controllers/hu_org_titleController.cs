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
    public class hu_org_titleController : Controller
    {
        private BHLDDbContext db = new BHLDDbContext();

        // GET: hu_org_title
        public ActionResult Index()
        {
            return View();
        }

        // GET: hu_org_title/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hu_org_title hu_org_title = db.hu_Org_Titles.Find(id);
            if (hu_org_title == null)
            {
                return HttpNotFound();
            }
            return View(hu_org_title);
        }

        // GET: hu_org_title/Create
        public ActionResult Create()
        {
            ViewBag.org_id = new SelectList(db.hu_Organizations, "id", "code");
            ViewBag.title_id = new SelectList(db.hu_Titles, "id", "code");
            return View();
        }

        // POST: hu_org_title/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,org_id,title_id,actfg,remark,created_by,created_date,created_log,modified_date,status")] hu_org_title hu_org_title)
        {
            if (ModelState.IsValid)
            {
                db.hu_Org_Titles.Add(hu_org_title);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.org_id = new SelectList(db.hu_Organizations, "id", "code", hu_org_title.org_id);
            ViewBag.title_id = new SelectList(db.hu_Titles, "id", "code", hu_org_title.title_id);
            return View(hu_org_title);
        }

        // GET: hu_org_title/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hu_org_title hu_org_title = db.hu_Org_Titles.Find(id);
            if (hu_org_title == null)
            {
                return HttpNotFound();
            }
            ViewBag.org_id = new SelectList(db.hu_Organizations, "id", "code", hu_org_title.org_id);
            ViewBag.title_id = new SelectList(db.hu_Titles, "id", "code", hu_org_title.title_id);
            return View(hu_org_title);
        }

        // POST: hu_org_title/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,org_id,title_id,actfg,remark,created_by,created_date,created_log,modified_date,status")] hu_org_title hu_org_title)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hu_org_title).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.org_id = new SelectList(db.hu_Organizations, "id", "code", hu_org_title.org_id);
            ViewBag.title_id = new SelectList(db.hu_Titles, "id", "code", hu_org_title.title_id);
            return View(hu_org_title);
        }

        // GET: hu_org_title/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hu_org_title hu_org_title = db.hu_Org_Titles.Find(id);
            if (hu_org_title == null)
            {
                return HttpNotFound();
            }
            return View(hu_org_title);
        }

        // POST: hu_org_title/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            hu_org_title hu_org_title = db.hu_Org_Titles.Find(id);
            db.hu_Org_Titles.Remove(hu_org_title);
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
