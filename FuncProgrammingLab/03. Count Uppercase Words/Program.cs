using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Func<string, bool> uppercase = x => char.IsUpper(x[0]);
            var filtered = text.Where(uppercase);
            Console.WriteLine(string.Join(Environment.NewLine, filtered));
        }
    }
}
