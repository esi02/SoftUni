using System;
using System.Linq;

namespace _6._Reverse_and_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] collection = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int n = int.Parse(Console.ReadLine());

            Func<int, bool> divisible = x => x % n != 0;
            collection = collection.Reverse().ToArray();
            collection = collection.Where(divisible).ToArray();

            Console.WriteLine(string.Join(" ", collection));
        }
    }
}
