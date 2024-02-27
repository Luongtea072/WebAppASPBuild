using aueProject.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aueProject.Controllers
{
    public class DataQueryController : Controller
    {
        // GET: DataQuery
        public ActionResult Index()
        {
			return View();
        }
        [HttpPost]
        public ActionResult Index(DataQuery query)
        {
            Session["SQL"] = query.QueryStatement;
            Session["StartDate"] = query.StartDateVerified;
            Session["EndDate"] = query.EndDateVerified;
            return View(query);
        }
	}
}