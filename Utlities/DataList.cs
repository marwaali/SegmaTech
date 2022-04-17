using System.Collections.Generic;
using System.Xml.Serialization;

namespace Test.Utlities
{
    [XmlRoot(ElementName = "DataList")]
    public class DataList
    {
        [XmlElement(ElementName = "Browser")]
        public string browserType { get; set; }

        [XmlElement(ElementName = "URL")]
        public string url { get; set; }

        [XmlElement(ElementName = "Game")]
        public string game { get; set; }

        [XmlElement(ElementName = "MayBreakDown")]
        public string mayValue { get; set; }

        [XmlElement(ElementName = "Column")]
        public string column { get; set; }
    }
}