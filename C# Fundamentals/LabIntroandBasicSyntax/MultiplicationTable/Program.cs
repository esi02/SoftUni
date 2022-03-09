using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (var i = 1; i <= 10; i++)
            {
                var product = n * i;
                Console.WriteLine($"{n} X {i} = {product}");
            }
        }
    }
}
