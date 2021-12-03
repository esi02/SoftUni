using System;

namespace RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int num = 1; num <= n; num++)
            {
                var sum = 0;
                var digit = 0;
                digit = num;
                while (num > 0)
                {
                    sum += digit % 10;
                    digit /= 10;
                }
                bool isSpecial = sum == 5 || sum == 7 || sum == 11;
                Console.WriteLine($"{num} -> {isSpecial}");
            }
        }
    }
}
