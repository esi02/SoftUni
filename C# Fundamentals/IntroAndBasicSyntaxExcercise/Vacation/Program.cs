using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var numOfPeople = int.Parse(Console.ReadLine());
            var groupType = Console.ReadLine();
            var day = Console.ReadLine();

            double price = 0;
            switch (groupType)
            {
                case "Students":
                    if (day == "Friday")
                    {
                        price += 8.45;
                    }
                    else if (day == "Saturday")
                    {
                        price += 9.80;
                    }
                    else if (day == "Sunday")
                    {
                        price += 10.46;
                    }
                    break;
                case "Business":
                    if (day == "Friday")
                    {
                        price += 10.90;
                    }
                    else if (day == "Saturday")
                    {
                        price += 15.60;
                    }
                    else if (day == "Sunday")
                    {
                        price += 16;
                    }
                    break;
                case "Regular":
                    if (day == "Friday")
                    {
                        price += 15;
                    }
                    else if (day == "Saturday")
                    {
                        price += 20;
                    }
                    else if (day == "Sunday")
                    {
                        price += 22.50;
                    }
                    break;
            }
            double totalPrice = price * numOfPeople;
            if (numOfPeople >= 30 && groupType == "Students")
            {
                totalPrice *= 0.85;
            }
            else if (numOfPeople >= 100 && groupType == "Business")
            {
                totalPrice -= 10 * price;
            }
            else if (numOfPeople >= 10 && numOfPeople <= 20 && groupType == "Regular")
            {
                totalPrice *= 0.95;
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
