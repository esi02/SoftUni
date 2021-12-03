using System;

namespace DefiningClasses
{
    public class DateModifier
    {
        public string firstDate;
        public string secondDate;
        public double Difference(string firstDate, string secondDate)
        {
            this.firstDate = firstDate;
            this.secondDate = secondDate;

            string[] firstArgs = firstDate.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] secondArgs = secondDate.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int firstYear = int.Parse(firstArgs[0]);
            int firstMonth = int.Parse(firstArgs[1]);
            int firstDays = int.Parse(firstArgs[2]);

            int secondYear = int.Parse(secondArgs[0]);
            int secondMonth = int.Parse(secondArgs[1]);
            int secondDays = int.Parse(secondArgs[2]);

            DateTime first = new DateTime(firstYear, firstMonth, firstDays);
            DateTime second = new DateTime(secondYear, secondMonth, secondDays);

            double difference = (first - second).TotalDays;
            return difference;
        }
    }
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            DateModifier days = new DateModifier();
            days.firstDate = first;
            days.secondDate = second;

            Console.WriteLine(Math.Abs(days.Difference(first, second)));
        }
    }
}
