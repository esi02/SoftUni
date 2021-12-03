using System;
using System.Linq;

namespace Stack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var collection = new Stack<string>();

            while (input != "END")
            {
                if (input.Contains("Push"))
                {
                    string[] inputArgs = input.Split(new char[] { ' ' },
                             StringSplitOptions.RemoveEmptyEntries);
                    string temp = string.Join(" ", inputArgs.Skip(1));
                    string[] items = temp.Split(", ").ToArray();
                    collection.Push(items);
                }
                else if (input == "Pop")
                {
                    collection.Pop();
                }
                input = Console.ReadLine();
            }

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
