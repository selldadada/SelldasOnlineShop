using OnlineShopBusinessServices;
using OnlineShopDataServices;
using OnlineShopModel;
using System;
using System.Collections.Generic;
using System;

namespace OnlineShopUI
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("USER VERIFICATION");
            Console.Write("Enter Username: ");

            string username = Console.ReadLine();

            CustomerServices customerServices = new CustomerServices();
            bool result = customerServices.VerifyCustomer(username);

            List<product> products = new List<product>();

            product croptop = new product();
            croptop.name = "Crew Neck Semi Crop Top";
            croptop.variation = "Black | White | Brown";
            croptop.size = "XS | S | M | L | XL";
            croptop.price = "P149.00";

            product fulllength = new product();
            fulllength.name = "Crew Neck Full Length Top";
            fulllength.variation = "Black | White | Grey";
            fulllength.size = "XS | S | M | L | XL";
            fulllength.price = "P170.00";

            product jeans = new product();
            jeans.name = "Baggy Jeans High Waist";
            jeans.variation = "Dark Blue | Blue | Light Blue";
            jeans.size = "S | M | L";
            jeans.price = "P260.00";

            product trouser = new product();
            trouser.name = "Wide Leg Trouser High Waist";
            trouser.variation = "Brown | Khaki | White";
            trouser.size = " S | M | L";
            trouser.price = "P230.00";

            product leather = new product();
            leather.name = "Leather Shoulder Bag";
            leather.variation = "White | Black | Brown"; ;
            leather.price = "P200.00";

            product corduroy = new product();
            corduroy.name = "Corduroy Sling Bag";
            corduroy.variation = "Brown | Khaki | White";
            corduroy.price = "P170.00";


            products.Add(croptop);
            products.Add(fulllength);
            products.Add(jeans);
            products.Add(trouser);
            products.Add(leather);
            products.Add(corduroy);

            if (result)
            {
                Console.WriteLine("");
                Console.WriteLine("");
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
                        Console.WriteLine("");
                        Console.WriteLine("╒══════════════════════════════╕");
                        Console.WriteLine("Product: " + croptop.name);
                        Console.WriteLine("Variations: " + croptop.variation);
                        Console.WriteLine("Sizes: " + croptop.size);
                        Console.WriteLine("Price: " + croptop.price);
                        Console.WriteLine("╘══════════════════════════════╛");

                        Console.WriteLine("");
                        Console.WriteLine("╒══════════════════════════════╕");
                        Console.WriteLine("Product: " + fulllength.name);
                        Console.WriteLine("Variations: " + fulllength.variation);
                        Console.WriteLine("Sizes: " + fulllength.size);
                        Console.WriteLine("Price: " + fulllength.price);
                        Console.WriteLine("╘══════════════════════════════╛");
                        break;

                    case "BOTTOMS":
                        Console.WriteLine("");
                        Console.WriteLine("╒══════════════════════════════╕");
                        Console.WriteLine("Product: " + jeans.name);
                        Console.WriteLine("Variations: " + jeans.variation);
                        Console.WriteLine("Sizes: " + jeans.size);
                        Console.WriteLine("Price: " + jeans.price);
                        Console.WriteLine("╘══════════════════════════════╛");

                        Console.WriteLine("");
                        Console.WriteLine("╒══════════════════════════════╕");
                        Console.WriteLine("Product: " + trouser.name);
                        Console.WriteLine("Variations: " + trouser.variation);
                        Console.WriteLine("Sizes: " + trouser.size);
                        Console.WriteLine("Price: " + trouser.price);
                        Console.WriteLine("╘══════════════════════════════╛");
                        break;

                    case "BAGS":
                        Console.WriteLine("");
                        Console.WriteLine("╒══════════════════════════════╕");
                        Console.WriteLine("Product: " + leather.name);
                        Console.WriteLine("Variations: " + leather.variation);
                        Console.WriteLine("Sizes: " + leather.size);
                        Console.WriteLine("Price: " + leather.price);
                        Console.WriteLine("╘══════════════════════════════╛");

                        Console.WriteLine("");
                        Console.WriteLine("╒══════════════════════════════╕");
                        Console.WriteLine("Product: " + corduroy.name);
                        Console.WriteLine("Variations: " + corduroy.variation);
                        Console.WriteLine("Sizes: " + corduroy.size);
                        Console.WriteLine("Price: " + corduroy.price);
                        Console.WriteLine("╘══════════════════════════════╛");
                        break;
                }
                return;
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
