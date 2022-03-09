using System;

namespace TriangleofDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (var i = 1; i <= n; i++)
            {
                for (var j = 1; j <= i; j++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine();
            }
        }
    }
}
