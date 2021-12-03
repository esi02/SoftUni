using System;

namespace WorkingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            if (hour >= 10 && hour <= 18)
            {
                if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday" || day == "Saturday")
                {
                    Console.WriteLine("open");
                }
                else if (day == "Sunday")
                {
                    Console.WriteLine("closed");
                }
               
            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}
