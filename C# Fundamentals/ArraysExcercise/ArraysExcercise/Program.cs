using System;

namespace ArraysExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());

            int[] train = new int[wagons];

            int sumOfPeople = 0;
            for (int i = 0; i < wagons; i++)
            {
                train[i] = int.Parse(Console.ReadLine());
                sumOfPeople += train[i];
            }
            Console.WriteLine(string.Join(' ', train));
            Console.WriteLine(sumOfPeople);

        }
    }
}
