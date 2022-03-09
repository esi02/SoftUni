using System;
using System.Collections.Generic;
using System.Linq;

namespace ThePianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Piece> pieces = new Dictionary<string, Piece>();

            for (int i = 1; i <= n; i++)
            {
                string[] commandArgs = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
                string piece = commandArgs[0];
                string composer = commandArgs[1];
                string key = commandArgs[2];

                if (!pieces.ContainsKey(piece))
                {
                    pieces.Add(piece, new Piece { composer = composer, key = key });
                }
            }

            string input = Console.ReadLine();

            while (input != "Stop")
            {
                string[] inputArgs = input.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string action = inputArgs[0];

                if (action == "Add")
                {
                    string piece = inputArgs[1];
                    string composer = inputArgs[2];
                    string key = inputArgs[3];

                    if (pieces.ContainsKey(piece))
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                    else
                    {
                        pieces.Add(piece, new Piece { composer = composer, key = key });
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                }
                else if (action == "Remove")
                {
                    string piece = inputArgs[1];

                    if (pieces.ContainsKey(piece))
                    {
                        pieces.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                else if (action == "ChangeKey")
                {
                    string piece = inputArgs[1];
                    string newKey = inputArgs[2];

                    if (pieces.ContainsKey(piece))
                    {
                        pieces[piece].key = newKey;
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }

                input = Console.ReadLine();
            }

            var toPrint = pieces
                .OrderBy(x => x.Key)
                .ThenBy(x => x.Value.composer);

            foreach (var item in toPrint)
            {
                Console.WriteLine($"{item.Key} -> Composer: {item.Value.composer}, Key: {item.Value.key}");
            }

        }
    }
    class Piece
    {
        public string composer { get; set; }
        public string key { get; set; }
    }
}
