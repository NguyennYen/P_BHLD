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
    public class hu_employee_cvController : Controller
    {
        private BHLDDbContext db = new BHLDDbContext();

        // GET: hu_employee_cv
        public ActionResult Index()
        {
            
            return View();
        }

        // GET: hu_employee_cv/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hu_employee_cv hu_employee_cv = db.hu_Employee_Cvs.Find(id);
            if (hu_employee_cv == null)
            {
                return HttpNotFound();
            }
            return View(hu_employee_cv);
        }

        // GET: hu_employee_cv/Create
        public ActionResult Create()
        {
            ViewBag.employee_id = new SelectList(db.hu_Employees, "id", "fullname");
            return View();
        }

        // POST: hu_employee_cv/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,employee_id,gender,birthdate,id_no,id_date,id_place,per_address,per_nation,per_province,per_district,per_ward,nav_address,nav_nation,nav_province,nav_district,nav_ward,email,created_by,created_date,created_log,modified_date,status")] hu_employee_cv hu_employee_cv)
        {
            if (ModelState.IsValid)
            {
                db.hu_Employee_Cvs.Add(hu_employee_cv);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.employee_id = new SelectList(db.hu_Employees, "id", "fullname", hu_employee_cv.employee_id);
            return View(hu_employee_cv);
        }

        // GET: hu_employee_cv/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hu_employee_cv hu_employee_cv = db.hu_Employee_Cvs.Find(id);
            if (hu_employee_cv == null)
            {
                return HttpNotFound();
            }
            ViewBag.employee_id = new SelectList(db.hu_Employees, "id", "fullname", hu_employee_cv.employee_id);
            return View(hu_employee_cv);
        }

        // POST: hu_employee_cv/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,employee_id,gender,birthdate,id_no,id_date,id_place,per_address,per_nation,per_province,per_district,per_ward,nav_address,nav_nation,nav_province,nav_district,nav_ward,email,created_by,created_date,created_log,modified_date,status")] hu_employee_cv hu_employee_cv)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hu_employee_cv).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.employee_id = new SelectList(db.hu_Employees, "id", "fullname", hu_employee_cv.employee_id);
            return View(hu_employee_cv);
        }

        // GET: hu_employee_cv/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hu_employee_cv hu_employee_cv = db.hu_Employee_Cvs.Find(id);
            if (hu_employee_cv == null)
            {
                return HttpNotFound();
            }
            return View(hu_employee_cv);
        }

        // POST: hu_employee_cv/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            hu_employee_cv hu_employee_cv = db.hu_Employee_Cvs.Find(id);
            db.hu_Employee_Cvs.Remove(hu_employee_cv);
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
