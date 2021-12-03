using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            //Входа е 1.	Броят на дните, в които тече кампанията – цяло число в интервала [0 … 365]
            int campaignDays = int.Parse(Console.ReadLine());
            //2.Броят на сладкарите – цяло число в интервала[0 … 1000]
            int cakeMakers = int.Parse(Console.ReadLine());
            //3.Броят на тортите – цяло число в интервала[0… 2000]
            int cakes = int.Parse(Console.ReadLine());
            //4.Броят на гофретите – цяло число в интервала[0 … 2000]
            int gofreti = int.Parse(Console.ReadLine());
            //5.Броят на палачинките – цяло число в интервала[0 … 2000]
            int pancakes = int.Parse(Console.ReadLine());
            //След това на отделни редове получаваме количеството на тортите,
            //гофретите и палачинките, които ще бъдат приготвени от един сладкар за един ден
            double cakesPerDay = cakes * 45;
            double gofretiPerDay = gofreti * 5.8;
            double pancakesPerDay = pancakes * 3.2;
            //сума
            double totalIncome = (cakesPerDay + gofretiPerDay + pancakesPerDay) * campaignDays * cakeMakers;
            double moneyRaised = totalIncome - (totalIncome / 8);
            //принтиране
            Console.WriteLine(moneyRaised);

        }
    }
}
