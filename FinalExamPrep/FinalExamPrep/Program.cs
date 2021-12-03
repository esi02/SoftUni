using System;
using System.Text;
using System.Linq;

namespace FinalExamPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();

            string commands = Console.ReadLine();

            while (commands != "Generate")
            {
                string[] commandsArgs = commands.Split(">>>", StringSplitOptions.RemoveEmptyEntries);
                string action = commandsArgs[0];
                
                if (action == "Contains")
                {
                    string substring = commandsArgs[1];
                    if (activationKey.Contains(substring))
                    {
                        Console.WriteLine($"{activationKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (action == "Flip")
                {
                    string move = commandsArgs[1];
                    int startIndex = int.Parse(commandsArgs[2]);
                    int endIndex = int.Parse(commandsArgs[3]);

                    if (move == "Upper")
                    {
                        for (int i = startIndex; i < endIndex; i++)
                        {
                            string converted = activationKey[i].ToString().ToUpper();
                            activationKey = activationKey.Remove(i, 1);
                            activationKey = activationKey.Insert(i, converted);
                        }
                    }
                    else
                    {
                        for (int i = startIndex; i < endIndex; i++)
                        {
                            string converted = activationKey[i].ToString().ToLower();
                            activationKey = activationKey.Remove(i, 1);
                            activationKey = activationKey.Insert(i, converted);
                        }
                    }

                    Console.WriteLine(activationKey);
                }
                else if (action == "Slice")
                {
                    int startIndex = int.Parse(commandsArgs[1]);
                    int endIndex = int.Parse(commandsArgs[2]);

                    activationKey = activationKey.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(activationKey);
                }

                commands = Console.ReadLine();
            }
            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}
