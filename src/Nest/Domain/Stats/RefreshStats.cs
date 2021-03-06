﻿using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Nest
{
	[JsonObject]
	public class FlushStats
	{
	
		[JsonProperty(PropertyName = "total")]
		public long Total { get; set; }
		[JsonProperty(PropertyName = "total_time")]
		public string TotalTime { get; set; }
		[JsonProperty(PropertyName = "total_time_in_millis")]
		public double TotalTimeInMilliseconds { get; set; }

	}
}
