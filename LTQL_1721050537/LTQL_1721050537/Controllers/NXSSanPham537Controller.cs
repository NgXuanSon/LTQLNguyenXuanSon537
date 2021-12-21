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
    public class NXSSanPham537Controller : Controller
    {
        private LTQLDbContext db = new LTQLDbContext();

        // GET: NXSSanPham537
        public ActionResult Index()
        {
            var nXSSanPham537s = db.NXSSanPham537s.Include(n => n.NhaCungCap537s);
            return View(nXSSanPham537s.ToList());
        }

        // GET: NXSSanPham537/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NXSSanPham537 nXSSanPham537 = db.NXSSanPham537s.Find(id);
            if (nXSSanPham537 == null)
            {
                return HttpNotFound();
            }
            return View(nXSSanPham537);
        }

        // GET: NXSSanPham537/Create
        public ActionResult Create()
        {
            ViewBag.MaNhaCungCap = new SelectList(db.NhaCungCap537s, "MaNhaCungCap", "TenNhaCungCap");
            return View();
        }

        // POST: NXSSanPham537/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaSanPham,TenSanPham,MaNhaCungCap")] NXSSanPham537 nXSSanPham537)
        {
            if (ModelState.IsValid)
            {
                db.NXSSanPham537s.Add(nXSSanPham537);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaNhaCungCap = new SelectList(db.NhaCungCap537s, "MaNhaCungCap", "TenNhaCungCap", nXSSanPham537.MaNhaCungCap);
            return View(nXSSanPham537);
        }

        // GET: NXSSanPham537/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NXSSanPham537 nXSSanPham537 = db.NXSSanPham537s.Find(id);
            if (nXSSanPham537 == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaNhaCungCap = new SelectList(db.NhaCungCap537s, "MaNhaCungCap", "TenNhaCungCap", nXSSanPham537.MaNhaCungCap);
            return View(nXSSanPham537);
        }

        // POST: NXSSanPham537/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaSanPham,TenSanPham,MaNhaCungCap")] NXSSanPham537 nXSSanPham537)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nXSSanPham537).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaNhaCungCap = new SelectList(db.NhaCungCap537s, "MaNhaCungCap", "TenNhaCungCap", nXSSanPham537.MaNhaCungCap);
            return View(nXSSanPham537);
        }

        // GET: NXSSanPham537/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NXSSanPham537 nXSSanPham537 = db.NXSSanPham537s.Find(id);
            if (nXSSanPham537 == null)
            {
                return HttpNotFound();
            }
            return View(nXSSanPham537);
        }

        // POST: NXSSanPham537/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            NXSSanPham537 nXSSanPham537 = db.NXSSanPham537s.Find(id);
            db.NXSSanPham537s.Remove(nXSSanPham537);
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
