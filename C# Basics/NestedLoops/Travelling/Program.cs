using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            double savedMoney = 0;
            while (destination != "End")
            {
                double minBudget = double.Parse(Console.ReadLine());
                while (savedMoney < minBudget)
                {
                    savedMoney += double.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Going to {destination}!");
                savedMoney = 0;
                destination = Console.ReadLine();
            }
        }
    }
}
