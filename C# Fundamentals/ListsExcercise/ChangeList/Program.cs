using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> manipulation = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandArgs = command.Split();
                string action = commandArgs[0];
                int element = int.Parse(commandArgs[1]);

                if (action == "Delete")
                {
                    manipulation.RemoveAll(x => x.Equals(element));
                }
                else if (action == "Insert")
                {
                    int position = int.Parse(commandArgs[2]);
                    manipulation.Insert(position, element);
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", manipulation));
        }
    }
}
