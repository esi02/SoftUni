using System;
using System.Collections.Generic;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, double> products = new Dictionary<string, double>();

            Dictionary<string, int> quantity = new Dictionary<string, int>();

            while (input != "buy")
            {
                string[] inputArgs = input.Split();

                string productName = inputArgs[0];
                double productPrice = double.Parse(inputArgs[1]);
                int productQuantity = int.Parse(inputArgs[2]);


                if (products.ContainsKey(productName))
                {
                    quantity[productName] += productQuantity;
                    double totalPrice = productPrice * quantity[productName];
                    products[productName] = totalPrice;
                }
                else
                {
                    double totalPrice = productPrice * productQuantity;
                    quantity.Add(productName, productQuantity);
                    products.Add(productName, totalPrice);
                }


                input = Console.ReadLine();
            }

            foreach (var item in products)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }
    }
}
