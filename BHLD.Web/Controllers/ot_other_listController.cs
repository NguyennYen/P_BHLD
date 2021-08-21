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
    public class ot_other_listController : Controller
    {
        private BHLDDbContext db = new BHLDDbContext();

        // GET: ot_other_list
        public ActionResult Index()
        {

            return View();
        }

        // GET: ot_other_list/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ot_other_list ot_other_list = db.ot_Other_Lists.Find(id);
            if (ot_other_list == null)
            {
                return HttpNotFound();
            }
            return View(ot_other_list);
        }

        // GET: ot_other_list/Create
        public ActionResult Create()
        {
            ViewBag.type_id = new SelectList(db.ot_Other_List_Types, "id", "code");
            return View();
        }

        // POST: ot_other_list/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,code,name,type_id,remark,actfg,created_by,created_date,created_log,modified_date,status")] ot_other_list ot_other_list)
        {
            if (ModelState.IsValid)
            {
                db.ot_Other_Lists.Add(ot_other_list);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.type_id = new SelectList(db.ot_Other_List_Types, "id", "code", ot_other_list.type_id);
            return View(ot_other_list);
        }

        // GET: ot_other_list/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ot_other_list ot_other_list = db.ot_Other_Lists.Find(id);
            if (ot_other_list == null)
            {
                return HttpNotFound();
            }
            ViewBag.type_id = new SelectList(db.ot_Other_List_Types, "id", "code", ot_other_list.type_id);
            return View(ot_other_list);
        }

        // POST: ot_other_list/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,code,name,type_id,remark,actfg,created_by,created_date,created_log,modified_date,status")] ot_other_list ot_other_list)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ot_other_list).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.type_id = new SelectList(db.ot_Other_List_Types, "id", "code", ot_other_list.type_id);
            return View(ot_other_list);
        }

        // GET: ot_other_list/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ot_other_list ot_other_list = db.ot_Other_Lists.Find(id);
            if (ot_other_list == null)
            {
                return HttpNotFound();
            }
            return View(ot_other_list);
        }

        // POST: ot_other_list/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ot_other_list ot_other_list = db.ot_Other_Lists.Find(id);
            db.ot_Other_Lists.Remove(ot_other_list);
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
