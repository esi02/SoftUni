using System;

namespace FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            //вход
            //1.	Цена на ягодите в лева – реално число в интервала [0.00 … 10000.00]
            //2.Количество на бананите в килограми – реално число в интервала[0.00 … 1 0000.00]
            //3.Количество на портокалите в килограми – реално число в интервала[0.00 … 10000.00]
            //4.Количество на малините в килограми – реално число в интервала[0.00 … 10000.00]
            //5.Количество на ягодите в килограми – реално число в интервала[0.00 … 10000.00]
            double strawberryPrice = double.Parse(Console.ReadLine());
            double bananas = double.Parse(Console.ReadLine());
            double oranges = double.Parse(Console.ReadLine());
            double raspberries = double.Parse(Console.ReadLine());
            double strawberries = double.Parse(Console.ReadLine());
            //решение на задачата
            double raspberryPrice = strawberryPrice / 2;
            double orangesPrice = raspberryPrice * 0.6;
            double bananasPrice = raspberryPrice * 0.2;
            //крайна цена
            double strawberryTotal = strawberryPrice * strawberries;
            double raspberryTotal = raspberryPrice * raspberries;
            double orangesTotal = orangesPrice * oranges;
            double bananasTotal = bananasPrice * bananas;
            double total = strawberryTotal + raspberryTotal + orangesTotal + bananasTotal;
            Console.WriteLine(Math.Round(total, 2));

        }
    }
}
