using System;

namespace CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());

            int years = centuries * 100;
            decimal days = (decimal)years * 365.2422m;
            long hours = (long)days * 24;
            ulong minutes = (ulong)hours * 60;

            Console.WriteLine($"{centuries} centuries = {years} years = {(int)days} days = {hours} hours = {minutes} minutes");
        }
    }
}
