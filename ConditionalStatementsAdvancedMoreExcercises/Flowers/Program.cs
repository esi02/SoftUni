using System;

namespace Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int hrizantemiCount = int.Parse(Console.ReadLine());
            int rosesCount = int.Parse(Console.ReadLine());
            int tulipsCount = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holiday = Console.ReadLine();

            if (season == "Spring" || season == "Summer")
            {
                double hrizantemiPrice = 2;
                double rosesPrice = 4.10;
                double tulipsPrice = 2.50;
                double totalPrice = hrizantemiCount * hrizantemiPrice + rosesCount * rosesPrice + tulipsCount * tulipsPrice;
                double totalFlowersCount = hrizantemiCount + rosesCount + tulipsCount;
                if (holiday == "Y")
                {
                    totalPrice *= 1.15;
                    if (tulipsCount >= 7 && season == "Spring")
                    {
                        totalPrice *= 0.95;
                        if (totalFlowersCount > 20)
                        {
                            totalPrice *= 0.80;
                            Console.WriteLine($"{totalPrice + 2:f2}");
                        }
                        else
                        {
                        Console.WriteLine($"{totalPrice + 2:f2}");
                        }
                    }
                    else if (totalFlowersCount > 20)
                    {
                        totalPrice *= 0.80;
                        Console.WriteLine($"{totalPrice + 2:f2}");
                    }
                }
                else
                {
                    if (tulipsCount >= 7 && season == "Spring")
                    {
                        totalPrice *= 0.95;
                        if (totalFlowersCount > 20)
                        {
                            totalPrice *= 0.80;
                            Console.WriteLine($"{totalPrice + 2:f2}");
                        }
                        else
                        {
                        Console.WriteLine($"{totalPrice + 2:f2}");
                                                    }
                    }
                    else if (totalFlowersCount > 20)
                    {
                        totalPrice *= 0.80;
                        Console.WriteLine($"{totalPrice + 2:f2}");
                    }
                }
            }
            else if (season == "Autumn" || season == "Winter")
            {
                double hrizantemiPrice = 3.75;
                double rosesPrice = 4.50;
                double tulipsPrice = 4.15;
                double totalPrice = hrizantemiCount * hrizantemiPrice + rosesCount * rosesPrice + tulipsCount * tulipsPrice;
                double totalFlowersCount = hrizantemiCount + rosesCount + tulipsCount;
                if (holiday == "Y")
                {
                    totalPrice *= 1.15;
                    if (rosesCount >= 10 && season == "Winter")
                    {
                        totalPrice *= 0.90;
                        if (totalFlowersCount > 20)
                        {
                        totalPrice *= 0.80;
                        Console.WriteLine($"{totalPrice + 2:f2}");
                        }
                        else
                        {
                        Console.WriteLine($"{totalPrice + 2:f2}");
                                                    }
                    }
                    else if (totalFlowersCount > 20)
                    {
                        totalPrice *= 0.80;
                        Console.WriteLine($"{totalPrice + 2:f2}");
                    }
                }
                else
                {
                    if (rosesCount >= 10 && season == "Winter")
                    {
                        totalPrice *= 0.90;
                        if (totalFlowersCount > 20)
                        {
                            totalPrice *= 0.80;
                            Console.WriteLine($"{totalPrice + 2:f2}");
                        }
                        else
                        {
                        Console.WriteLine($"{totalPrice + 2:f2}");
                        }
                    }
                    else if (totalFlowersCount > 20)
                    {
                        totalPrice *= 0.80;
                        Console.WriteLine($"{totalPrice + 2:f2}");
                    }
                }
            }
        }
    }
}
