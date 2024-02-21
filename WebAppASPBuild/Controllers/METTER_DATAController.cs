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
    public class METTER_DATAController : Controller
    {
        private Entities db = new Entities();

        // GET: METTER_DATA
        public ActionResult Index()
        {

			return View(db.METTER_DATA.ToList());
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
