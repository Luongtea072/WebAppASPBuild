using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Globalization;
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
            float[] ConsumptionData = new float[25];
			DateTime localDate = DateTime.Now;
			string[] dateTimeString = localDate.GetDateTimeFormats();
			
			string[] dayHours =
            { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "05:00", "07:00", "08:00", "09:00", "10:00",
            "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00",
           "21:00", "22:00", "23:00" };
			for (int i = 0; i < dayHours.Length; i++)
			{
				//expectedDayOutput = "2023-02-28"; // Replace with your actual date
				string expectedDayOutput = dateTimeString[24].Remove(10, 10).ToString();
				//expectedDayOutput = "2024-02-29";
				string dateTimeParameter = "2024-03-01" + " " + dayHours[i];

				DateTime.TryParseExact(dateTimeParameter, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDateTime);

				var query = "SELECT TOP 1 * FROM METTER_DATA WHERE TimeLog > @TimeLog;";
				var parameters = new SqlParameter("@TimeLog", System.Data.SqlDbType.DateTime)
				{
					Value = DateTime.Parse($"{dateTimeParameter}")
				};

				var ConsumptionQuery = db.Database.SqlQuery<METTER_DATA>(query, parameters).ToList();
				if (ConsumptionQuery.Count > 0)
				{
					ConsumptionData[i] = (float)ConsumptionQuery[0].Consumpiton;
				}
			}

			var x = db.METTER_DATA.ToList();
			string jsonData = JsonConvert.SerializeObject(x);
			string jsonConsumption = JsonConvert.SerializeObject(ConsumptionData);
			ViewBag.Data = jsonData;
            ViewBag.ConsumptionPerHour = jsonConsumption;
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
