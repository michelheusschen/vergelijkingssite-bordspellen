using System;
using System.IO;
using System.Net;
using System.Xml.Serialization;
using System.Collections;
using BGGConnectorLib.XMLModels;

namespace BGGConnectorLib
{
    public static class BGGConnector
    {
        private const string BASE_ADDRESS = "https://www.boardgamegeek.com/xmlapi2/";

        /// <summary>
        /// Generic function to make HTTP requests to the API.
        /// </summary>
        private static Model MakeRequest<Model>(string url) where Model : class
        {
            using (WebClient client = new WebClient() { BaseAddress = BASE_ADDRESS })
            using (Stream result = client.OpenRead(url))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Model));
                return xmlSerializer.Deserialize(result) as Model;
            }
        }

        /// <summary>
        /// Retrieves the list of most active items.
        /// </summary>
        public static HotItems GetHotItems(string type = null)
        {
            string url = $"hot?tye={type}";
            return MakeRequest<HotItems>(url);
        }

        /// <summary>
        /// Gets a list of things (physical, tangible products).
        /// </summary>
        public static Things GetThings(int[] ids)
        {
            string url = $"thing?tye={string.Join(",", ids)}";
            return MakeRequest<Things>(url);
        }
    }
}
