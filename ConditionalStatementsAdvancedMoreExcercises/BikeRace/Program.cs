using System;

namespace BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniorRacers = int.Parse(Console.ReadLine());
            int seniorRacers = int.Parse(Console.ReadLine());
            string road = Console.ReadLine();

            double taxesJunior = 0;
            double taxesSenior = 0;
            double totalMoney = 0;
            switch (road)
            {
                case "trail":
                    taxesJunior = 5.5;
                    taxesSenior = 7;
                    totalMoney = juniorRacers * taxesJunior + seniorRacers * taxesSenior;
                    totalMoney *= 0.95;
                    Console.WriteLine($"{totalMoney:f2}");
                    break;
                case "cross-country":
                    taxesJunior = 8;
                    taxesSenior = 9.50;
                    totalMoney = juniorRacers * taxesJunior + seniorRacers * taxesSenior;
                    totalMoney *= 0.95;
                    if (juniorRacers + seniorRacers >= 50)
                    {
                        totalMoney *= 0.75;
                        Console.WriteLine($"{totalMoney:f2}");
                    }
                    else
                    {
                        Console.WriteLine($"{totalMoney:f2}");
                    }
                    break;
                case "downhill":
                    taxesJunior = 12.25;
                    taxesSenior = 13.75;
                    totalMoney = juniorRacers * taxesJunior + seniorRacers * taxesSenior;
                    totalMoney *= 0.95;
                    Console.WriteLine($"{totalMoney:f2}");
                    break;
                case "road":
                    taxesJunior = 20;
                    taxesSenior = 21.50;
                    totalMoney = juniorRacers * taxesJunior + seniorRacers * taxesSenior;
                    totalMoney *= 0.95;
                    Console.WriteLine($"{totalMoney:f2}");
                    break;
              }
        }
    }
}
