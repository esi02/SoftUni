using System;
using System.Text;

namespace RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            StringBuilder result = new StringBuilder();

            foreach (var item in array)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    result.Append(item);
                }
            }
            Console.WriteLine(result);
        }
    }
}
