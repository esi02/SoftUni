using System;
using System.Collections.Generic;
using System.Linq;

namespace WarmWinter
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> hats = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Queue<int> scarfs = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            Queue<int> sets = new Queue<int>();

            while (hats.Count > 0 && scarfs.Count > 0)
            {
                int hat = hats.Peek();
                int scarf = scarfs.Peek();

                if (hat > scarf)
                {
                    scarf += hat;
                    sets.Enqueue(scarf);
                    hats.Pop();
                    scarfs.Dequeue();
                }
                else if (scarf > hat)
                {
                    hats.Pop();
                    continue;
                }
                else if (scarf == hat)
                {
                    scarfs.Dequeue();
                    hats.Pop();
                    hat++;
                    hats.Push(hat);
                }
            }
            int mostExpensive = int.MinValue;
            foreach (var set in sets)
            {
                if (set > mostExpensive)
                {
                    mostExpensive = set;
                }
            }

            Console.WriteLine($"The most expensive set is: {mostExpensive}");
            Console.WriteLine(string.Join(" ", sets));
        }
    }
}
