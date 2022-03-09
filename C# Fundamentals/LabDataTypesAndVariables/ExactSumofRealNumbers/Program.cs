using System;
using System.Numerics;

namespace ExactSumofRealNumbers
{
    class Program
    {
        public static object BigInteger { get; private set; }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            decimal sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}
