using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GoMarketWebNetCoreAppMvc.Models
{
	[XmlRoot(ElementName = "UNITS")]
	public class UNITS: BASE
	{
        public List<DOORS> DOORs { get; set; }
		public List<HANDLES> HANDLEs { get; set; }
		public List<PLINTHLEGS> PLINTHLEGs { get; set; }

        [XmlElement(ElementName = "UNIQUECODE")]
		public string UNIQUECODE { get; set; }

		[XmlElement(ElementName = "MODEL2")]
		public string MODEL2 { get; set; }

		[XmlElement(ElementName = "MODELGROUP")]
		public string MODELGROUP { get; set; }

		[XmlElement(ElementName = "MODELGROUP2")]
		public string MODELGROUP2 { get; set; }

		[XmlElement(ElementName = "KITCHENDMODEL")]
		public string KITCHENDMODEL { get; set; }

		[XmlElement(ElementName = "MATERIAL")]
		public string MATERIAL { get; set; }

		[XmlElement(ElementName = "MATERIAL_CODE")]
		public string MATERIALCODE { get; set; }

		[XmlElement(ElementName = "DMATERIAL")]
		public string DMATERIAL { get; set; }

		[XmlElement(ElementName = "DMATERIAL_CODE")]
		public string DMATERIALCODE { get; set; }

		[XmlElement(ElementName = "DMATERIAL2")]
		public string DMATERIAL2 { get; set; }

		[XmlElement(ElementName = "DMATERIAL2_CODE")]
		public string DMATERIAL2CODE { get; set; }

		[XmlElement(ElementName = "DMOD_DMAT")]
		public string DMODDMAT { get; set; }

		[XmlElement(ElementName = "DMOD2_DMAT2")]
		public string DMOD2DMAT2 { get; set; }

		[XmlElement(ElementName = "HANDLEMODEL")]
		public string HANDLEMODEL { get; set; }

		[XmlElement(ElementName = "HANDLECOUNT")]
		public string HANDLECOUNT { get; set; }

		[XmlElement(ElementName = "DGLASSMATERIAL")]
		public string DGLASSMATERIAL { get; set; }

		[XmlElement(ElementName = "DGLASSMATERIAL_CODE")]
		public string DGLASSMATERIALCODE { get; set; }

		[XmlElement(ElementName = "DGLASSMATERIAL2")]
		public string DGLASSMATERIAL2 { get; set; }

		[XmlElement(ElementName = "DGLASSMATERIAL2_CODE")]
		public string DGLASSMATERIAL2CODE { get; set; }

		[XmlElement(ElementName = "DIRECTION")]
		public string DIRECTION { get; set; }

		[XmlElement(ElementName = "DOORDIRECTIONS")]
		public string DOORDIRECTIONS { get; set; }

		[XmlElement(ElementName = "MODULPOSE")]
		public string MODULPOSE { get; set; }

		[XmlElement(ElementName = "MODULGROUPPOSE")]
		public string MODULGROUPPOSE { get; set; }

		[XmlElement(ElementName = "H1")]
		public string H1 { get; set; }

		[XmlElement(ElementName = "W1")]
		public string W1 { get; set; }

		[XmlElement(ElementName = "D1")]
		public string D1 { get; set; }

		[XmlElement(ElementName = "D2")]
		public string D2 { get; set; }

		[XmlElement(ElementName = "UNITAREAM2")]
		public string UNITAREAM2 { get; set; }

		[XmlElement(ElementName = "NOTCHTYPE")]
		public string NOTCHTYPE { get; set; }

		[XmlElement(ElementName = "X")]
		public string X { get; set; }

		[XmlElement(ElementName = "Y")]
		public string Y { get; set; }

		[XmlElement(ElementName = "Z")]
		public string Z { get; set; }

		[XmlElement(ElementName = "SIDES")]
		public string SIDES { get; set; }

		[XmlElement(ElementName = "SIDESMAT")]
		public string SIDESMAT { get; set; }

		[XmlElement(ElementName = "SIDESMAT_CODE")]
		public string SIDESMATCODE { get; set; }


		[XmlElement(ElementName = "ANGLE")]
		public string ANGLE { get; set; }

		[XmlElement(ElementName = "INSERTIONPOINT")]
		public string INSERTIONPOINT { get; set; }

		[XmlElement(ElementName = "UNITNOTE")]
		public string UNITNOTE { get; set; }
	}

	

}
