using System;

namespace Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int coins1 = int.Parse(Console.ReadLine());
            int coins2 = int.Parse(Console.ReadLine());
            int money5 = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i <= coins1; i++)
            {
                for (int j = 0; j <= coins2; j++)
                {
                    for (int k = 0; k <= money5; k++)
                    {
                        if (i * 1 + j * 2 + k * 5 == sum)
                        {
                            Console.WriteLine($"{i} * 1 lv. + {j} * 2 lv. + {k} * 5 lv. = {sum} lv.");
                        }
                    }
                }
            }
        }
    }
}
