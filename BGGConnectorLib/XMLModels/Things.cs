using System.Collections.Generic;
using System.Xml.Serialization;

namespace BGGConnectorLib.XMLModels
{
    [XmlRoot("items")]
    public class Things
    {
        [XmlRoot("name")]
        public class Name
        {
            [XmlAttribute("value")]
            public string Value { get; set; }
        }

        [XmlRoot("yearpublished")]
        public class YearPublished
        {
            [XmlAttribute("value")]
            public string Value { get; set; }
        }
        [XmlRoot("minplayer")]
        public class MinPlayers
        {
            [XmlAttribute("value")]
            public string Value { get; set; }
        }
        [XmlRoot("maxplayers")]
        public class MaxPlayers
        {
            [XmlAttribute("value")]
            public string Value { get; set; }
        }
        public class Poll
        {
            public class Result
            {
                [XmlAttribute("value")]
                public string Value { get; set; }

                [XmlAttribute("numvotes")]
                public int NumVotes { get; set; }
            }

            public class ResultsElement
            {
                [XmlAttribute("numplayers")]
                public string NumPlayers { get; set; }

                [XmlElement("result")]
                public Result[] Results { get; set; }
            }

            [XmlAttribute("name")]
            public string Name { get; set; }

            [XmlAttribute("title")]
            public string Title { get; set; }

            [XmlAttribute("totalvotes")]
            public int TotalVotes { get; set; }

            [XmlElement("results")]
            public ResultsElement[] Results { get; set; }
         
        }

        [XmlRoot("playingtime")]
        public class Playingtime
        {
            [XmlAttribute(AttributeName = "value")]
            public string Value { get; set; }
        }

        [XmlRoot("minplaytime")]
        public class Minplaytime
        {
            [XmlAttribute(AttributeName = "value")]
            public string Value { get; set; }
        }

        [XmlRoot("maxplaytime")]
        public class Maxplaytime
        {
            [XmlAttribute(AttributeName = "value")]
            public string Value { get; set; }
        }

        [XmlRoot("minage")]
        public class Minage
        {
            [XmlAttribute(AttributeName = "value")]
            public string Value { get; set; }
        }

        [XmlRoot("link")]
        public class Link
        {
            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }

            [XmlAttribute(AttributeName = "id")]
            public string Id { get; set; }

            [XmlAttribute(AttributeName = "value")]
            public string Value { get; set; }
        }



        [XmlRoot("item")]
        public class Thing
        {
            [XmlAttribute("id")]
            public int Id { get; set; }

            [XmlElement("thumbnail")]
            public string Thumbnail { get; set; }

            [XmlElement("image")]
            public string Image { get; set; }

            [XmlElement("name")]
            public Name Name { get; set; }

            [XmlElement("description")]
            public string Description { get; set; }
            [XmlElement("yearpublished")]
            public YearPublished YearPublished { get; set; }
            [XmlElement("minplayers")]
            public MinPlayers MinPlayers { get; set; }
            [XmlElement("maxplayers")]
            public MaxPlayers MaxPlayers { get; set; }
            [XmlElement("playingtime")]
            public Playingtime Playingtime { get; set; }

            [XmlElement("minplaytime")]
            public Minplaytime Minplaytime { get; set; }

            [XmlElement("maxplaytime")]
            public Maxplaytime Maxplaytime { get; set; }

            [XmlElement("minage")]
            public Minage Minage { get; set; }

            [XmlElement("link")]
            public Link[] Link { get; set; }

        }

        [XmlElement("item")]
        public Thing[] Items { get; set; }

    }
}


