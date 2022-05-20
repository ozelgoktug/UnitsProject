using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GoMarketWebNetCoreAppMvc.Models
{
	[XmlRoot(ElementName = "PROJECT")]
	public class PROJECT
	{
		public UNITS? TheMismatchedComponents { get; set; } 

		[XmlElement(ElementName = "UNITS")]
		public List<UNITS> UNITS { get; set; }

		[XmlElement(ElementName = "DOORS")]
		public List<DOORS> DOORS { get; set; }

		[XmlElement(ElementName = "HANDLES")]
		public List<HANDLES> HANDLES { get; set; }

		[XmlElement(ElementName = "PLINTHLEGS")]
		public List<PLINTHLEGS> PLINTHLEGS { get; set; }

		[XmlElement(ElementName = "PROJECTINFO")]
		public PROJECTINFO PROJECTINFO { get; set; }
	}
}
