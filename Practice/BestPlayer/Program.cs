using System;

namespace BestPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            string player = Console.ReadLine();
            int goalsCounter = 0;
            string bestPlayer = string.Empty;
            while (player != "END")
            {
                int goals = int.Parse(Console.ReadLine());
                if (goals > goalsCounter)
                {
                    bestPlayer = player;
                    goalsCounter = goals;
                }
                if (goalsCounter >= 10)
                {
                    break;
                }
                player = Console.ReadLine();
            }
            Console.WriteLine($"{bestPlayer} is the best player!");
            if (goalsCounter >= 3)
            {
                Console.WriteLine($"He has scored {goalsCounter} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {goalsCounter} goals.");
            }
        }
    }
}
