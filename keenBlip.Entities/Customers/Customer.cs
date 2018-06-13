﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using keenBlip.Entities.Geographies;
using System.Linq;
using System.Web;

namespace keenBlip.Entities.Customers
{
	public class Customer
	{
		[Key]
		[Column(Order = 1)]
		public Guid CustomerId { get; set; }

		[Required]
		[MaxLength(128)]
		public string CustomerName { get; set; }

		[Required]
		[MaxLength(3)]
		public string CountryIso3 { get; set; }

		[MaxLength(3)]
		public string RegionCode { get; set; }

		public virtual Country Country { get; set; }

		public virtual Region Region { get; set; }
	}
}