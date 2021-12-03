using System;

namespace BarcodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                string first = i.ToString();
                for (int k = 0; k < first.Length; k++)
                {
                    char currentSymbol = first[k];
                    if (currentSymbol % 2 == 0 || currentSymbol == 0)
                    {
                        break;
                    }
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
