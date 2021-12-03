using System;
using System.Collections.Generic;
using System.Linq;

namespace Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            var tasks = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            var threads = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            int killTask = int.Parse(Console.ReadLine());

            while (true)
            {
                int task = tasks.Peek();
                int thread = threads.Peek();

                if (task == killTask)
                {
                    tasks.Pop();
                    Console.WriteLine($"Thread with value {thread} killed task {killTask}");
                    break;
                }
                else if (thread >= task)
                {
                    threads.Dequeue();
                    tasks.Pop();
                }
                else if (thread < task)
                {
                    threads.Dequeue();
                }
            }
            Console.WriteLine(string.Join(" ", threads));
        }
    }
}
