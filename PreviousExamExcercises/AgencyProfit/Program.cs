using System;

namespace AgencyProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            string companyName = Console.ReadLine();
            int ticketsCountForAdults = int.Parse(Console.ReadLine());
            int ticketsCountForKids = int.Parse(Console.ReadLine());
            double ticketPriceForAdults = double.Parse(Console.ReadLine());
            double tax = double.Parse(Console.ReadLine());

            double ticketPriceForKids = ticketPriceForAdults * 0.30;

            double priceForAdultsWithTax = ticketPriceForAdults + tax;
            double priceForKidsWithTax = ticketPriceForKids + tax;

            double finalMoneyFromTickets = (priceForAdultsWithTax * ticketsCountForAdults) + (priceForKidsWithTax * ticketsCountForKids);
            double finalSum = finalMoneyFromTickets * 0.20;
            Console.WriteLine($"The profit of your agency from {companyName} tickets is {finalSum:f2} lv.");
        }
    }
}
