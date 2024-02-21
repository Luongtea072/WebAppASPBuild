using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using aueProject;
using Newtonsoft.Json;

namespace aueProject.Controllers
{
    public class HomeController : Controller
    {
        private Entities db = new Entities();

        // GET: Home
        public ActionResult Index()
        {

			var x = db.METTER_DATA.ToList();
			string jsonData = JsonConvert.SerializeObject(x);
			ViewBag.Data = jsonData;

			return View(db.METTER_DATA.ToList());
        }

        // GET: Home/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            METTER_DATA mETTER_DATA = db.METTER_DATA.Find(id);
            if (mETTER_DATA == null)
            {
                return HttpNotFound();
            }
            return View(mETTER_DATA);
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,U12,U23,U31,I1,I2,I3,P1,P2,P3,FREQUENCY,AVolt,ACurrent,Consumpiton,TimeLog")] METTER_DATA mETTER_DATA)
        {
            if (ModelState.IsValid)
            {
                db.METTER_DATA.Add(mETTER_DATA);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mETTER_DATA);
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            METTER_DATA mETTER_DATA = db.METTER_DATA.Find(id);
            if (mETTER_DATA == null)
            {
                return HttpNotFound();
            }
            return View(mETTER_DATA);
        }

        // POST: Home/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,U12,U23,U31,I1,I2,I3,P1,P2,P3,FREQUENCY,AVolt,ACurrent,Consumpiton,TimeLog")] METTER_DATA mETTER_DATA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mETTER_DATA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mETTER_DATA);
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            METTER_DATA mETTER_DATA = db.METTER_DATA.Find(id);
            if (mETTER_DATA == null)
            {
                return HttpNotFound();
            }
            return View(mETTER_DATA);
        }

        // POST: Home/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            METTER_DATA mETTER_DATA = db.METTER_DATA.Find(id);
            db.METTER_DATA.Remove(mETTER_DATA);
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
