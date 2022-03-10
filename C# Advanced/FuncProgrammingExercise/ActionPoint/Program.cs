using System;

namespace FuncProgrammingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] collection = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Action<string> print = x => Console.WriteLine(x);

            foreach (var item in collection)
            {
                print(item);
            }

        }
    }
}
