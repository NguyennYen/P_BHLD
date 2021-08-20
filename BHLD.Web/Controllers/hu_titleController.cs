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
    public class hu_titleController : Controller
    {
        private BHLDDbContext db = new BHLDDbContext();

        // GET: hu_title
        public ActionResult Index()
        {
            return View();
        }

        // GET: hu_title/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hu_title hu_title = db.hu_Titles.Find(id);
            if (hu_title == null)
            {
                return HttpNotFound();
            }
            return View(hu_title);
        }

        // GET: hu_title/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: hu_title/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,code,title_name,remark,actflg,created_by,created_date,created_log,modified_date,status")] hu_title hu_title)
        {
            if (ModelState.IsValid)
            {
                db.hu_Titles.Add(hu_title);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hu_title);
        }

        // GET: hu_title/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hu_title hu_title = db.hu_Titles.Find(id);
            if (hu_title == null)
            {
                return HttpNotFound();
            }
            return View(hu_title);
        }

        // POST: hu_title/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,code,title_name,remark,actflg,created_by,created_date,created_log,modified_date,status")] hu_title hu_title)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hu_title).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hu_title);
        }

        // GET: hu_title/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hu_title hu_title = db.hu_Titles.Find(id);
            if (hu_title == null)
            {
                return HttpNotFound();
            }
            return View(hu_title);
        }

        // POST: hu_title/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            hu_title hu_title = db.hu_Titles.Find(id);
            db.hu_Titles.Remove(hu_title);
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
