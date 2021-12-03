using System;

namespace HairSalon
{
    class Program
    {
        static void Main(string[] args)
        {
            int dailyGoal = int.Parse(Console.ReadLine());

            double price = 0;
            for (int i = 1; i <= dailyGoal; i++)
            {
                string command = Console.ReadLine();
                while (command != "closed")
                {
                    if (command == "haircut")
                    {
                        command = Console.ReadLine();
                        switch (command)
                        {
                            case "mens":
                                price += 15;
                                break;
                            case "ladies":
                                price += 20;
                                break;
                            case "kids":
                                price += 10;
                                break;
                        }
                    }
                    if (command == "color")
                    {
                        command = Console.ReadLine();
                        switch (command)
                        {
                            case "touch up":
                                price += 20;
                                break;
                            case "full color":
                                price += 30;
                                break;
                        }
                    }
                    if (price >= dailyGoal)
                    {
                        Console.WriteLine($"You have reached your target for the day!");
                        Console.WriteLine($"Earned money: {price}lv.");
                        return;
                    }
                    command = Console.ReadLine();
                }
                if (price < dailyGoal)
                {
                    Console.WriteLine($"Target not reached! You need {dailyGoal - price}lv. more.");
                    Console.WriteLine($"Earned money: {price}lv.");
                    return;
                }
            }
        }
    }
}
