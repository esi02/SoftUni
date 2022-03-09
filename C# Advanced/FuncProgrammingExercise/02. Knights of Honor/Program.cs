using System;

namespace _02._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Action<string> print = x => Console.WriteLine($"Sir {x}");

            foreach (var name in names)
            {
                print(name);
            }
        }
    }
}
