using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeededForVacation = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());
            int days = 0;
            int spendingCounter = 0;
            while (availableMoney < moneyNeededForVacation && spendingCounter < 5)
            {
                string command = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                days++;
                if (command == "save")
                {
                    availableMoney += money;
                    spendingCounter = 0;
                }
                if (command == "spend")
                {
                    availableMoney -= money;
                    spendingCounter++;
                }
                if (availableMoney < 0)
                {
                    availableMoney = 0;
                }
            }
            if (spendingCounter == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(days);
            }
            if (availableMoney >= moneyNeededForVacation)
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }
        }
    }
}
