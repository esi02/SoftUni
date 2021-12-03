using System;
using System.Linq;

namespace TheImitationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Decode")
            {
                string[] commandArgs = command.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string action = commandArgs[0];

                if (action == "Move")
                {
                    int numOfLetters = int.Parse(commandArgs[1]);
                    string temp = message.Substring(0, numOfLetters);
                    message = message.Remove(0, numOfLetters);
                    message += temp;
                }
                else if (action == "Insert")
                {
                    int index = int.Parse(commandArgs[1]);
                    string value = commandArgs[2];
                    message = message.Insert(index, value);
                }
                else
                {
                    string susbtring = commandArgs[1];
                    string replacement = commandArgs[2];
                    message = message.Replace(susbtring, replacement);
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}
