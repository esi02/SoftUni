using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double startingMoney = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

            double startingIvanAge = 18;
            double money = startingMoney;
            for (int i = 1800; i <= year; i++)
            {
                if (i % 2 == 0)
                {
                    money -= 12000;
                }
                else
                {
                    money -= 12000 + 50 * startingIvanAge;
                }
                startingIvanAge++;
            }
            if (money < 0)
            {
                Console.WriteLine($"He will need {Math.Abs(money):f2} dollars to survive.");
            }
            else
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {money:f2} dollars left.");
            }
        }
    }
}
