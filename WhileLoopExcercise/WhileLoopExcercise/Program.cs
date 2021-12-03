using System;

namespace WhileLoopExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            int allBooksChecked = 0;
            while (book != "No More Books")
            {
                string checkedBook = Console.ReadLine();
                if (checkedBook == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {allBooksChecked} books.");
                    break;
                }
                if (book == checkedBook)
                {
                    Console.WriteLine($"You checked {allBooksChecked} books and found it.");
                    break;
                }
                allBooksChecked++;
            }
        }
    }
}
