﻿using System.IO;
using System.Net;
using System.Xml.Serialization;
using System.Collections.Generic;
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
            string url = $"hot?type={type}";
            return MakeRequest<HotItems>(url);
        }

        /// <summary>
        /// Retrieves things (physical, tangible products) by their id(s) with optional type filters.
        /// </summary>
        public static Things GetThings(IEnumerable<int> ids, IEnumerable<string> types = null)
        {
            if (types == null)
            {
                types = new string[] { };
            }
            string url = $"thing?id={string.Join(",", ids)}&type={string.Join(",", types)}";
            return MakeRequest<Things>(url);
        }

        /// <summary>
        /// Search in the database for items by name.
        /// </summary>
        public static SearchItems GetSearchItems(string query, string type = null, bool exact = false)
        {
            string url = $"search?query={query}&type={type}&exact={(exact ? 1 : 0)}";
            return MakeRequest<SearchItems>(url);
        }
    }
}
