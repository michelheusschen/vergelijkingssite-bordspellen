using System.Xml.Serialization;

namespace BGGConnectorLib.XMLModels
{
    [XmlRoot("items")]
    public class SearchItems
    {
        [XmlRoot("name")]
        public class Name
        {
            [XmlAttribute("type")]
            public string Type { get; set; }

            [XmlAttribute("value")]
            public string Value { get; set; }
        }

        [XmlRoot("yearpublished")]
        public class YearPublished
        {
            [XmlAttribute("value")]
            public int Value { get; set; }
        }

        [XmlRoot("item")]
        public class SearchItem
        {
            [XmlAttribute("id")]
            public int Id { get; set; }

            [XmlAttribute("type")]
            public string Type { get; set; }

            [XmlElement("name")]
            public Name Name { get; set; }

            [XmlElement("yearpublished")]
            public YearPublished YearPublished { get; set; }
        }

        [XmlAttribute("total")]
        public int Total { get; set; }

        [XmlElement("item")]
        public SearchItem[] Items { get; set; }
    }
}