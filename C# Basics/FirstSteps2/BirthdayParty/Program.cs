using System;

namespace BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            //Входа ни е Наем за залата – реално число в интервала [100.00..10000.00]
            double rent = double.Parse(Console.ReadLine());
            //Торта  – цената ѝ е 20% от наема на залата
            double cake = rent * 0.2;
            //Напитки – цената им е 45 % по - малко от тази на тортата
            double drinks = cake * 0.55;
            //Аниматор – цената му е 1 / 3 от цената за наема на залата
            double animation = rent / 3;
            //Общ бюджет
            double result = rent + cake + drinks + animation;
            //Принтиране
            Console.WriteLine(result);

        }
    }
}
