using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GoMarketWebNetCoreAppMvc.Models
{
	[XmlRoot(ElementName = "PROJECTINFO")]
	public class PROJECTINFO
	{

		[XmlElement(ElementName = "PROJECTID")]
		public string PROJECTID { get; set; }

		[XmlElement(ElementName = "PROJECTNAME")]
		public string PROJECTNAME { get; set; }

		[XmlElement(ElementName = "PROJECTDESC")]
		public object PROJECTDESC { get; set; }

		[XmlElement(ElementName = "PROJECTDATE")]
		public string PROJECTDATE { get; set; }

		[XmlElement(ElementName = "PROJECTMULTIPLE")]
		public double PROJECTMULTIPLE { get; set; }
	}

}
