using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вход на конзолата
            //1.	Кв. метри, които ще бъдат озеленени – реално число в интервала [0.00… 10000.00]
            double greenLand = double.Parse(Console.ReadLine());
            //Решение
            double priceGreening = greenLand * 7.61;
            double discount = greenLand * 7.61 * 0.18;
            double finalPrice = priceGreening - discount;
            //Принтираме
            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
