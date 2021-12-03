using System;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            int numOfNights = int.Parse(Console.ReadLine());
            int numOfCards = int.Parse(Console.ReadLine());
            int numOfTickets = int.Parse(Console.ReadLine());

            double totalPricePerPerson = numOfNights * 20 + numOfCards * 1.60 + numOfTickets * 6;
            double totalPrice = totalPricePerPerson * numOfPeople;
            double totalPriceEnd = totalPrice * 1.25;
            Console.WriteLine($"{totalPriceEnd:f2}");
        }
    }
}
