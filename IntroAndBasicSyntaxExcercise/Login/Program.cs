using System;
using System.Linq;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;

            int counter = 0;
            while (password != username)
            {
                counter++;
                if (counter == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                string input = Console.ReadLine();
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    password += input[i];
                }
                if (username != password)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                    password = string.Empty;
                }
            }
            Console.WriteLine($"User {username} logged in.");
        }
    }
}
