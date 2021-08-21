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
    public class ot_other_list_typeController : Controller
    {
        private BHLDDbContext db = new BHLDDbContext();

        // GET: ot_other_list_type
        public ActionResult Index()
        {
            return View();
        }

        // GET: ot_other_list_type/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ot_other_list_type ot_other_list_type = db.ot_Other_List_Types.Find(id);
            if (ot_other_list_type == null)
            {
                return HttpNotFound();
            }
            return View(ot_other_list_type);
        }

        // GET: ot_other_list_type/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ot_other_list_type/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,code,name,remark,actfg,created_by,created_date,created_log,modified_date,status")] ot_other_list_type ot_other_list_type)
        {
            if (ModelState.IsValid)
            {
                db.ot_Other_List_Types.Add(ot_other_list_type);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ot_other_list_type);
        }

        // GET: ot_other_list_type/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ot_other_list_type ot_other_list_type = db.ot_Other_List_Types.Find(id);
            if (ot_other_list_type == null)
            {
                return HttpNotFound();
            }
            return View(ot_other_list_type);
        }

        // POST: ot_other_list_type/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,code,name,remark,actfg,created_by,created_date,created_log,modified_date,status")] ot_other_list_type ot_other_list_type)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ot_other_list_type).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ot_other_list_type);
        }

        // GET: ot_other_list_type/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ot_other_list_type ot_other_list_type = db.ot_Other_List_Types.Find(id);
            if (ot_other_list_type == null)
            {
                return HttpNotFound();
            }
            return View(ot_other_list_type);
        }

        // POST: ot_other_list_type/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ot_other_list_type ot_other_list_type = db.ot_Other_List_Types.Find(id);
            db.ot_Other_List_Types.Remove(ot_other_list_type);
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
