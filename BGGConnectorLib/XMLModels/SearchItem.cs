using System.Collections.Generic;
using System.Xml.Serialization;

namespace BGGConnectorLib.XMLModels
{
    [XmlRoot("boardgames")]
    public class SearchItems
    {
        public class ObjectId
        {
            [XmlAttribute(AttributeName = "value")]
            public int Value { get; set; }
        }

        [XmlRoot("Name")]
        public class Name
        {
            [XmlAttribute(AttributeName = "value")]
            public string Value { get; set; }
        }

        [XmlRoot("YearPublished")]
        public class YearPublished
        {
            [XmlAttribute(AttributeName = "value")]
            public string Value { get; set; }
        }
        [XmlRoot("boardgame")]
        public class SearchItem
        {
            [XmlAttribute("objectid")]
            public int objectid { get; set; }
            [XmlElement(ElementName = "name")]
            public Name name { get; set; }
            [XmlElement(ElementName = "YearPublished")]
            public YearPublished YearPublished { get; set; }


        }
        [XmlElement("boardgame")]
        public SearchItem[] Boardgames { get; set; }

    }

}