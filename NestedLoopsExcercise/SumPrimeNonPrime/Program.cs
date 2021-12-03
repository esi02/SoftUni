using System;

namespace SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            //бях пропуснала да проверя с булиъна в уайл цикъла, защото във фор цикъла проверяваме дали са само прости, ако не са, излизаме от него
            int primeSum = 0;
            int nonPrimeSum = 0;
            while (input != "stop")
            {
                int n = int.Parse(input);
                if (n < 0)
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }
                bool NotAPrime = false;
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        NotAPrime = true;
                        break;
                    }
                }
                if (NotAPrime)
                {
                    nonPrimeSum += n;
                }
                else
                {
                    primeSum += n;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
