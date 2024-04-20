using OnlineShopModel;
using System.Collections.Generic;
using System;


namespace OnlineShopDataServices
{
    public class ProductList
    {
        public List<product> products;

        public ProductList()
        {
            products = new List<product>()
            {
                new product
                {
                    name = "Crew Neck Semi Crop Top",
                    variation = "Black | White | Brown",
                    size = "XS | S | M | L | XL",
                    price = "P149.00"
                },

                new product
                {
                    name = "Crew Neck Full Length Top",
                    variation = "Black | White | Grey",
                    size = "XS | S | M | L | XL",
                    price = "P170.00"
                },
                new product
                {
                    name = "Baggy Jeans High Waist",
                    variation = "Dark Blue | Blue | Light Blue",
                    size = "S | M | L",
                    price = "P260.00"
                },
                new product
                {
                    name = "Wide Leg Trouser High Waist",
                    variation = "Brown | Khaki | White",
                    size = "S | M | L",
                    price = "P230.00"
                },
                new product
                {
                    name = "Leather Shoulder Bag",
                    variation = "White | Black | Brown",
                    size = "N/A",
                    price = "P200.00"
                },
                new product
                {
                    name = "Corduroy Sling Bag",
                    variation = "Brown | Khaki | White",
                    size = "N/A",
                    price = "P170.00"
                }
            };
        }
    }
}
