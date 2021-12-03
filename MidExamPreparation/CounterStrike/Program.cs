using System;

namespace CounterStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            int distance = 0;
            int wonBattles = 0;

            while (command != "End of battle")
            {
                distance = int.Parse(command);
                if (energy - distance >= 0)
                {
                    energy -= distance;
                    wonBattles++;
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wonBattles} won battles and {energy} energy");
                    return;
                }
                if (wonBattles % 3 == 0)
                {
                    energy += wonBattles;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Won battles: {wonBattles}. Energy left: {energy}");
        }
    }
}
