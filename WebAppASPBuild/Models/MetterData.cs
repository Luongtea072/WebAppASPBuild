﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aueProject.Models
{
	public class MetterData
	{
		public int Id { get; set; }
		public double CurrentPower { get; set; }
		public DateTime TimeStamp { get; set; }
	}
}