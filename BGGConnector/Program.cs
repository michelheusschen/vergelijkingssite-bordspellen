using BGGConnectorLib.XMLModels;
using System;

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
                int[] ids = new int[] { 123 };
                var things = BGGConnectorLib.BGGConnector.GetThings(ids);
                PrintThings(things);
            }
            catch(Exception ex)
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

        private static void PrintThings(Things Things)
        {
            Console.WriteLine("Things:");

            foreach (var item in Things.Items)
            {
                Console.WriteLine("=========================");
                Console.WriteLine($"Playingtime: {item.Playingtime.Value}");
                Console.WriteLine($"Minplaytime: {item.Minplaytime.Value}");
                Console.WriteLine($"Maxplaytime: {item.Maxplaytime.Value}");
                Console.WriteLine($"Minage: {item.Minage.Value}");
                foreach (var link in item.Link)
                {
                    Console.WriteLine($"Link: {link.Type} {link.Id} {link.Value}");

                }


            }
        }
    }
}
