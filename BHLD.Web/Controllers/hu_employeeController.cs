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
    public class hu_employeeController : Controller
    {
        private BHLDDbContext db = new BHLDDbContext();

        // GET: hu_employee
        public ActionResult Index()
        {
            return View();
        }

        // GET: hu_employee/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hu_employee hu_employee = db.hu_Employees.Find(id);
            if (hu_employee == null)
            {
                return HttpNotFound();
            }
            return View(hu_employee);
        }

        // GET: hu_employee/Create
        public ActionResult Create()
        {
            ViewBag.org_id = new SelectList(db.hu_Organizations, "id", "code");
            ViewBag.title_id = new SelectList(db.hu_Titles, "id", "code");
            return View();
        }

        // POST: hu_employee/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,employee_code,fullname,org_id,title_id,join_date,actfg,created_by,created_date,created_log,modified_date,status")] hu_employee hu_employee)
        {
            if (ModelState.IsValid)
            {
                db.hu_Employees.Add(hu_employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.org_id = new SelectList(db.hu_Organizations, "id", "code", hu_employee.org_id);
            ViewBag.title_id = new SelectList(db.hu_Titles, "id", "code", hu_employee.title_id);
            return View(hu_employee);
        }

        // GET: hu_employee/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hu_employee hu_employee = db.hu_Employees.Find(id);
            if (hu_employee == null)
            {
                return HttpNotFound();
            }
            ViewBag.org_id = new SelectList(db.hu_Organizations, "id", "code", hu_employee.org_id);
            ViewBag.title_id = new SelectList(db.hu_Titles, "id", "code", hu_employee.title_id);
            return View(hu_employee);
        }

        // POST: hu_employee/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,employee_code,fullname,org_id,title_id,join_date,actfg,created_by,created_date,created_log,modified_date,status")] hu_employee hu_employee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hu_employee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.org_id = new SelectList(db.hu_Organizations, "id", "code", hu_employee.org_id);
            ViewBag.title_id = new SelectList(db.hu_Titles, "id", "code", hu_employee.title_id);
            return View(hu_employee);
        }

        // GET: hu_employee/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hu_employee hu_employee = db.hu_Employees.Find(id);
            if (hu_employee == null)
            {
                return HttpNotFound();
            }
            return View(hu_employee);
        }

        // POST: hu_employee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            hu_employee hu_employee = db.hu_Employees.Find(id);
            db.hu_Employees.Remove(hu_employee);
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
