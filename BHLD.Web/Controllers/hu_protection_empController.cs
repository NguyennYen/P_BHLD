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
    public class hu_protection_empController : Controller
    {
        private BHLDDbContext db = new BHLDDbContext();

        // GET: hu_protection_emp
        public ActionResult Index()
        {
            return View();
        }

        // GET: hu_protection_emp/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hu_protection_emp hu_protection_emp = db.hu_Protection_Emps.Find(id);
            if (hu_protection_emp == null)
            {
                return HttpNotFound();
            }
            return View(hu_protection_emp);
        }

        // GET: hu_protection_emp/Create
        public ActionResult Create()
        {
            ViewBag.employee_id = new SelectList(db.hu_Employees, "id", "fullname");
            return View();
        }

        // POST: hu_protection_emp/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,employee_id,created_by,created_date,created_log,modified_date,status")] hu_protection_emp hu_protection_emp)
        {
            if (ModelState.IsValid)
            {
                db.hu_Protection_Emps.Add(hu_protection_emp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.employee_id = new SelectList(db.hu_Employees, "id", "fullname", hu_protection_emp.employee_id);
            return View(hu_protection_emp);
        }

        // GET: hu_protection_emp/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hu_protection_emp hu_protection_emp = db.hu_Protection_Emps.Find(id);
            if (hu_protection_emp == null)
            {
                return HttpNotFound();
            }
            ViewBag.employee_id = new SelectList(db.hu_Employees, "id", "fullname", hu_protection_emp.employee_id);
            return View(hu_protection_emp);
        }

        // POST: hu_protection_emp/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,employee_id,created_by,created_date,created_log,modified_date,status")] hu_protection_emp hu_protection_emp)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hu_protection_emp).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.employee_id = new SelectList(db.hu_Employees, "id", "fullname", hu_protection_emp.employee_id);
            return View(hu_protection_emp);
        }

        // GET: hu_protection_emp/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hu_protection_emp hu_protection_emp = db.hu_Protection_Emps.Find(id);
            if (hu_protection_emp == null)
            {
                return HttpNotFound();
            }
            return View(hu_protection_emp);
        }

        // POST: hu_protection_emp/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            hu_protection_emp hu_protection_emp = db.hu_Protection_Emps.Find(id);
            db.hu_Protection_Emps.Remove(hu_protection_emp);
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
