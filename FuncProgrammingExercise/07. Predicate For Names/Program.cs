using System;

namespace _07._Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Predicate<string> condition = x => x.Length <= lenght;

            foreach (var item in names)
            {
                if (condition(item))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
