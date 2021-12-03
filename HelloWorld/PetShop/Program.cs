using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вход на конзолата
            //1.	Броят на кучетата – цяло число в интервала [0… 100]
            int numberOfDogs = int.Parse(Console.ReadLine());
            //2.Броят на останалите животни - цяло число в интервала[0… 100]
            int numberOfOtherAnimals = int.Parse(Console.ReadLine());
            //Изчисление
            double priceOfDogFood = numberOfDogs * 2.50;
            double priceOfAnimalsFood = numberOfOtherAnimals * 4;
            //Резултат
            double result = priceOfDogFood + priceOfAnimalsFood;
            Console.WriteLine($"{result} lv.");
        }
    }
}
