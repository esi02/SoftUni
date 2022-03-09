using System;
using System.Collections.Generic;

namespace MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            Stack<int> indexes = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    indexes.Push(i);
                }
                else if (expression[i] == ')')
                {
                    int startIndex = indexes.Pop();
                    string subexpression = expression.Substring(startIndex, i - startIndex  + 1);
                    Console.WriteLine(subexpression);
                }
            }
        }
    }
}
