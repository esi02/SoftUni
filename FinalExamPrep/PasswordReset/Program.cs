using System;
using System.Text;
using System.Linq;

namespace PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Done")
            {
                string[] commands = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = commands[0];

                if (action == "TakeOdd")
                {
                    string odd = string.Empty;

                    for (int i = 1; i < password.Length; i += 2)
                    {
                        odd += password[i];
                    }

                    password = odd;
                    Console.WriteLine(password);
                }
                else if (action == "Cut")
                {
                    int index = int.Parse(commands[1]);
                    int length = int.Parse(commands[2]);

                    password = password.Remove(index, length);
                    Console.WriteLine(password);
                }
                else if (action == "Substitute")
                {
                    string substring = commands[1];
                    string substitute = commands[2];

                    if (password.Contains(substring))
                    {
                        password = password.Replace(substring, substitute);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Your password is: {password}");
        }
    }
}
