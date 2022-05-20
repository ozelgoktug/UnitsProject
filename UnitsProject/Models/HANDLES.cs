using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GoMarketWebNetCoreAppMvc.Models
{
	[XmlRoot(ElementName = "HANDLES")]
	public class HANDLES: BASE
	{
		public bool HasParent { get; set; }
	}
}
