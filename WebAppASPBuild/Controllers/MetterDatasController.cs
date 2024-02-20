using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using aueProject.DAL;
using aueProject.Models;

namespace aueProject.Controllers
{
	public class MetterDatasController : Controller
    {
        private MetterDataContext db = new MetterDataContext();

        // GET: MetterDatas
        public ActionResult Index()
        {
            return View(db.Metter.ToList());
        }

        // GET: MetterDatas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MetterData metterData = db.Metter.Find(id);
            if (metterData == null)
            {
                return HttpNotFound();
            }
            return View(metterData);
        }

        // GET: MetterDatas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MetterDatas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CurrentPower,TimeStamp")] MetterData metterData)
        {
            if (ModelState.IsValid)
            {
                db.Metter.Add(metterData);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(metterData);
        }

        // GET: MetterDatas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MetterData metterData = db.Metter.Find(id);
            if (metterData == null)
            {
                return HttpNotFound();
            }
            return View(metterData);
        }

        // POST: MetterDatas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CurrentPower,TimeStamp")] MetterData metterData)
        {
            if (ModelState.IsValid)
            {
                db.Entry(metterData).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(metterData);
        }

        // GET: MetterDatas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MetterData metterData = db.Metter.Find(id);
            if (metterData == null)
            {
                return HttpNotFound();
            }
            return View(metterData);
        }

        // POST: MetterDatas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MetterData metterData = db.Metter.Find(id);
            db.Metter.Remove(metterData);
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
