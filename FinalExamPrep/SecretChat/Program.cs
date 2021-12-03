using System;
using System.Linq;

namespace SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string concealedMessage = Console.ReadLine();

            string operations = Console.ReadLine();

            while (operations != "Reveal")
            {
                string[] operationsArgs = operations.Split(":|:", StringSplitOptions.RemoveEmptyEntries);
                string action = operationsArgs[0];

                if (action == "InsertSpace")
                {
                    int index = int.Parse(operationsArgs[1]);
                    concealedMessage = concealedMessage.Insert(index, " ");
                    Console.WriteLine(concealedMessage);
                }
                else if (action == "Reverse")
                {
                    string substring = operationsArgs[1];

                    if (concealedMessage.Contains(substring))
                    {
                        int index = concealedMessage.IndexOf(substring);
                        concealedMessage = concealedMessage.Remove(index, substring.Length);

                        var arr = substring.Reverse()
                            .Select(x => concealedMessage += x)
                            .ToArray();

                        Console.WriteLine(concealedMessage);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else
                {
                    string substring = operationsArgs[1];
                    string replacement = operationsArgs[2];

                    concealedMessage = concealedMessage.Replace(substring, replacement);
                    Console.WriteLine(concealedMessage);
                }

                operations = Console.ReadLine();
            }
            Console.WriteLine($"You have a new text message: {concealedMessage}");
        }
    }
}
