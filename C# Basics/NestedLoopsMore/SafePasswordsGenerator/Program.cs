using System;

namespace SafePasswordsGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int maxPasswords = int.Parse(Console.ReadLine());

            int counter = 0;
            for (int i = 35; i <= 55; i++)
            {
                for (int j = 64; j <= 96; j++)
                {
                    for (int k = 1; k <= a; k++)
                    {
                        for (int l = 1; l <= b; l++)
                        {
                            if (i > 55)
                            {
                                i = 35;
                            }
                            if (j > 96)
                            {
                                j = 64;
                            }
                            if (k == a && l == b)
                            {
                                Console.Write($"{(char)i}{(char)j}{k}{l}{(char)j}{(char)i}|");
                                return;
                            }
                            counter++;
                            if (counter >= maxPasswords)
                            {
                                Console.Write($"{(char)i}{(char)j}{k}{l}{(char)j}{(char)i}|");
                                return;
                            }
                            Console.Write($"{(char)i}{(char)j}{k}{l}{(char)j}{(char)i}|");
                            i++;
                            j++;
                        }
                    }
                }
            }
        }
    }
}
