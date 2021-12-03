using System;
using System.Linq;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] arr = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                //презаписвам си нов масив със същите стойности за да ги сравнявам елементите
                //дали са по-големи
                arr[i] = numbers[i];
            }

            int counter = 0;

            for (int j = 0; j < numbers.Length; j++)
            {
                //колко елемента има да проверяваме
                int elementsAfter = numbers.Length - (j + 1);

                for (int i = j + 1; i < arr.Length; i++)
                {
                    if (numbers[j] > arr[i])
                    {
                        counter++;
                    }
                }

                if (counter == elementsAfter && counter != 0 && elementsAfter != 0)
                {
                    //ако текущия елемент е по-голям от всички след него, то брояча и броят на елементите
                    //след него ще са равни
                    Console.Write(numbers[j] + " ");
                }

                counter = 0;

                if (elementsAfter == 0 && counter == 0)
                {
                    //ако няма елементи след текущия, то той винаги ще е голям и трябва да се принтира
                    Console.Write(numbers[numbers.Length - 1]);
                }
            }
        }
    }
}
