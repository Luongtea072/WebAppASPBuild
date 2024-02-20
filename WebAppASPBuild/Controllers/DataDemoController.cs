using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aueProject.Controllers
{
    public class DataDemoController : Controller
    {
        // GET: DataDemo
        public ActionResult Index()
        {
            int[] x = { 5, 2, 3, 4, 3, 6, 7 };
            string jsonData = JsonConvert.SerializeObject(x);
            ViewBag.Data = jsonData;
            return View();
        }
    }
}