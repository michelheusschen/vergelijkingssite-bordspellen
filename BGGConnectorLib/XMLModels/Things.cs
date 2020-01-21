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
        }
    }
}
