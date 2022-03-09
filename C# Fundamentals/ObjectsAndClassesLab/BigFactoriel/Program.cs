using System;
using System.Numerics;

namespace BigFactoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            BigInteger factoriel = N;
            for (int i = N - 1; i >= 1; i--)
            {
                factoriel *= i;
            }
            Console.WriteLine(factoriel);
        }
    }
}
