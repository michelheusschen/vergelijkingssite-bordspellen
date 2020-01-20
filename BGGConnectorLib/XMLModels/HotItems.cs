using System.Collections.Generic;
using System.Xml.Serialization;

namespace BGGConnectorLib.XMLModels
{
    [XmlRoot("items")]
    public class HotItems
    {
        [XmlRoot("thumbnail")]
        public class Thumbnail
        {
            [XmlAttribute(AttributeName = "value")]
            public string Value { get; set; }
        }

        [XmlRoot("name")]
        public class Name
        {
            [XmlAttribute("value")]
            public string Value { get; set; }
        }

        [XmlRoot(ElementName = "yearpublished")]
        public class YearPublished
        {
            [XmlAttribute(AttributeName = "value")]
            public string Value { get; set; }
        }

        [XmlRoot("item")]
        public class HotItem
        {
            [XmlAttribute("id")]
            public int Id { get; set; }

            [XmlAttribute("rank")]
            public int Rank { get; set; }

            [XmlElement("thumbnail")]
            public Thumbnail Thumbnail { get; set; }

            [XmlElement("name")]
            public Name Name { get; set; }

            [XmlElement("yearpublished")]
            public YearPublished YearPublished { get; set; }
        }

        [XmlElement("item")]
        public HotItem[] Items { get; set; }
    }
}
