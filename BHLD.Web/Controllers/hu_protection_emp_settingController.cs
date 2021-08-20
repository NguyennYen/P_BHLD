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
    public class hu_protection_emp_settingController : Controller
    {
        private BHLDDbContext db = new BHLDDbContext();

        // GET: hu_protection_emp_setting
        public ActionResult Index()
        {
            return View();
        }

        // GET: hu_protection_emp_setting/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hu_protection_emp_setting hu_protection_emp_setting = db.hu_Protection_Emp_Settings.Find(id);
            if (hu_protection_emp_setting == null)
            {
                return HttpNotFound();
            }
            return View(hu_protection_emp_setting);
        }

        // GET: hu_protection_emp_setting/Create
        public ActionResult Create()
        {
            ViewBag.id_emp = new SelectList(db.hu_Protection_Emps, "id", "created_by");
            ViewBag.bhld_list_id = new SelectList(db.hu_Titles, "id", "code");
            return View();
        }

        // POST: hu_protection_emp_setting/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,id_emp,bhld_list_id,amount,created_by,created_date,created_log,modified_date,status")] hu_protection_emp_setting hu_protection_emp_setting)
        {
            if (ModelState.IsValid)
            {
                db.hu_Protection_Emp_Settings.Add(hu_protection_emp_setting);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_emp = new SelectList(db.hu_Protection_Emps, "id", "created_by", hu_protection_emp_setting.id_emp);
            ViewBag.bhld_list_id = new SelectList(db.hu_Titles, "id", "code", hu_protection_emp_setting.bhld_list_id);
            return View(hu_protection_emp_setting);
        }

        // GET: hu_protection_emp_setting/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hu_protection_emp_setting hu_protection_emp_setting = db.hu_Protection_Emp_Settings.Find(id);
            if (hu_protection_emp_setting == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_emp = new SelectList(db.hu_Protection_Emps, "id", "created_by", hu_protection_emp_setting.id_emp);
            ViewBag.bhld_list_id = new SelectList(db.hu_Titles, "id", "code", hu_protection_emp_setting.bhld_list_id);
            return View(hu_protection_emp_setting);
        }

        // POST: hu_protection_emp_setting/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,id_emp,bhld_list_id,amount,created_by,created_date,created_log,modified_date,status")] hu_protection_emp_setting hu_protection_emp_setting)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hu_protection_emp_setting).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_emp = new SelectList(db.hu_Protection_Emps, "id", "created_by", hu_protection_emp_setting.id_emp);
            ViewBag.bhld_list_id = new SelectList(db.hu_Titles, "id", "code", hu_protection_emp_setting.bhld_list_id);
            return View(hu_protection_emp_setting);
        }

        // GET: hu_protection_emp_setting/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hu_protection_emp_setting hu_protection_emp_setting = db.hu_Protection_Emp_Settings.Find(id);
            if (hu_protection_emp_setting == null)
            {
                return HttpNotFound();
            }
            return View(hu_protection_emp_setting);
        }

        // POST: hu_protection_emp_setting/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            hu_protection_emp_setting hu_protection_emp_setting = db.hu_Protection_Emp_Settings.Find(id);
            db.hu_Protection_Emp_Settings.Remove(hu_protection_emp_setting);
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
