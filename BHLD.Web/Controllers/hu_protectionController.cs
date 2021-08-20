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
    public class hu_protectionController : Controller
    {
        private BHLDDbContext db = new BHLDDbContext();

        // GET: hu_protection
        public ActionResult Index()
        {
            return View();
        }

        // GET: hu_protection/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hu_protection hu_protection = db.hu_Protections.Find(id);
            if (hu_protection == null)
            {
                return HttpNotFound();
            }
            return View(hu_protection);
        }

        // GET: hu_protection/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: hu_protection/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,code,protection_name,remark,actflg,created_by,created_date,created_log,modified_date,status")] hu_protection hu_protection)
        {
            if (ModelState.IsValid)
            {
                db.hu_Protections.Add(hu_protection);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hu_protection);
        }

        // GET: hu_protection/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hu_protection hu_protection = db.hu_Protections.Find(id);
            if (hu_protection == null)
            {
                return HttpNotFound();
            }
            return View(hu_protection);
        }

        // POST: hu_protection/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,code,protection_name,remark,actflg,created_by,created_date,created_log,modified_date,status")] hu_protection hu_protection)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hu_protection).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hu_protection);
        }

        // GET: hu_protection/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hu_protection hu_protection = db.hu_Protections.Find(id);
            if (hu_protection == null)
            {
                return HttpNotFound();
            }
            return View(hu_protection);
        }

        // POST: hu_protection/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            hu_protection hu_protection = db.hu_Protections.Find(id);
            db.hu_Protections.Remove(hu_protection);
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
