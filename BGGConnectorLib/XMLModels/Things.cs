using System.Xml.Serialization;

namespace BGGConnectorLib.XMLModels
{
    [XmlRoot("items")]
    public class Things
    {
        [XmlRoot("name")]
        public class Name
        {
            [XmlAttribute("type")]
            public string Type { get; set; }

            [XmlAttribute("sortindex")]
            public int SortIndex { get; set; }

            [XmlAttribute("value")]
            public string Value { get; set; }
        }

        [XmlRoot("yearpublished")]
        public class YearPublished
        {
            [XmlAttribute("value")]
            public int Value { get; set; }
        }

        [XmlRoot("minplayers")]
        public class MinPlayers
        {
            [XmlAttribute("value")]
            public int Value { get; set; }
        }

        [XmlRoot("maxplayers")]
        public class MaxPlayers
        {
            [XmlAttribute("value")]
            public int Value { get; set; }
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
        public class PlayingTime
        {
            [XmlAttribute("value")]
            public int Value { get; set; }
        }

        [XmlRoot("minplaytime")]
        public class MinPlaytime
        {
            [XmlAttribute("value")]
            public int Value { get; set; }
        }

        [XmlRoot("maxplaytime")]
        public class MaxPlaytime
        {
            [XmlAttribute("value")]
            public int Value { get; set; }
        }

        [XmlRoot("minage")]
        public class MinAge
        {
            [XmlAttribute("value")]
            public int Value { get; set; }
        }

        [XmlRoot("link")]
        public class Link
        {
            [XmlAttribute("type")]
            public string Type { get; set; }

            [XmlAttribute("id")]
            public string Id { get; set; }

            [XmlAttribute("value")]
            public string Value { get; set; }
        }

        [XmlRoot("item")]
        public class Thing
        {
            [XmlAttribute("id")]
            public int Id { get; set; }

            [XmlAttribute("type")]
            public string Type { get; set; }

            [XmlElement("thumbnail")]
            public string Thumbnail { get; set; }

            [XmlElement("image")]
            public string Image { get; set; }

            [XmlElement("name")]
            public Name[] Names { get; set; }

            [XmlElement("description")]
            public string Description { get; set; }

            [XmlElement("yearpublished")]
            public YearPublished YearPublished { get; set; }

            [XmlElement("minplayers")]
            public MinPlayers MinPlayers { get; set; }

            [XmlElement("maxplayers")]
            public MaxPlayers MaxPlayers { get; set; }

            [XmlElement("playingtime")]
            public PlayingTime PlayingTime { get; set; }

            [XmlElement("minplaytime")]
            public MinPlaytime MinPlaytime { get; set; }

            [XmlElement("maxplaytime")]
            public MaxPlaytime MaxPlaytime { get; set; }

            [XmlElement("minage")]
            public MinAge MinAge { get; set; }

            [XmlElement("poll")]
            public Poll[] Polls { get; set; }

            [XmlElement("link")]
            public Link[] Links { get; set; }
        }

        [XmlElement("item")]
        public Thing[] Items { get; set; }
    }
}


