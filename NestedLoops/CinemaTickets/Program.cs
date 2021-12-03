using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            string ticket = string.Empty;
            int ticketCount = 0;
            int totalTickets = 0;
            int standartCount = 0;
            int studentCount = 0;
            int kidCount = 0;
            while (movie != "Finish")
            {
                int availableSeats = int.Parse(Console.ReadLine());
                while (ticketCount < availableSeats)
                {
                    ticket = Console.ReadLine();
                    if (ticket == "End")
                    {
                        break;
                    }
                    ticketCount++;
                    switch (ticket)
                    {
                        case "standard":
                            standartCount++;
                            break;
                        case "student":
                            studentCount++;
                            break;
                        case "kid":
                            kidCount++;
                            break;
                    }
                }
                double percentage = (double)ticketCount / (double)availableSeats * 100;
                Console.WriteLine($"{movie} - {percentage:f2}% full.");

                totalTickets += ticketCount;
                ticketCount = 0;
                movie = Console.ReadLine();
            }
            double studentPercentage = (double)studentCount / (double)totalTickets * 100;
            double standardPercentage = (double)standartCount / (double)totalTickets * 100;
            double kidPercentage = (double)kidCount / (double)totalTickets * 100;
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentPercentage:f2}% student tickets.");
            Console.WriteLine($"{standardPercentage:f2}% standard tickets.");
            Console.WriteLine($"{kidPercentage:f2}% kids tickets.");
        }
    }
}
