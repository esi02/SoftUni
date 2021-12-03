using System;
using System.Numerics;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger first = BigInteger.Parse(Console.ReadLine());
            ulong second = ulong.Parse(Console.ReadLine());

            BigInteger product = first * second;
            Console.WriteLine(product);
        }
    }
}
