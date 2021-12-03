using System;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int numOfRotations = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numOfRotations; i++)
            {
                //запазваме някъде първото число за да може след итерациите да го сложим на последно място
                int firstNumber = array[0];
                for (int j = 0; j < array.Length - 1; j++)
                {
                    array[j] = array[j + 1];

                }
                array[array.Length - 1] = firstNumber;
            }
            Console.WriteLine(string.Join(' ', array));
        }
    }
}
