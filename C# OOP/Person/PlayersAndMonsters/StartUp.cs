using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Elf elf = new Elf("karen", 5);
            Console.WriteLine(elf);
        }
    }
}