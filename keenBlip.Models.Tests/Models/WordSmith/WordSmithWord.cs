using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keenBlip.Models.Models.WordSmith
{
	public class WordSmithWord
	{
		public long ID { get; set; }
		public string WordSmithThemeID { get; set; }
		public string DialyWord { get; set; }
		public string Pronounciation { get; set; }
		public string Meaning { get; set; }
		public string Etymology { get; set; }
		public string Usage { get; set; }
		public string ThoughtADay { get; set; }
		public string Notes { get; set; }
		public DateTime InputDate { get; set; }
		public DateTime UpdateDate { get; set; }
	}
}
