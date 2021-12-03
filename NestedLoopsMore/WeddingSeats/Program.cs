using System;

namespace WeddingSeats
{
    class Program
    {
        static void Main(string[] args)
        {
            char lastSector = char.Parse(Console.ReadLine());
            int firstSectorRows = int.Parse(Console.ReadLine());
            int oddRowSeats = int.Parse(Console.ReadLine());

            int seatsCounter = 0;
            int evenSeats = oddRowSeats + 2;
            for (int sectors = 'A'; sectors <= lastSector; sectors++)
            {
                for (int rows = 1; rows <= firstSectorRows; rows++)
                {
                    int currentSeats = rows % 2 == 0 ? evenSeats : oddRowSeats;
                    for (int seats = 'a'; seats < 'a' + currentSeats; seats++)
                    {
                        Console.WriteLine($"{(char)sectors}{rows}{(char)seats}");
                        seatsCounter++;
                    }
                }
                    firstSectorRows++;

            }
            Console.WriteLine(seatsCounter);
        }
    }
}
