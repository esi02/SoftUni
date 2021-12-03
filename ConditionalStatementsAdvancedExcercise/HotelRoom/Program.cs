using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartmentPrice = 0;
            if (month == "May" || month == "October")
            {
                if (nights >= 7 && nights <= 14)
                {
                    studioPrice = 50 * 0.95;
                    apartmentPrice = 65;
                }
                else
                {
                    studioPrice = 50 * 0.70;
                    apartmentPrice = 65 * 0.90;
                }
            }
            else if (month == "June" || month == "September")
            {
                if (nights <= 14)
                {
                    studioPrice = 75.20;
                    apartmentPrice = 68.70;
                }
                else
                {
                    studioPrice = 75.20 * 0.80;
                    apartmentPrice = 77 * 0.90;
                }
            }
            else
            {
                if (nights > 14)
                {
                    studioPrice = 76;
                    apartmentPrice = 77 * 0.90;
                }
                else
                {
                    studioPrice = 76;
                    apartmentPrice = 77;
                }
            }
                double finalStudioPrice = studioPrice * nights;
                double finalApartmentPrice = apartmentPrice * nights;
                Console.WriteLine($"Apartment: {finalApartmentPrice:f2} lv.");
                Console.WriteLine($"Studio: {finalStudioPrice:f2} lv.");
        }
    }
}
