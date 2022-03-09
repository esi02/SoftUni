using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            double p = int.Parse(Console.ReadLine());
            double h = int.Parse(Console.ReadLine());

            double weekendsInYear = 48;
            //игрите през почивките
            double gamesInHolidays = p * 2 / 3;
            //изваждаме от уикендите в година уикендите от които си е в родния град
            double weekendsInSofia = (weekendsInYear - h) * 3 / 4;
            double totalGames = h + gamesInHolidays + weekendsInSofia;

            double bonusGames = 0;
            if (yearType == "leap")
            {
                bonusGames = totalGames * 1.15;
                Console.WriteLine(Math.Floor(bonusGames));
            }
            else
            {
                Console.WriteLine(Math.Floor(totalGames));
            }
        }
    }
}
