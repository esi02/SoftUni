using System;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());

            int totalAmountOfSpice = 0;
            int daysCounter = 0;
            while (startingYield >= 100)
            {
                daysCounter++;
                totalAmountOfSpice += startingYield;
                totalAmountOfSpice -= 26;
                startingYield -= 10;
            }
            if (daysCounter > 0)
            {
                totalAmountOfSpice -= 26;
            }

            Console.WriteLine(daysCounter);
            Console.WriteLine(totalAmountOfSpice);
        }
    }
}
