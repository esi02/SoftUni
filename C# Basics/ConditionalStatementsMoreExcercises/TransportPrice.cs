using System;

namespace TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();

            double finalPrice = 0;
            switch (timeOfDay)
            {
                case "day":
                    if (n >= 20 && n < 100)
                    {
                        finalPrice = 0.09 * n;
                    }
                    else if (n >= 100)
                    {
                        finalPrice = 0.06 * n;
                    }
                    else if (n <= 20)
                    {
                        finalPrice = 0.70 + 0.79 * n;
                    }
                    break;
                case "night":
                    if (n >= 20 && n < 100)
                    {
                        finalPrice = 0.09 * n;
                    }
                    else if (n >= 100)
                    {
                        finalPrice = 0.06 * n;
                    }
                    else if(n <= 20)
                    {
                        finalPrice = 0.70 + 0.90 * n;
                    }
                    break;
            }
            Console.WriteLine($"{finalPrice:f2}");
        }
    }
}
