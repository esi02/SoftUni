using System;

namespace ConditionalStatementsAdvancedMoreExcercises
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());

            double ticketPrice = 0;
            double totalTicketsPrice = 0;
            switch (category)
            {
                case "VIP":
                    ticketPrice = 499.99;
                    if (people >= 1 && people <= 4)
                    {
                        budget *= 0.25;
                        totalTicketsPrice = people * ticketPrice;
                        if (budget >= totalTicketsPrice)
                        {
                            Console.WriteLine($"Yes! You have {budget - totalTicketsPrice:f2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money! You need {totalTicketsPrice - budget:f2} leva.");
                        }
                    }
                    else if (people >= 5 && people <= 9)
                    {
                        budget *= 0.40;
                        totalTicketsPrice = people * ticketPrice;
                        if (budget >= totalTicketsPrice)
                        {
                            Console.WriteLine($"Yes! You have {budget - totalTicketsPrice:f2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money! You need {totalTicketsPrice - budget:f2} leva.");
                        }
                    }
                    else if (people >= 10 && people <= 24)
                    {
                        budget /= 2;
                        totalTicketsPrice = people * ticketPrice;
                        if (budget >= totalTicketsPrice)
                        {
                            Console.WriteLine($"Yes! You have {budget - totalTicketsPrice:f2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money! You need {totalTicketsPrice - budget:f2} leva.");
                        }
                    }
                    else if (people >= 25 && people <= 49)
                    {
                        budget *= 0.60;
                        totalTicketsPrice = people * ticketPrice;
                        if (budget >= totalTicketsPrice)
                        {
                            Console.WriteLine($"Yes! You have {budget - totalTicketsPrice:f2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money! You need {totalTicketsPrice - budget:f2} leva.");
                        }
                    }
                    else
                    {
                        budget *= 0.75;
                        totalTicketsPrice = people * ticketPrice;
                        if (budget >= totalTicketsPrice)
                        {
                            Console.WriteLine($"Yes! You have {budget - totalTicketsPrice:f2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money! You need {totalTicketsPrice - budget:f2} leva.");
                        }
                    }
                    break;
                case "Normal":
                    ticketPrice = 249.99;
                    if (people >= 1 && people <= 4)
                    {
                        budget *= 0.25;
                        totalTicketsPrice = people * ticketPrice;
                        if (budget >= totalTicketsPrice)
                        {
                            Console.WriteLine($"Yes! You have {budget - totalTicketsPrice:f2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money! You need {totalTicketsPrice - budget:f2} leva.");
                        }
                    }
                    else if (people >= 5 && people <= 9)
                    {
                        budget *= 0.40;
                        totalTicketsPrice = people * ticketPrice;
                        if (budget >= totalTicketsPrice)
                        {
                            Console.WriteLine($"Yes! You have {budget - totalTicketsPrice:f2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money! You need {totalTicketsPrice - budget:f2} leva.");
                        }
                    }
                    else if (people >= 10 && people <= 24)
                    {
                        budget /= 2;
                        totalTicketsPrice = people * ticketPrice;
                        if (budget >= totalTicketsPrice)
                        {
                            Console.WriteLine($"Yes! You have {budget - totalTicketsPrice:f2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money! You need {totalTicketsPrice - budget:f2} leva.");
                        }
                    }
                    else if (people >= 25 && people <= 49)
                    {
                        budget *= 0.60;
                        totalTicketsPrice = people * ticketPrice;
                        if (budget >= totalTicketsPrice)
                        {
                            Console.WriteLine($"Yes! You have {budget - totalTicketsPrice:f2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money! You need {totalTicketsPrice - budget:f2} leva.");
                        }
                    }
                    else
                    {
                        budget *= 0.75;
                        totalTicketsPrice = people * ticketPrice;
                        if (budget >= totalTicketsPrice)
                        {
                            Console.WriteLine($"Yes! You have {budget - totalTicketsPrice:f2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money! You need {totalTicketsPrice - budget:f2} leva.");
                        }
                    }
                    break;
            }
        }
    }
}
