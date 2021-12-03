using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = Console.ReadLine()
                .Split()
                .ToList();

            string command = Console.ReadLine();

            while (command != "3:1")
            {
                string[] commandArgs = command.Split();
                string action = commandArgs[0];
                if (action == "merge")
                {
                    string concated = string.Empty;

                    int startIndex = int.Parse(commandArgs[1]);
                    int endIndex = int.Parse(commandArgs[2]);

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }

                    if (startIndex >= strings.Count)
                    {
                        startIndex = strings.Count - 1;
                    }

                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        if (startIndex < 0
                        || startIndex >= strings.Count)
                        {
                            continue;
                        }
                        concated += strings[startIndex];
                        strings.RemoveAt(startIndex);
                    }

                    strings.Insert(startIndex, concated);

                }
                if (action == "divide")
                {
                    string divided = string.Empty;
                    int index = int.Parse(commandArgs[1]);
                    int partitions = int.Parse(commandArgs[2]);

                    string element = strings[index];
                    strings.RemoveAt(index);
                    int parts = element.Length / partitions;
                    List<string> dividedElements = new List<string>();

                    for (int i = 0; i < partitions - 1; i++)
                    {
                        string currentElement = element.Substring(parts * i, parts);
                        dividedElements.Add(currentElement);
                    }


                    string lastElement = element.Substring(parts * (partitions - 1));
                    dividedElements.Add(lastElement);


                    strings.InsertRange(index, dividedElements);
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", strings));
        }
    }
}
