using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            decimal price = 0;

            switch (product)
            {
                case "coffee":
                    price += 1.50m;
                    break;
                case "water":
                    price += 1.00m;
                    break;
                case "coke":
                    price += 1.40m;
                    break;
                case "snacks":
                    price += 2.00m;
                    break;
            }
            PrintTotalPrice(price, quantity);
        }

        static void PrintTotalPrice(decimal price, int quantity)
        {
            Console.WriteLine($"{price * quantity:f2}");
        }
    }
}
