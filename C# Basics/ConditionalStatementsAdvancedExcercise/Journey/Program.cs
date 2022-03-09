using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = string.Empty;
            string placeToStay = string.Empty;
            double price = 1;
            if (budget <= 100 && season == "summer")
            {
                price = 0.70;
                destination = "Bulgaria";
                placeToStay = "Camp";
            }
            else if (budget <= 100 && season == "winter")
            {
                price = 0.30;
                destination = "Bulgaria";
                placeToStay = "Hotel";
            }
            else if (budget <= 1000 && season == "summer")
            {
                price = 0.60;
                destination = "Balkans";
                placeToStay = "Camp";
            }
            else if (budget <= 1000 && season == "winter")
            {
                price = 0.20;
                destination = "Balkans";
                placeToStay = "Hotel";
            }
            else
            {
                price = 0.10;
                destination = "Europe";
                placeToStay = "Hotel";
            }
            double totalPrice = budget - (budget * price);
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{placeToStay} - {totalPrice:f2}");
        }
    }
}
