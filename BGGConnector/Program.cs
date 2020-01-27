using System;
using System.Collections.Generic;
using BGGConnectorLib.XMLModels;

namespace BGGConnector
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var hotItems = BGGConnectorLib.BGGConnector.GetHotItems();
                Console.WriteLine($"{hotItems.Items.Length} Hot Items");
                //PrintHotItems(hotItems);

                var things = BGGConnectorLib.BGGConnector.GetThings(new int[] { 1 });
                Console.WriteLine($"{things.Items.Length} Things");
                //PrintThings(things);

                var searchItems = BGGConnectorLib.BGGConnector.GetSearchItems("war of man");
                Console.WriteLine($"{searchItems.Items.Length} Search Items");
                //PrintSearchItems(searchItems);

                // Zet ids van zoekopdracht in een lijst.
                var ids = new List<int>();
                foreach (var item in searchItems.Items)
                {
                    ids.Add(item.Id);
                }

                var thingsSearch = BGGConnectorLib.BGGConnector.GetThings(ids);
                Console.WriteLine($"{thingsSearch.Items.Length} Things from Search");
                //PrintThings(thingsSearch);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }

        private static void PrintHotItems(HotItems hotItems)
        {
            Console.WriteLine("Hot Items:");

            foreach (var item in hotItems.Items)
            {
                Console.WriteLine("=========================");
                Console.WriteLine($"ID: {item.Id}");
                Console.WriteLine($"Rank: {item.Rank}");
                Console.WriteLine($"Thumbnail: {item.Thumbnail.Value}");
                Console.WriteLine($"Name: {item.Name.Value}");
                Console.WriteLine($"Year Published: {item.YearPublished.Value}");
            }
        }

        private static void PrintThings(Things things)
        {
            Console.WriteLine("Things:");

            foreach (var item in things.Items)
            {
                Console.WriteLine("=========================");
                Console.WriteLine($"ID: {item.Id}");
                Console.WriteLine($"Description: {item.Description}");
                Console.WriteLine($"Type: {item.Type}");
                Console.WriteLine($"Thumbnail: {item.Thumbnail}");
                Console.WriteLine($"Image: {item.Image}");

                foreach (var name in item.Names)
                {
                    Console.WriteLine($"Name: {name.Type} {name.SortIndex} {name.Value}");
                }

                // Let op: alle onderstaande attributen kunnen null zijn
                if (item.YearPublished != null)
                {
                    Console.WriteLine($"Year Published: {item.YearPublished.Value}");
                }
                if (item.MinPlayers != null)
                {
                    Console.WriteLine($"Min Players: {item.MinPlayers.Value}");
                }
                if (item.MaxPlayers != null)
                {
                    Console.WriteLine($"Max Players: {item.MaxPlayers.Value}");
                }
                if (item.PlayingTime != null)
                {
                    Console.WriteLine($"Playing Time: {item.PlayingTime.Value}");
                }
                if (item.MinPlaytime != null)
                {
                    Console.WriteLine($"Min Playtime: {item.MinPlaytime.Value}");
                }
                if (item.MaxPlaytime != null)
                {
                    Console.WriteLine($"Max Playtime: {item.MaxPlaytime.Value}");
                }
                if (item.MinAge != null)
                {
                    Console.WriteLine($"Min Age: {item.MinAge.Value}");
                }

                // Let op: item.Polls kan null zijn.
                if (item.Polls != null)
                {
                    foreach (var poll in item.Polls)
                    {
                        // Let op: poll.Results kan null zijn
                        Console.WriteLine($"Poll: {poll.Name} {poll.Title} {poll.TotalVotes} ({(poll.Results == null ? 0 : poll.Results.Length)} poll results)");
                    }
                }

                foreach (var link in item.Links)
                {
                    Console.WriteLine($"Link: {link.Type} {link.Id} {link.Value}");
                }
            }
        }

        private static void PrintSearchItems(SearchItems searchItems)
        {
            Console.WriteLine($"Search Items ({searchItems.Total} results):");

            foreach (var item in searchItems.Items)
            {
                Console.WriteLine("=========================");
                Console.WriteLine($"ID: {item.Id}");
                Console.WriteLine($"Name: {item.Name.Type} {item.Name.Value}");
                Console.WriteLine($"Type: {item.Type}");

                // Some items don't have a yearpublished element.
                if (item.YearPublished != null)
                {
                    Console.WriteLine($"Year Published: {item.YearPublished.Value}");
                }
            }
        }
    }
}
