using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootForTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();
            int countOfShotTargets = 0;

            while (command != "End")
            {
                int currentTarget = int.Parse(command);
                if (currentTarget >= targets.Count)
                {
                    command = Console.ReadLine();
                    continue;
                }

                if (targets[currentTarget] == -1)
                {
                    command = Console.ReadLine();
                    continue;
                }

                for (int i = 0; i < targets.Count; i++)
                {
                    if (targets[i] == -1)
                    {
                        continue;
                    }
                    if (i == currentTarget)
                    {
                        continue;
                    }
                    if (targets[i] > targets[currentTarget])
                    {
                        targets[i] -= targets[currentTarget];
                        continue;
                    }
                    if (targets[i] <= targets[currentTarget])
                    {
                        targets[i] += targets[currentTarget];
                        continue;
                    }
                }
                targets[currentTarget] = -1;
                countOfShotTargets++;

                command = Console.ReadLine();
            }
            Console.WriteLine($"Shot targets: {countOfShotTargets} -> {string.Join(" ", targets)}");
        }
    }
}
