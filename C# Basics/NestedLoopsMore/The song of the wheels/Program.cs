using System;

namespace The_song_of_the_wheels
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());

            int counter = 0;
            bool isFour = false;
            int a1 = 0;
            int b1 = 0;
            int c1 = 0;
            int d1 = 0;
            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if (a * b + c * d == M && a < b && c > d)
                            {
                                counter++;
                                Console.Write($"{a}{b}{c}{d} ");
                                if (counter == 4)
                                {
                                    a1 = a;
                                    b1 = b;
                                    c1 = c;
                                    d1 = d;
                                    isFour = true;
                                }
                            }
                        }
                    }
                }
            }
            if (counter < 4)
            {
                Console.WriteLine();
                Console.WriteLine("No!");
            }
            if (isFour)
            {
                Console.WriteLine();
                Console.WriteLine($"Password: {a1}{b1}{c1}{d1}");
            }
        }
    }
}

