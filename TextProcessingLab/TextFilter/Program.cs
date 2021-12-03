using System;
using System.Collections.Generic;

namespace TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] banList = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();
            string result = string.Empty;

            for (int i = 0; i < banList.Length; i++)
            {
                result = new string('*', banList[i].Length);
                text = text.Replace(banList[i], result);
            }
            Console.WriteLine(text);
        }
    }
}
