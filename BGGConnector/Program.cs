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
    }
}
