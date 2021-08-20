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
    public class hu_shoes_sizeController : Controller
    {
        private BHLDDbContext db = new BHLDDbContext();

        // GET: hu_shoes_size
        public ActionResult Index()
        {
            return View();
        }

        // GET: hu_shoes_size/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hu_shoes_size hu_shoes_size = db.hu_Shoes_Sizes.Find(id);
            if (hu_shoes_size == null)
            {
                return HttpNotFound();
            }
            return View(hu_shoes_size);
        }

        // GET: hu_shoes_size/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: hu_shoes_size/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,code,size_name,remark,actflg,created_by,created_date,created_log,modified_date,status")] hu_shoes_size hu_shoes_size)
        {
            if (ModelState.IsValid)
            {
                db.hu_Shoes_Sizes.Add(hu_shoes_size);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hu_shoes_size);
        }

        // GET: hu_shoes_size/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hu_shoes_size hu_shoes_size = db.hu_Shoes_Sizes.Find(id);
            if (hu_shoes_size == null)
            {
                return HttpNotFound();
            }
            return View(hu_shoes_size);
        }

        // POST: hu_shoes_size/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,code,size_name,remark,actflg,created_by,created_date,created_log,modified_date,status")] hu_shoes_size hu_shoes_size)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hu_shoes_size).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hu_shoes_size);
        }

        // GET: hu_shoes_size/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hu_shoes_size hu_shoes_size = db.hu_Shoes_Sizes.Find(id);
            if (hu_shoes_size == null)
            {
                return HttpNotFound();
            }
            return View(hu_shoes_size);
        }

        // POST: hu_shoes_size/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            hu_shoes_size hu_shoes_size = db.hu_Shoes_Sizes.Find(id);
            db.hu_Shoes_Sizes.Remove(hu_shoes_size);
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
