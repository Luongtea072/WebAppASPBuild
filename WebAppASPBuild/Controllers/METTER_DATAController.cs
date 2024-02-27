using aueProject.Models;
using System.Linq;
using System.Web.Mvc;

namespace aueProject.Controllers
{
	public class METTER_DATAController : Controller
    {
        private Entities db = new Entities();

        // GET: METTER_DATA
        public ActionResult Index(DataQuery dtq)
        {
            var query = (string)Session["SQL"];
            var StartDate = (string)Session["StartDate"];
            var EndDate = (string)Session["EndDate"];
            ViewBag.StartDate = StartDate;
            ViewBag.EndDate = EndDate;
			return  View(db.METTER_DATA.SqlQuery(query).ToList());
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
