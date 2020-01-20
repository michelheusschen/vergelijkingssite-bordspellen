using BGGConnectorLib.XMLModels;
using System.IO;
using System.Net;
using System;
using System.Xml.Serialization;

namespace BGGConnectorLib
{
    public static class BGGConnector
    {
        private const string BASE_ADDRESS = "https://www.boardgamegeek.com/xmlapi2/";

        /// <summary>
        /// Retrieves the list of most active items.
        /// </summary>
        public static HotItems GetHotItems(string type = null)
        {
            using (WebClient client = new WebClient() { BaseAddress = BASE_ADDRESS })
            using (Stream result = client.OpenRead($"hot?tye={type}"))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(HotItems));
                return xmlSerializer.Deserialize(result) as HotItems;
            }
        }
    }
}
