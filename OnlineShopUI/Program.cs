using static System.Formats.Asn1.AsnWriter;
using System.Dynamic;
using OnlineShopBusinessServices;
using OnlineShopDataServices;

namespace OnlineShopUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("┌──────────────────────────────┐");
            Console.WriteLine("Welcome to Sellda's Tiktok Shop!");
            Console.WriteLine("└──────────────────────────────┘");
            Console.WriteLine("\r\nWhat are you looking for? Please select from the Categories:");
            Console.WriteLine("");
            Console.WriteLine("  TOPS");
            Console.WriteLine("  BOTTOMS");
            Console.WriteLine("  BAGS");
            Console.WriteLine("");

            string num = Console.ReadLine();
            switch (num)
            {
                case "TOPS":

                    break;

                case "BOTTOMS":

                    break;

                case "BAGS":

                    break;
            }
        }
    }
}
