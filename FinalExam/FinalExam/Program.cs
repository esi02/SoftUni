using System;

namespace FinalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = commandArgs[0];

                if (action == "Translate")
                {
                    string character = commandArgs[1];
                    string replacement = commandArgs[2];

                    text = text.Replace(character, replacement);
                    Console.WriteLine(text);
                }
                else if (action == "Includes")
                {
                    string @string = commandArgs[1];

                    if (text.Contains(@string))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (action == "Start")
                {
                    string @string = commandArgs[1];

                    if (text.StartsWith(@string))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (action == "Lowercase")
                {
                    text = text.ToLower();
                    Console.WriteLine(text);
                }
                else if (action == "FindIndex")
                {
                    string character = commandArgs[1];
                    int lastIndex = text.LastIndexOf(character);
                    Console.WriteLine(lastIndex);
                }
                else if (action == "Remove")
                {
                    int startIndex = int.Parse(commandArgs[1]);
                    int count = int.Parse(commandArgs[2]);

                    text = text.Remove(startIndex, count);
                    Console.WriteLine(text);
                }

                command = Console.ReadLine();
            }
        }
    }
}
