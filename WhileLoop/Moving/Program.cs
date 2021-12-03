using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            //грешката ми беше, че не слагам проверка с done и че не чета още веднъж input накрая на цикъла. началото ми беше вярно
            int freeSpace = width * length * height;
            string input = Console.ReadLine();
            while (input != "Done")
            {
                int boxes = int.Parse(input);
                freeSpace -= boxes;
                if (freeSpace <= 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(freeSpace)} Cubic meters more.");
                    break;
                }
                input = Console.ReadLine();
            }
            if (input == "Done")
            {
                Console.WriteLine($"{freeSpace} Cubic meters left.");
            }
        }
    }
}
