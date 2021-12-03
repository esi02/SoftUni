using System;
using System.Collections.Generic;
using System.Linq;

namespace StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = Console.ReadLine();

            List<Box> products = new List<Box>();

            while (data != "end")
            {
                string[] product = data
                    .Split()
                    .ToArray();

                int serialNumber = int.Parse(product[0]);
                string itemName = product[1];
                int itemQuantity = int.Parse(product[2]);
                decimal itemPrice = decimal.Parse(product[3]);

                Box current = new Box();

                current.serialNumber = serialNumber;
                current.Item.name = itemName;
                current.itemQuantity = itemQuantity;
                current.Item.price = itemPrice;
                current.priceForABox = itemPrice * itemQuantity;

                products.Add(current);

                data = Console.ReadLine();
            }

            var newList = products.OrderByDescending(x => x.priceForABox).ToList();

            foreach (Box product in newList)
            {
                Console.WriteLine(product.serialNumber);
                Console.WriteLine($"-- {product.Item.name} - ${product.Item.price:f2}: {product.itemQuantity}");
                Console.WriteLine($"-- ${product.priceForABox:f2}");
            }
        }
    }
    class Item
    {
        public string name;
        public decimal price;
    }
    class Box
    {
        public Box()
        {
            Item = new Item();
        }
        public int serialNumber;
        public Item Item;
        public int itemQuantity;
        public decimal priceForABox;

    }
}
