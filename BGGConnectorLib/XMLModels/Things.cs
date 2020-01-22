using System.Collections.Generic;
using System.Xml.Serialization;

namespace BGGConnectorLib.XMLModels
{
    public class Things
    {
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
                [XmlAttribute("playingtime")]
                public Playingtime Playingtime { get; set; }

                [XmlAttribute("minplaytime")]
                public Minplaytime Minplaytime { get; set; }

                [XmlAttribute("maxplaytime")]
                public Maxplaytime Maxplaytime { get; set; }

                [XmlAttribute("minage")]
                public Minage Minage { get; set; }

                [XmlAttribute("link")]
                public Link Link { get; set; }


            }

            [XmlElement("item")]
            public Thing[] Items { get; set; }

            [XmlElement("links")]
            public Link[] Links { get; set; }
        }
    }
}
