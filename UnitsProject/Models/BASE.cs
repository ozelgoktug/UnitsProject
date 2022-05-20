using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GoMarketWebNetCoreAppMvc.Models
{
    public class BASE
    {

        [XmlElement(ElementName = "GROUP")]
        public string GROUP { get; set; }

        [XmlElement(ElementName = "CODE")]
        public string CODE { get; set; }

        [XmlElement(ElementName = "MODEL")]
        public string MODEL { get; set; }

        [XmlElement(ElementName = "MODUL")] //Tüm komponentleri birbirine bağlayan unique bir id'dir
        public string MODUL { get; set; }

        [XmlElement(ElementName = "QUANTITY")]
        public string QUANTITY { get; set; }

    }
}
