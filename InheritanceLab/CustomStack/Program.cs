using System;
using System.Collections.Generic;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings stack = new StackOfStrings();
            List<string> items = new List<string>();
            items.Add("1");
            items.Add("2");
            items.Add("3");
            stack.AddRange(items);
        }
    }
}
