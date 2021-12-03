using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();

            double sum = 0;

            while (num != "NoMoreMoney")
            {
                double money = double.Parse(num);

                if (money < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                sum += money;
                Console.WriteLine($"Increase:{money:f2}");
                num = Console.ReadLine();
            }

            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}
