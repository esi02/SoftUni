using System;

namespace SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int restDays = int.Parse(Console.ReadLine());

            int workDays = 365 - restDays;
            int totalMinutesForPlay = workDays * 63 + restDays * 127;

            if (totalMinutesForPlay > 30000)
            {
             int minutesLeft = totalMinutesForPlay - 30000;
                int hoursLeft = minutesLeft / 60;
                int minutes = minutesLeft % 60;
                Console.WriteLine("Tom will run away");
                    Console.WriteLine($"{hoursLeft} hours and {minutes} minutes more for play");
            }
            else if (totalMinutesForPlay <= 30000)
            {
                int minutesNeeded = 30000 - totalMinutesForPlay;
                int hoursNeeded = minutesNeeded / 60;
                int minutesN = minutesNeeded % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hoursNeeded} hours and {minutesN} minutes less for play");
            }
        }
    }
}
