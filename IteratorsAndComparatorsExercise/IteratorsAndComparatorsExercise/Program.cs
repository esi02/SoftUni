using System;
using System.Collections.Generic;
using System.Linq;

namespace Collection
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            ListyIterator<IConvertible> collection = new ListyIterator<IConvertible>();

            while (command != "END")
            {
                if (command.Contains("Create"))
                {
                    string[] commandArgs = command.Split(new char[] { ' ' },
                             StringSplitOptions.RemoveEmptyEntries);
                    string temp = string.Join(" ", commandArgs.Skip(1));
                    string[] items = temp.Split().ToArray();
                    if (items.Length == 1 && items[0] == "")
                    {
                        collection = new ListyIterator<IConvertible>();
                    }
                    else
                    {
                        collection = new ListyIterator<IConvertible>(items);
                    }
                }
                else if (command == "Move")
                {
                    Console.WriteLine(collection.Move());
                }
                else if (command == "HasNext")
                {
                    Console.WriteLine(collection.HasNext());
                }
                else if (command == "Print")
                {
                    collection.Print();
                }
                else if (command == "PrintAll")
                {
                    Console.WriteLine(string.Join(" ", collection));
                }

                command = Console.ReadLine();
            }
        }
    }
}
