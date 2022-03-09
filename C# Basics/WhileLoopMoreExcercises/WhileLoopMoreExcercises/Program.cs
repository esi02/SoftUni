using System;

namespace WhileLoopMoreExcercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int detergentBottles = int.Parse(Console.ReadLine());
            int oneDetergent = 750;
            int totalDetergent = oneDetergent * detergentBottles;
            int onePlate = 5;
            int oneCup = 15;
            int washedPlates = 0;
            int washedCups = 0;
            int totalWashedPlates = 0;
            int totalWashedCups = 0;
            int washCounter = 0;
            string command = string.Empty;
            int detergentUsedForPlates = 0;
            int detergentUsedForCups = 0;

            while (totalDetergent > 0)
            {
                command = Console.ReadLine();
                washCounter++;
                if (command == "End")
                {
                    Console.WriteLine("Detergent was enough!");
                    Console.WriteLine($"{totalWashedPlates} dishes and {totalWashedCups} pots were washed.");
                    Console.WriteLine($"Leftover detergent {totalDetergent} ml.");
                    break;
                }
                if (washCounter % 3 == 0)
                {
                    washedCups = int.Parse(command);
                    detergentUsedForCups = oneCup * washedCups;
                    totalDetergent -= detergentUsedForCups;
                    totalWashedCups += washedCups;
                    continue;
                }
                washedPlates = int.Parse(command);
                detergentUsedForPlates = onePlate * washedPlates;
                totalDetergent -= detergentUsedForPlates;
                totalWashedPlates += washedPlates;
            }
            if (totalDetergent <= 0)
            {
                Console.WriteLine($"Not enough detergent, {Math.Abs(totalDetergent)} ml. more necessary!");
            }
        }
    }
}
