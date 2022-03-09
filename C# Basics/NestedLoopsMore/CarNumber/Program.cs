using System;

namespace CarNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    for (int k = start; k <= end; k++)
                    {
                        for (int l = start; l <= end; l++)
                        {
                            if (i % 2 == 0)
                            {
                                if (l % 2 == 0)
                                {
                                    continue;
                                }
                            }
                            if (i % 2 != 0)
                            {
                                if (l % 2 != 0)
                                {
                                    continue;
                                }
                            }
                            if (i < l)
                            {
                                continue;
                            }
                            int sum = j + k;
                            if (sum % 2 != 0)
                            {
                                continue;
                            }
                            Console.Write($"{i}{j}{k}{l} ");
                        }
                    }

                }
            }
        }
    }
}
    