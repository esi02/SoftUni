using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityOfFood = int.Parse(Console.ReadLine());
            int[] quantities = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Queue<int> orders = new Queue<int>(quantities);

                Console.WriteLine(orders.Max());
            
            foreach (var order in quantities)
            {
                if (quantityOfFood - order >= 0)
                {
                    orders.Dequeue();
                    quantityOfFood -= order;
                }
            }

            if (orders.Count == 0 && quantities.Length > 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
            }
        }
    }
}
