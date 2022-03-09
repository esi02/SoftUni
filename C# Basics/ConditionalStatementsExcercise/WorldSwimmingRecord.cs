using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double secondsPerMeter = double.Parse(Console.ReadLine());

            double secondsNeeded = distanceInMeters * secondsPerMeter;
            double timeSlowedDown = Math.Floor(distanceInMeters / 15);
            double totalTimeSlowedDown = secondsNeeded + (timeSlowedDown * 12.5);
            if (totalTimeSlowedDown < worldRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTimeSlowedDown:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {Math.Abs(worldRecord - totalTimeSlowedDown):f2} seconds slower.");
            }
        }
    }
}
