using System;

namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            decimal headsetPrice = decimal.Parse(Console.ReadLine());
            decimal mousePrice = decimal.Parse(Console.ReadLine());
            decimal keyboardPrice = decimal.Parse(Console.ReadLine());
            decimal displayPrice = decimal.Parse(Console.ReadLine());

            decimal money = (headsetPrice * (lostGames / 2)) + (mousePrice * (lostGames / 3)) + (keyboardPrice * (lostGames / 6)) + (displayPrice * (lostGames / 12));

            Console.WriteLine($"Rage expenses: {money:f2} lv.");
        }
    }
}
