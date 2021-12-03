using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TheFightForGondor
{
    class Program
    {
        static void Main(string[] args)
        {
            int orcWaves = int.Parse(Console.ReadLine());
            Queue<int> plates = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Stack<int> orcWarriors = new Stack<int>();

            for (int i = 1; i <= orcWaves; i++)
            {
                int[] readWarriors = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                if (plates.Count == 0)
                {
                    break;
                }
                foreach (var item in readWarriors)
                {
                    orcWarriors.Push(item);
                }
                if (i % 3 == 0)
                {
                    int extraPlate = int.Parse(Console.ReadLine());
                    plates.Enqueue(extraPlate);
                }

                int plate = plates.Peek();
                while (plates.Count > 0 && orcWarriors.Count > 0)
                {
                    int orc = orcWarriors.Peek();

                    if (orc > plate)
                    {
                        plates.Dequeue();
                        orc -= plate;
                        orcWarriors.Pop();
                        orcWarriors.Push(orc);
                        if (orc > 0)
                        {
                            continue;
                        }
                    }
                    else if (plate > orc)
                    {
                        orcWarriors.Pop();
                        plate -= orc;
                    }
                    else if (plate == orc)
                    {
                        orcWarriors.Pop();
                        plates.Dequeue();
                    }
                }
            }
            if (plates.Count == 0)
            {
                Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
            }
            else
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");
            }

            if (orcWarriors.Count > 0)
            {
                Console.WriteLine($"Orcs left: {string.Join(", ", orcWarriors)}");
            }

            if (plates.Count > 0)
            {
                Console.WriteLine($"Plates left: {string.Join(", ", plates)}");
            }
        }
    }
}
