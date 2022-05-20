using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GoMarketWebNetCoreAppMvc.Models
{
	[XmlRoot(ElementName = "PLINTHLEGS")]
	public class PLINTHLEGS: BASE
	{
		public bool HasParent { get; set; }
		[XmlElement(ElementName = "H")]
		public string H { get; set; }

	}

}
