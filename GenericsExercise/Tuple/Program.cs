using System;
using System.Collections.Generic;

namespace GenericBox
{
    public class Threeuple<T>
    {
        public T item1 { get; set; }
        public T item2 { get; set; }
        public T item3 { get; set; }
        public Threeuple(T firstItem, T secondItem, T thirdItem)
        {
            item1 = firstItem;
            item2 = secondItem;
            item3 = thirdItem;
            var tuple = new Tuple<T, T, T>(item1, item2, item3);
        }
    }
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] person = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string firstName = person[0];
            string lastName = person[1];
            string address = person[2];
            string town = string.Empty;
            if (person.Length == 5)
            {
                town = person[3] + " " + person[4];
            }
            else
            {
                town = person[3];
            }
            var collect = new Threeuple<IConvertible>(firstName + " " + lastName, address, town);

            person = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string name = person[0];
            int beers = int.Parse(person[1]);
            string drunkOrNot = person[2];
            bool drunk = true;
            if (drunkOrNot == "drunk")
            {
                drunk = true;
            }
            else
            {
                drunk = false;
            }
            var collect2 = new Threeuple<IConvertible>(name, beers, drunk);

            person = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            name = person[0];
            double bankBallance = double.Parse(person[1]);
            string bankName = person[2];
            var collect3 = new Threeuple<IConvertible>(name, bankBallance, bankName);

            Console.WriteLine($"{collect.item1} -> {collect.item2} -> {collect.item3}");
            Console.WriteLine($"{collect2.item1} -> {collect2.item2} -> {collect2.item3}");
            Console.WriteLine($"{collect3.item1} -> {collect3.item2} -> {collect3.item3}");

        }
    }
}

