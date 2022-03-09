using System;

namespace StreamOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string output = string.Empty;
            string symbol = string.Empty;
            string word = string.Empty;
            int Ncounter = 0;
            int Ocounter = 0;
            int Ccounter = 0;
            //единствената ми спънка - трябва да конвертирам в буква след командата end и да нулирвам броячите и думата винаги като се изпълни тайната команда
            while (true)
            {
                if (Ncounter >= 1 && Ocounter >= 1 && Ccounter >= 1)
                {
                    word += " ";
                    Ncounter = 0;
                    Ocounter = 0;
                    Ccounter = 0;
                    output += word;
                    word = string.Empty;
                    continue;
                }
                symbol = Console.ReadLine();
                if (symbol == "End")
                {
                    break;
                }
                char currentSymbol = char.Parse(symbol);
                if (!char.IsLetter(currentSymbol))
                {
                    continue;
                }
                if (symbol == "n")
                {
                    Ncounter++;
                    if (Ncounter == 1)
                    {
                        continue;
                    }
                }
                if (symbol == "o")
                {
                    Ocounter++;
                    if (Ocounter == 1)
                    {
                        continue;
                    }
                }
                if (symbol == "c")
                {
                    Ccounter++;
                    if (Ccounter == 1)
                    {
                        continue;
                    }
                }
                word += symbol;
            }
            Console.WriteLine(output);
        }
    }
}
