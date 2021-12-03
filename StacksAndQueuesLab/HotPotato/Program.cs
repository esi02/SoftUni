using System;
using System.Collections.Generic;
using System.Linq;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kids = Console.ReadLine()
                .Split();
            int toss = int.Parse(Console.ReadLine());

            Queue<string> potato = new Queue<string>();

            foreach (var item in kids)
            {
                potato.Enqueue(item);
            }

            while (potato.Count > 1)
            {
                for (int i = 0; i < toss - 1; i++)
                {
                    var potatoKid = potato.Dequeue();
                    potato.Enqueue(potatoKid);
                }
                Console.WriteLine($"Removed {potato.Dequeue()}");
            }
            Console.WriteLine($"Last is {potato.Dequeue()}");
        }
    }
}
