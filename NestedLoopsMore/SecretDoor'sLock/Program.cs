using System;

namespace SecretDoor_sLock
{
    class Program
    {
        static void Main(string[] args)
        {
            int hundreds = int.Parse(Console.ReadLine());
            int tenths = int.Parse(Console.ReadLine());
            int ones = int.Parse(Console.ReadLine());

            for (int i = 1; i <= hundreds; i++)
            {
                if (i % 2 != 0)
                {
                    continue;
                }
                for (int j = 2; j <= tenths; j++)
                {
                    if (j != 2 && j != 3 && j != 5 && j != 7)
                    {
                        continue;
                    }
                    for (int k = 1; k <= ones; k++)
                    {
                        if (k % 2 != 0)
                        {
                            continue;
                        }
                        Console.WriteLine($"{i} {j} {k}");
                    }
                }
            }
        }
    }
}
