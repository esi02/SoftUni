using System;
using System.Linq;

namespace ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();


            string action = Console.ReadLine();

            while (action != "end")
            {
                string[] command = action
                    .Split()
                    .ToArray();
                string sentence = command[0];

                if (sentence == "swap")
                {
                    int index1 = int.Parse(command[1]);
                    int index2 = int.Parse(command[2]);

                    int temp = array[index1];
                    array[index1] = array[index2];
                    array[index2] = temp;
                }
                else if (sentence == "multiply")
                {
                    int index1 = int.Parse(command[1]);
                    int index2 = int.Parse(command[2]);

                    array[index1] = array[index1] * array[index2];
                }
                else
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i]--;
                    }
                }
                action = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
