using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using aueProject.Models;
namespace aueProject.DAL
{
	public class MetterDataInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<MetterDataContext>
	{
		protected override void Seed(MetterDataContext context)
		{
			var datas = new List<MetterData>
			{
				new MetterData { CurrentPower = 0.5333, TimeStamp = DateTime.Now },
				new MetterData { CurrentPower = 0.4333, TimeStamp = DateTime.Now },
				new MetterData { CurrentPower = 0.3333, TimeStamp = DateTime.Now },
				new MetterData { CurrentPower = 0.2333, TimeStamp = DateTime.Now },
				new MetterData { CurrentPower = 0.5233, TimeStamp = DateTime.Now },
				new MetterData { CurrentPower = 0.5133, TimeStamp = DateTime.Now },
				new MetterData { CurrentPower = 0.4833, TimeStamp = DateTime.Now },
				new MetterData { CurrentPower = 0.3457, TimeStamp = DateTime.Now }
			};
			datas.ForEach(s => context.Metter.Add(s));
			context.SaveChanges();
		}
	}
}