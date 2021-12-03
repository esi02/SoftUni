using System;

namespace Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());
            //проблема ми беше, че не бях изкарала цената на тока като променлива извън цикъла и на други не трябваше да добавям постоянно
            double water = 0;
            double net = 0;
            double electricityBill = 0;
            double others = 0;
            double averagePerMonth = 0;
            for (int i = 1; i <= months; i++)
            {
                double electricity = double.Parse(Console.ReadLine());
                electricityBill += electricity;
                water += 20;
                net += 15;
                others = (electricityBill + water + net) * 1.2;
            }
            averagePerMonth = (electricityBill + water + net + others) / months;
            Console.WriteLine($"Electricity: {electricityBill:f2} lv");
            Console.WriteLine($"Water: {water:f2} lv");
            Console.WriteLine($"Internet: {net:f2} lv");
            Console.WriteLine($"Other: {others:f2} lv");
            Console.WriteLine($"Average: {averagePerMonth:f2} lv");
        }
    }
}
