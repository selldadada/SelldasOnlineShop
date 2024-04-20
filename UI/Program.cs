using OnlineShopBusinessServices;
using OnlineShopDataServices;
using OnlineShopModel;
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

            if (result)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("┌──────────────────────────────┐");
                Console.WriteLine("Welcome to Sellda's Tiktok Shop!");
                Console.WriteLine("└──────────────────────────────┘");
                Console.WriteLine("\r\nWhat are you looking for? Please select a Number:");
                Console.WriteLine("");
                Console.WriteLine("  1 Crew Neck Semi Crop Top");
                Console.WriteLine("  2 Crew Neck Full Length Top");
                Console.WriteLine("  3 Baggy Jeans High Waist");
                Console.WriteLine("  4 Wide Leg Trouser High Waist");
                Console.WriteLine("  5 Leather Shoulder Bag");
                Console.WriteLine("  6 Corduroy Sling Bag");
                Console.WriteLine("");

                string num = Console.ReadLine();

                ProductList productList = new ProductList();

                int productIndex = int.Parse(num) - 1;

                if (productIndex >= 0 && productIndex < productList.products.Count)
                {
                    product product = productList.products[productIndex];

                    Console.WriteLine("");
                    Console.WriteLine("╒══════════════════════════════════╕");
                    Console.WriteLine($"Product: {product.name}");
                    Console.WriteLine($"Variations: {product.variation}");
                    Console.WriteLine($"Sizes: {product.size}");
                    Console.WriteLine($"Price: {product.price}");
                    Console.WriteLine("╘══════════════════════════════════╛");
                }

                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Invalid Number Selected");
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
