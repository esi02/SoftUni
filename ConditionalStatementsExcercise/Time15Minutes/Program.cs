using System;

namespace Time15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int totalMinutes = minutes + 15;
            if (totalMinutes >= 60)
            {
                totalMinutes = totalMinutes % 60;
                hours++;
            }
            if (hours == 24)
            {
                hours = 0;
            }
            string minutesAsString = "";

            if (totalMinutes < 10)
            {
                minutesAsString += '0';
            }
            minutesAsString += totalMinutes;

            Console.WriteLine($"{hours}:{minutesAsString}");
        }
    }
}
