using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            const int dailyGoal = 10_000;
            int stepsToHome = 0;
            string command = string.Empty;
            int totalWalkedSteps = 0;
            while (totalWalkedSteps < dailyGoal)
            {
                command = Console.ReadLine();
                if (command == "Going home")
                {
                    stepsToHome = int.Parse(Console.ReadLine());
                    totalWalkedSteps += stepsToHome;
                    break;
                }
                int steps = int.Parse(command);
                totalWalkedSteps += steps;
            }
            if (totalWalkedSteps >= dailyGoal)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{totalWalkedSteps - dailyGoal} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{(Math.Abs(dailyGoal - totalWalkedSteps))} more steps to reach goal.");
            }
        }
    }
}
