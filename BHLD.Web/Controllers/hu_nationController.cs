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
    public class hu_nationController : Controller
    {
        private BHLDDbContext db = new BHLDDbContext();

        // GET: hu_nation
        public ActionResult Index()
        {
            return View();
        }

        // GET: hu_nation/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hu_nation hu_nation = db.hu_Nations.Find(id);
            if (hu_nation == null)
            {
                return HttpNotFound();
            }
            return View(hu_nation);
        }

        // GET: hu_nation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: hu_nation/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,code,nation_name,remark,actflg,created_by,created_date,created_log,modified_date,status")] hu_nation hu_nation)
        {
            if (ModelState.IsValid)
            {
                db.hu_Nations.Add(hu_nation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hu_nation);
        }

        // GET: hu_nation/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hu_nation hu_nation = db.hu_Nations.Find(id);
            if (hu_nation == null)
            {
                return HttpNotFound();
            }
            return View(hu_nation);
        }

        // POST: hu_nation/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,code,nation_name,remark,actflg,created_by,created_date,created_log,modified_date,status")] hu_nation hu_nation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hu_nation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hu_nation);
        }

        // GET: hu_nation/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hu_nation hu_nation = db.hu_Nations.Find(id);
            if (hu_nation == null)
            {
                return HttpNotFound();
            }
            return View(hu_nation);
        }

        // POST: hu_nation/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            hu_nation hu_nation = db.hu_Nations.Find(id);
            db.hu_Nations.Remove(hu_nation);
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
