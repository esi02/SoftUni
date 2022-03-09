using System;

namespace ReportSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int money = int.Parse(Console.ReadLine());
            string command = string.Empty;
            double productPrice = 0;
            double cash = 0;
            double card = 0;
            double totalSum = 0;
            double counter = 0;
            double cashCounter = 0;
            double cardCounter = 0;
            while (totalSum < money)
            {
                command = Console.ReadLine();
                counter++;
                if (command == "End")
                {
                    Console.WriteLine("Failed to collect required money for charity.");
                    break;
                }
                productPrice = int.Parse(command);
                if (counter % 2 == 0)
                {
                    if (productPrice < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                        continue;
                    }
                    card += productPrice;
                    cardCounter++;
                    Console.WriteLine("Product sold!");
                }
                else
                {
                    if (productPrice > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                        continue;
                    }
                    cash += productPrice;
                    cashCounter++;
                    Console.WriteLine("Product sold!");
                }
                totalSum = cash + card;
            }
            if (totalSum >= money)
            {
                Console.WriteLine($"Average CS: {cash / cashCounter:f2}");
                Console.WriteLine($"Average CC: {card / cardCounter:f2}");
            }
        }
    }
}
