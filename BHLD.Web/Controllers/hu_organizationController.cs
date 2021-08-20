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
    public class hu_organizationController : Controller
    {
        private BHLDDbContext db = new BHLDDbContext();

        // GET: hu_organization
        public ActionResult Index()
        {
            return View();
        }

        // GET: hu_organization/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hu_organization hu_organization = db.hu_Organizations.Find(id);
            if (hu_organization == null)
            {
                return HttpNotFound();
            }
            return View(hu_organization);
        }

        // GET: hu_organization/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: hu_organization/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,code,name_vn,parent_id,level_id,dissolve_date,foundation_date,address,org_no,remark,actfg,created_by,created_date,created_log,modified_date,status")] hu_organization hu_organization)
        {
            if (ModelState.IsValid)
            {
                db.hu_Organizations.Add(hu_organization);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hu_organization);
        }

        // GET: hu_organization/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hu_organization hu_organization = db.hu_Organizations.Find(id);
            if (hu_organization == null)
            {
                return HttpNotFound();
            }
            return View(hu_organization);
        }

        // POST: hu_organization/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,code,name_vn,parent_id,level_id,dissolve_date,foundation_date,address,org_no,remark,actfg,created_by,created_date,created_log,modified_date,status")] hu_organization hu_organization)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hu_organization).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hu_organization);
        }

        // GET: hu_organization/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hu_organization hu_organization = db.hu_Organizations.Find(id);
            if (hu_organization == null)
            {
                return HttpNotFound();
            }
            return View(hu_organization);
        }

        // POST: hu_organization/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            hu_organization hu_organization = db.hu_Organizations.Find(id);
            db.hu_Organizations.Remove(hu_organization);
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
