using System;
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
                PrintHotItems(hotItems);

                var things = BGGConnectorLib.BGGConnector.GetThings(new int[] { 1 });
                PrintThings(things);
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

                Console.WriteLine($"Year Published: {item.YearPublished.Value}");
                Console.WriteLine($"Min Players: {item.MaxPlayers.Value}");
                Console.WriteLine($"Max Players: {item.MinPlayers.Value}");
                Console.WriteLine($"Playing Time: {item.PlayingTime.Value}");
                Console.WriteLine($"Min Playtime: {item.MinPlaytime.Value}");
                Console.WriteLine($"Max Playtime: {item.MaxPlaytime.Value}");
                Console.WriteLine($"Min Age: {item.MinAge.Value}");

                foreach (var poll in item.Polls)
                {
                    Console.WriteLine($"Poll: {poll.Name} {poll.Title} {poll.TotalVotes} ({poll.Results.Length} poll results)");
                }

                foreach (var link in item.Links)
                {
                    Console.WriteLine($"Link: {link.Type} {link.Id} {link.Value}");
                }
            }
        }
    }
}
