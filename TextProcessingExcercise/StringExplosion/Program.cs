using System;

namespace StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string explosion = Console.ReadLine();
            int strength = 0;

            for (int i = 0; i < explosion.Length; i++)
            {
                if (strength > 0 && explosion[i] != '>')
                {
                    explosion = explosion.Remove(i, 1);
                    strength--;
                    i--;
                }
                else if (explosion[i] == '>')
                {
                    strength += int.Parse(explosion[i + 1].ToString());
                }
            }
            Console.WriteLine(explosion);
        }
    }
}
