using System.Linq;
using System.Web.Mvc;

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
