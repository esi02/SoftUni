using System;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededHours = int.Parse(Console.ReadLine());
            int setDays = int.Parse(Console.ReadLine());
            int workersWorkingHome = int.Parse(Console.ReadLine());

            double workableHours = (setDays * 0.90) * 8;
            double homeWorkingHours = (workersWorkingHome * 2) * setDays;
            double totalHours = workableHours + homeWorkingHours;
            if (totalHours >= neededHours)
            {
                double hoursLeft = totalHours - neededHours;
                Console.WriteLine($"Yes!{Math.Floor(hoursLeft)} hours left.");
            }
            else
            {
                double hoursNeeded = neededHours - totalHours;
                Console.WriteLine($"Not enough time!{Math.Ceiling(hoursNeeded)} hours needed.");
            }
        }
    }
}
