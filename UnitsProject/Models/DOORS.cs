using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GoMarketWebNetCoreAppMvc.Models
{
	[XmlRoot(ElementName = "DOORS")]
	public class DOORS: BASE
	{
        public bool HasParent { get; set; }

        [XmlElement(ElementName = "TYPE")]
		public string TYPE { get; set; }

		[XmlElement(ElementName = "COSTTYPE")]
		public string COSTTYPE { get; set; }

		[XmlElement(ElementName = "MODELGROUP")]
		public string MODELGROUP { get; set; }

		[XmlElement(ElementName = "MATERIAL")]
		public string MATERIAL { get; set; }

		[XmlElement(ElementName = "MATERIAL_CODE")]
		public string MATERIALCODE { get; set; }

		[XmlElement(ElementName = "GLASSMATERIAL")]
		public string GLASSMATERIAL { get; set; }

		[XmlElement(ElementName = "GLASSMATERIAL_CODE")]
		public string GLASSMATERIALCODE { get; set; }

		[XmlElement(ElementName = "DIRECTION")]
		public string DIRECTION { get; set; }

		[XmlElement(ElementName = "OPENDIRECTION")]
		public string OPENDIRECTION { get; set; }

		[XmlElement(ElementName = "MODULPOSE")]
		public string MODULPOSE { get; set; }

		[XmlElement(ElementName = "BRAND")]
		public string BRAND { get; set; }

		[XmlElement(ElementName = "H")]
		public string H { get; set; }

		[XmlElement(ElementName = "W")]
		public string W { get; set; }

		[XmlElement(ElementName = "M2")]
		public string M2 { get; set; }

		[XmlElement(ElementName = "MATROTA")]
		public string MATROTA { get; set; }

	}
}
