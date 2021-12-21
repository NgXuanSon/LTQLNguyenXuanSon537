using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LTQL_1721050537.Models;

namespace LTQL_1721050537.Controllers
{
    public class NhaCungCap537Controller : Controller
    {
        private LTQLDbContext db = new LTQLDbContext();

        // GET: NhaCungCap537
        public ActionResult Index()
        {
            return View(db.NhaCungCap537s.ToList());
        }

        // GET: NhaCungCap537/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhaCungCap537 nhaCungCap537 = db.NhaCungCap537s.Find(id);
            if (nhaCungCap537 == null)
            {
                return HttpNotFound();
            }
            return View(nhaCungCap537);
        }

        // GET: NhaCungCap537/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NhaCungCap537/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaNhaCungCap,TenNhaCungCap")] NhaCungCap537 nhaCungCap537)
        {
            if (ModelState.IsValid)
            {
                db.NhaCungCap537s.Add(nhaCungCap537);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nhaCungCap537);
        }

        // GET: NhaCungCap537/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhaCungCap537 nhaCungCap537 = db.NhaCungCap537s.Find(id);
            if (nhaCungCap537 == null)
            {
                return HttpNotFound();
            }
            return View(nhaCungCap537);
        }

        // POST: NhaCungCap537/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaNhaCungCap,TenNhaCungCap")] NhaCungCap537 nhaCungCap537)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nhaCungCap537).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nhaCungCap537);
        }

        // GET: NhaCungCap537/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhaCungCap537 nhaCungCap537 = db.NhaCungCap537s.Find(id);
            if (nhaCungCap537 == null)
            {
                return HttpNotFound();
            }
            return View(nhaCungCap537);
        }

        // POST: NhaCungCap537/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NhaCungCap537 nhaCungCap537 = db.NhaCungCap537s.Find(id);
            db.NhaCungCap537s.Remove(nhaCungCap537);
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
