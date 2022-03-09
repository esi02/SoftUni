using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());

            int cakeSize = width * lenght;
            string command = string.Empty;
            int takenPieces = 0;
            while (cakeSize > 0)
            {
                command = Console.ReadLine();
                if (command == "STOP")
                {
                    Console.WriteLine($"{cakeSize} pieces are left.");
                    break;
                }
                takenPieces = int.Parse(command);
                cakeSize -= takenPieces;
            }
            if (cakeSize <= 0)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cakeSize)} pieces more.");
            }
        }
    }
}
