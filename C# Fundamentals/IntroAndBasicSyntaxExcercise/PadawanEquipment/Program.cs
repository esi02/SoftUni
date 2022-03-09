using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int numOfStudents = int.Parse(Console.ReadLine());
            double sabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            double sabers = sabersPrice * Math.Ceiling(numOfStudents * 1.1);
            double robes = robesPrice * numOfStudents;
            double belts = beltsPrice * (numOfStudents - (numOfStudents / 6));

            double totalMoneyNeeded = sabers + belts + robes;


            if (totalMoneyNeeded <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {totalMoneyNeeded:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalMoneyNeeded - money:f2}lv more.");
            }

        }
    }
}
