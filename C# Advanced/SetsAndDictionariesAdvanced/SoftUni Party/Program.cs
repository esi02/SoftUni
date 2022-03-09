using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var VIPguests = new HashSet<string>();
            var regularGuests = new HashSet<string>();

            while (input != "PARTY")
            {
                if (!VIPguests.Contains(input) && !regularGuests.Contains(input))
                {
                    if (char.IsDigit(input[0]))
                    {
                        VIPguests.Add(input);
                    }
                    else
                    {
                        regularGuests.Add(input);
                    }
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "END")
            {
                if (regularGuests.Contains(input))
                {
                    regularGuests.Remove(input);
                }
                if (VIPguests.Contains(input))
                {
                    VIPguests.Remove(input);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(regularGuests.Count + VIPguests.Count);
            foreach (var item in VIPguests)
            {
                Console.WriteLine(item);
            }
            foreach (var item in regularGuests)
            {
                Console.WriteLine(item);
            }
        }
    }
}
