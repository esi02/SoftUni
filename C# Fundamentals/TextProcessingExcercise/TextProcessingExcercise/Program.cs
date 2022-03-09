using System;
using System.Collections.Generic;

namespace TextProcessingExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] users = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            List<string> validUsers = new List<string>();

            foreach (var user in users)
            {
                bool isValid = false;
                if (user.Length >= 3 && user.Length <= 16)
                {
                    for (int i = 0; i < user.Length; i++)
                    {

                        if (char.IsLetterOrDigit(user[i])
                            || user[i] == '-' || user[i] == '_')
                        {
                            isValid = true;
                        }
                        else
                        {
                            isValid = false;
                            break;
                        }
                    }
                }
                if (isValid)
                {
                    validUsers.Add(user);
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, validUsers));
        }
    }
}
