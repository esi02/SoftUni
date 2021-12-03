using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int rackCapacity = int.Parse(Console.ReadLine());
            Stack<int> store = new Stack<int>(clothes);
            int racks = 1;
            int sum = 0;

            for (int i = 0; i < clothes.Length; i++)
            {
                int last = store.Pop();
                sum += last;
                if (sum == rackCapacity && store.Count > 0)
                {
                    racks++;
                    sum = 0;
                }
                if (sum > rackCapacity)
                {
                    racks++;
                    sum = last;
                }
            }
            Console.WriteLine(racks);
        }
    }
}
