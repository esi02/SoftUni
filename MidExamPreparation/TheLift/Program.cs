using System;
using System.Linq;

namespace TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int[] lift = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            while (people > 0)
            {
                for (int i = 0; i < lift.Length; i++)
                {
                    if (lift[i] < 4)
                    {
                        while (lift[i] < 4 && people > 0)
                        {
                            lift[i]++;
                            people--;
                        }
                    }
                }
                if (lift.All(x => x == 4) && people > 0)
                {
                    break;
                }
            }

            if (people == 0 && lift.Any(x => x < 4))
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", lift));
            }
            else if (people > 0 && lift.All(x => x == 4))
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
                Console.WriteLine(string.Join(" ", lift));
            }
            else
            {
                Console.WriteLine(string.Join(" ", lift));
            }
        }
    }
}
