using System;
using System.ComponentModel;

namespace TVShowApp.Models
{
	public class Show
	{

		public int Id { get; set; }
        [Description("Demonstrates DisplayNameAttribute.")]
        [DisplayName("Show Title")]
		public string ShowTitle { get; set; }
		public string ShowDescription { get; set; }

	}
}

